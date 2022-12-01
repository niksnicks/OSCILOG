using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace Oscilog
{
    class Word
    {
        // заполняем отчет в Word на основе полученной статстики
        public static void Create(Stats statistics)
        {
            // получаем метрики в строковом виде
            var metrics = statistics.ToStrings();

            try
            {
                // спец объект означающий отсутствие чего-либо
                object missing = System.Reflection.Missing.Value;

                Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();
                winword.ShowAnimation = false;
                winword.Visible = true;

                // создаем новый документ
                Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);

                // добавляем заголовок
                foreach (Section section in document.Sections)
                {
                    Range headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);
                    headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                    headerRange.Font.ColorIndex = WdColorIndex.wdBlue;
                    headerRange.Font.Size = 10;
                    headerRange.Text = "Отчет";
                }

                // добавляем футер
                foreach (Section wordSection in document.Sections)
                {
                    Range footerRange = wordSection.Footers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    footerRange.Font.ColorIndex = WdColorIndex.wdDarkRed;
                    footerRange.Font.Size = 10;
                    footerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                    footerRange.Text = "jsbot@ya.ru, 2022";
                }

                document.Content.SetRange(0, 0);

                // добавляем параграф
                Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
                para1.Range.InsertParagraphAfter();

                // в котором будет таблица
                Table firstTable = document.Tables.Add(para1.Range,
                    metrics[0].Count + 1,
                    metrics.Count,
                    ref missing,
                    ref missing);

                firstTable.Borders.Enable = 1;
                foreach (Row row in firstTable.Rows)
                {
                    foreach (Cell cell in row.Cells)
                    {
                        if (cell.RowIndex != 1)
                        {
                            // строка данных
                            var RowValue = metrics[cell.ColumnIndex - 1];
                            cell.Range.Text = (RowValue[cell.RowIndex - 2]);
                        }
                        else
                        {
                            // заголовочная строка
                            cell.Range.Text = cell.ColumnIndex == 1 ? "Метрика" : "Значение";
                            cell.Range.Font.Bold = 1;
                            cell.Range.Font.Name = "verdana";
                            cell.Range.Font.Size = 10;
                            cell.Shading.BackgroundPatternColor = WdColor.wdColorGray25;
                            cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                            cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // произошло исключение
                MessageBox.Show(ex.Message);
            }  
        }
    }
}
