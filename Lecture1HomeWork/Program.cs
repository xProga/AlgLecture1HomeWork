using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1HomeWork
{
    class Program
    {
        static string MaxValueAndTime(int[] arrVal, bool[] boolVal)
        {
            long startTime = DateTime.Now.Millisecond;
            int maxVal = 0;
            for (int i = 0; i < arrVal.Length; i++)
            {
                if (boolVal[i])
                {
                    maxVal = arrVal[i];
                    break;
                }
            }

            for (int i = 0; i < arrVal.Length; i++)
            {
                if (boolVal[i])
                {
                    if (maxVal < arrVal[i])
                    {
                        maxVal = arrVal[i];
                    }
                }
            }
            var searchMaxValTime = DateTime.Now.Millisecond - startTime;

            return $"Максимальное значение: {maxVal} найдено за время: {searchMaxValTime} мс";
        }

        static bool Eratosfen(int divValue, int currentValue)
        {
            if (currentValue % divValue != 0 || currentValue == divValue || divValue == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            int startValue = 1;
            int endValue = 0;
            int[] arrValue;
            bool[] boolValue;
            int divValue;


            Console.Write("Конец последовательности: ");
            endValue = int.Parse(Console.ReadLine());

            int count = endValue - startValue;
            arrValue = new int[count];
            boolValue = new bool[count];

            if (startValue < endValue)
            {
                for (int i = 0; i < count; i++)
                {
                    arrValue[i] = startValue + i;
                    boolValue[i] = true;
                }

                for (int i = 0; i < count; i++)
                {
                    if (boolValue[i])
                    {
                        divValue = arrValue[i];
                        for (int j = 0; j < count; j++)
                        {
                            if (boolValue[j])
                            {
                                boolValue[j] = Eratosfen(divValue, arrValue[j]);
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < count; i++)
            {
                if (boolValue[i])
                {
                    Console.Write($"{arrValue[i]} ");
                }
            }
            Console.WriteLine();
            Console.WriteLine(MaxValueAndTime(arrValue, boolValue));
            Console.ReadKey();
        }
    }
}
