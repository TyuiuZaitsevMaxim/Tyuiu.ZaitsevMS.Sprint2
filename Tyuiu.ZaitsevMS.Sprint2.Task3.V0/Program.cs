using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZaitsevMS.Sprint2.Task3.V8.Lib;

namespace Tyuiu.ZaitsevMS.Sprint2.Task3.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Зайцев М. С. | ИБКСб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Вложенные операторы if-else                                       *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Зайцев Максим Сергеевич | ИБКСб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с    *");
            Console.WriteLine("* использованием вложенных операторов if-else, где пользователь вводит    *");
            Console.WriteLine("* значение переменной X с клавиатуры. Округлить значение до 3 знаков      *");
            Console.WriteLine("* после запятой.                                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* y = (sin(x)+cos(x)) / (cos(x)-sin(x)), если x > 0                       *");
            Console.WriteLine("* y = (x^2-cos^2(x)+10) / (x^2-sin^2(x)+12), если x = 0                   *");
            Console.WriteLine("* y = 1 + 3/x^2, если -12 < x < 0                                         *");
            Console.WriteLine("* y = x + 10x - 5/x, если x <= -12                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение переменной X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double res = ds.Calculate(x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Значение функции = " + res);
            Console.ReadLine();
        }
    }
}