using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Calculation
    {
        public string[] inputArray;
        public string sumResult, productResult;

        public string GetSumResult(string[] inputArray )
        {
            // инициализируем переменные
            int sum = 0;
            int product = 1;

            // ищем минимальный и максимальный элементы
            int minIndex = 0;
            int maxIndex = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                int currentValue = int.Parse(inputArray[i]);
                if (currentValue < int.Parse(inputArray[minIndex]))
                {
                    minIndex = i;
                }
                if (currentValue > int.Parse(inputArray[maxIndex]))
                {
                    maxIndex = i;
                }

                // суммируем положительные элементы
                if (currentValue > 0)
                {
                    sum += currentValue;
                }
            }

            // вычисляем произведение чисел между минимальным и максимальным элементами
            int startIndex = Math.Min(minIndex, maxIndex) + 1;
            int endIndex = Math.Max(minIndex, maxIndex);
            for (int i = startIndex; i < endIndex; i++)
            {
                product *= int.Parse(inputArray[i]);
            }

            // выводим результаты
            sumResult = sum.ToString();

            return sumResult; 
        }

        public string GetProductResult(string[] inputArray)
        {
            // инициализируем переменные
            int sum = 0;
            int product = 1;

            // ищем минимальный и максимальный элементы
            int minIndex = 0;
            int maxIndex = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                int currentValue = int.Parse(inputArray[i]);
                if (currentValue < int.Parse(inputArray[minIndex]))
                {
                    minIndex = i;
                }
                if (currentValue > int.Parse(inputArray[maxIndex]))
                {
                    maxIndex = i;
                }

                // суммируем положительные элементы
                if (currentValue > 0)
                {
                    sum += currentValue;
                }
            }

            // вычисляем произведение чисел между минимальным и максимальным элементами
            int startIndex = Math.Min(minIndex, maxIndex) + 1;
            int endIndex = Math.Max(minIndex, maxIndex);
            for (int i = startIndex; i < endIndex; i++)
            {
                product *= int.Parse(inputArray[i]);
            }

            // выводим результаты
            productResult = product.ToString();

            return productResult;
        }

    }
}
