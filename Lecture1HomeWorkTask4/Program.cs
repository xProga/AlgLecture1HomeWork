using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture1HomeWorkTask4
{
    class Program
    {
        static int quickPow(int value, int pow)
        {
            int tempVal = 1;
            while (pow != 0)
            {
                if (pow % 2 == 0)
                {
                    value = value * value;
                    pow = pow / 2;
                }
                else
                {
                    tempVal = tempVal * value;
                    pow--;
                }
            }
            return tempVal;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int value = int.Parse(Console.ReadLine());
            Console.Write("Введите требуемую степень: ");
            int pow = int.Parse(Console.ReadLine());

            Console.WriteLine($"Итоговое значение: {quickPow(value, pow)}");
            Console.ReadKey();
        }
    }
}
