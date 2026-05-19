using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZaitsevMS.Sprint2.Task7.V5.Lib;

namespace Tyuiu.ZaitsevMS.Sprint2.Task7.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Зайцев М. С. | ИБКСб-25-1"; 

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Итоговый проект по спринту                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Зайцев Максим Сергеевич | ИБКСб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, определяющую, находится ли точка с координатами     *");
            Console.WriteLine("* X,Y в заштрихованной области:                                           *");
            Console.WriteLine("* y<=e^-x; y<=e^x; y>=x^2                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (res)
            {
                Console.WriteLine("Точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не находится в заштрихованной области");
            }

            Console.ReadLine();
        }
    }
}