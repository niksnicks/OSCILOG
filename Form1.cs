using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using System.IO.Ports;

namespace Oscilog
{
    public partial class Form1 : Form
    {
        private SerialPort mPort;                  // открытый COM порт
        private int mX = 0;                        // текущая точка по X (текущий тик)
        private List<int> mData = new List<int>(); // данные по Y
        private Filter mFilter = new Filter();     // класс фильтра

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            { // инициализируем график серии для верхнего графика
                chartData.Series.Clear();
                var series = chartData.Series.Add("Data Series");
                series.ChartType = SeriesChartType.Line;
                series.XValueType = ChartValueType.Int32;
            }
            { // инициализируем график серии для нижнего графика
                chartFilter.Series.Clear();
                var series = chartFilter.Series.Add("Filter Series");
                series.ChartType = SeriesChartType.Line;
                series.XValueType = ChartValueType.Int32;
            }

            cbFilter.SelectedIndex = 0;
            mFilter.SetWindowSize(4);

            // заполняем комбобокс со всеми доступными COM портами в системе
            string[] ports = SerialPort.GetPortNames();
            if (ports.Count() > 0)
            {
                Array.Sort(ports);
                cbPort.Items.AddRange(ports);
                cbPort.SelectedIndex = 0;
            }
        }

        // кнопка начала / окончания получения данных из COM порта
        private void btStartStop_Click(object sender, EventArgs e)
        {
            string PortName = cbPort.Text;
            if (mPort == null || mPort.IsOpen == false)
            {
                // пробуем соеденится с указанным портом
                mPort = new SerialPort(PortName, 9600, Parity.None, 8, StopBits.One);
                mPort.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
                mPort.Open();
                btStartStop.Text = "Стоп";
            }
            else
            {
                // разрываем связь
                mPort.Close();
                mPort = null;
                btStartStop.Text = "Старт";
            }
        }

        // функция получения данных из COM порта
        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // читаем один байт из порта
            int b = mPort.ReadByte();
            // сохраняем в буффер с данными
            mData.Add(b);
            // и добавляем на верхний график
            chartData.Invoke(new Action(() => {
                chartData.Series[0].Points.AddXY(mX, b);
            }));
            mX += 1;

            // если выбрана переодическая очистка
            if (chClear.Checked)
            {
                if (mX >= slTicks.Value)
                {
                    btClear.Invoke(new Action(() => {
                        btClear.PerformClick();
                    }));
                    return;
                }
            }

            // передаем прочитанное значение фильтру
            int? processed = mFilter.Update(b);
            if (processed.HasValue)
            {
                // и если он нам что-то вернул
                // то отображаем это в нижнем графике
                chartFilter.Invoke(new Action(() => {
                    chartFilter.Series[0].Points.AddXY(mX, processed.Value);
                }));
            }
        }

        // кнопка очистки значений
        private void btClear_Click(object sender, EventArgs e)
        {
            mData.Clear();
            mFilter.Clear();
            chartData.Series[0].Points.Clear();
            chartFilter.Series[0].Points.Clear();
            mX = 0;
        }

        // изменилось значение размера окна для выбранного фильтра
        private void slWindowSize_ValueChanged(object sender, EventArgs e)
        {
            mFilter.SetWindowSize(Convert.ToInt32(slWindowSize.Value)); 
        }

        // изменилося выбранный фильтр
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            mFilter.SetCurrent((FilterKind)cbFilter.SelectedIndex);
            // пересчитываем все данные
            List<int> filteredData = mFilter.UpdateFull(mData);
            // отображаем их в нижнем графике
            chartFilter.Series[0].Points.Clear();
            for (int i = 0; i < filteredData.Count; ++i)
            {
                chartFilter.Series[0].Points.AddXY(i, filteredData[i]);
            }            
        }

        // кнопка сохранения в Word
        private void btSave_Click(object sender, EventArgs e)
        {
            // игнорируем пустые данные
            if (mData.Count < 0)
                return;
            var stats = Statistics.Calculate(mData);
            Word.Create( stats );
        }

        // обработка клика по галочке очищать переодиски
        private void chClear_CheckedChanged(object sender, EventArgs e)
        {
            slTicks.Enabled = (chClear.Checked);
        }
    }
}
