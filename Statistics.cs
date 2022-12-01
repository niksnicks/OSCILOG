using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscilog
{
    public struct Stats
    {
        public double median;
        public double average;
        public double variance;
        public double stdDeviation;

        public List<List<string>> ToStrings()
        {
            var keys = new List<string>();
            keys.Add("Медиана");
            keys.Add("Среднее значение");
            keys.Add("Дисперсия");
            keys.Add("Стандартное отклонение");

            var vals = new List<string>();
            vals.Add(median.ToString());
            vals.Add(average.ToString());
            vals.Add(variance.ToString());
            vals.Add(stdDeviation.ToString());

            var result = new List<List<string>>();
            result.Add(keys);
            result.Add(vals);
            return result;
        }
    }

    class Statistics
    {
        public static Stats Calculate(List<int> values)
        {
            Stats result;
            result.median = Median(values);
            result.average = Average(values);
            result.variance = Variance(values);
            result.stdDeviation = CalculateStandardDeviation(values);
            return result;
        }

        public static double Median(List<int> sourceNumbers)
        {
            if (sourceNumbers == null || sourceNumbers.Count == 0)
            {
                throw new System.Exception("Median of empty array not defined.");
            }

            //make sure the list is sorted, but use a new array
            var sortedPNumbers = new List<int>(sourceNumbers);
            sortedPNumbers.Sort();

            //get the median
            int size = sortedPNumbers.Count;
            int mid = size / 2;
            double median = (size % 2 != 0) ? (double) sortedPNumbers[mid]
                : ((double)sortedPNumbers[mid] + (double)sortedPNumbers[mid - 1]) / 2;
            return median;
        }

        // среднее
        public static double Average(List<int> values)
        {
            if (values == null || values.Count == 0)
            {
                throw new System.Exception("Average of empty array not defined.");
            }

            int sum = values.Sum();
            double avg = (double)sum / values.Count;
            return avg;
        }

        // стандартное отклонение
        public static double CalculateStandardDeviation(List<int> values)
        {
            double standardDeviation = 0;

            if (values.Any())
            {
                // Compute the average.     
                double avg = values.Average();

                // Perform the Sum of (value-avg)_2_2.      
                double sum = values.Sum(d => Math.Pow(d - avg, 2));

                // Put it all together.      
                standardDeviation = Math.Sqrt((sum) / (values.Count() - 1));
            }

            return standardDeviation;
        }

        // дисперсия
        public static double Variance(List<int> values)
        {
            if (values.Count == 0)
            {
                return 0.0;
            }
            else
            {
                double avg = Average(values);
                double variance = 0.0;
                foreach (int value in values)
                {
                    variance += Math.Pow(value - avg, 2.0);
                }
                return variance / values.Count;
            }
        }
    }
}
