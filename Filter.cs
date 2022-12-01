 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilog
{
    // поддерживаемые фильтры
    // код фильтра должен соответсвовать порядку, указанному в соответсвующем Combobox
    public enum FilterKind
    {
        FilterMedian, // медианный фильтр
        FilterSMA,    // скользящая средняя
    }

    class Filter
    {
        private FilterKind mCurrent = FilterKind.FilterMedian;   // выбранный тип фильтра
        private LinkedList<int> mWindow = new LinkedList<int>(); // окно значений
        private int mCurrentIndex = 0;                           // текущий индекс в окне

        // устанавливаем значение текущего фильтра
        public void SetCurrent(FilterKind kind)
        {
            mCurrent = kind;
            mCurrentIndex = 0;
        }

        // очищаем 
        public void Clear()
        {
            mCurrentIndex = 0;
        }

        // размер окна расчета
        public void SetWindowSize(int windowSize)
        {
            if (mWindow == null)
            {
                mWindow = new LinkedList<int>();
            }
            if (mWindow.Count < windowSize)
            {
                while (mWindow.Count < windowSize)
                {
                    mWindow.AddLast(0);
                }
            }
            else
            {
                while (mWindow.Count > windowSize)
                {
                    mWindow.RemoveFirst();
                }
            }
            mCurrentIndex = 0;
        }

        // полный перерасчет отфильтрованного графика 
        public List<int> UpdateFull(List<int> values)
        {
            var result = new List<int>();
            var win = new LinkedList<int>();

            if (mCurrent == FilterKind.FilterMedian)
            {
                int current = 0;
                // заполним окно данными в первый раз
                // затем на каждой итерации будем просто удалять значение с начала
                // и добавлять новое значение в конец
                for (current = 0; current < mWindow.Count && current < values.Count; ++current) {
                    win.AddLast(values[current]);
                }
                
                for (; win.Count > 0 ;) {
                    // находим медиану
                    var list = new List<int>(win);
                    list.Sort();
                    int med = list[list.Count / 2];
                    result.Add(med);

                    // проверяем не вышли ли мы за пределы данных
                    if (current >= values.Count) break;

                    // удаляем с начала
                    // и добавляем новое значение в конец
                    win.RemoveFirst();
                    win.AddLast(values[current]);

                    current += 1;
                }
            }
            else if (mCurrent == FilterKind.FilterSMA)
            {
                int current = 0;
                // заполним окно данными в первый раз
                // затем на каждой итерации будем просто удалять значение с начала
                // и добавлять новое значение в конец
                for (current = 0; current < mWindow.Count && current < values.Count; ++current) {
                    win.AddLast(values[current]);
                }

                for (; win.Count > 0; )
                {
                    // находим среднее значение для текущего окна
                    int avg = win.Sum() / win.Count;
                    result.Add(avg);

                    // проверяем не вышли ли мы за пределы данных
                    if (current >= values.Count) break;

                    // удаляем с начала
                    // и добавляем новое значение в конец
                    win.RemoveFirst();
                    win.AddLast(values[current]);

                    current += 1;
                }
            }

            // сохраняем значение окна
            mWindow = win;

            return result;
        }

        // частичный перерасчет отфильтрованного графика 
        // на базе данных из окна
        public Nullable<int> Update(int newValue)
        {
            if (mCurrentIndex != mWindow.Count())
            {
                mCurrentIndex += 1;
                mWindow.RemoveFirst();
                mWindow.AddLast(newValue);
            }
            else
            {
                mWindow.RemoveFirst();
                mWindow.AddLast(newValue);
                if (mCurrent == FilterKind.FilterMedian)
                {
                    var list = new List<int>(mWindow);
                    list.Sort();
                    return list[list.Count / 2];
                }
                else if (mCurrent == FilterKind.FilterSMA)
                {
                    return mWindow.Sum() / mWindow.Count;
                }
            }
            return new Nullable<int>();
        }
    }
}
