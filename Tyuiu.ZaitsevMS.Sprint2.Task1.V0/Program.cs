using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZaitsevMS.Sprint2.Task1.V0.Lib;

namespace Tyuiu.ZaitsevMS.Sprint2.Task1.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 15;
            int b = 16;
            int c = 14;
            int d = 17;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.Title = "Спринт #2 | Выполнил: Зайцев М. С. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнил: Зайцев Максим Сергеевич | ИБКСб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений. Последовательность можно      *");
            Console.WriteLine("* чередовать, но использовать один раз в выражении и логических операций  *");
            Console.WriteLine("* и арифметических выражений, которая вернет логическую                   *");
            Console.WriteLine("* последовательность (массив) при a = 15, b = 16, c = 14, d = 17          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.Read();
        }
    }
}
