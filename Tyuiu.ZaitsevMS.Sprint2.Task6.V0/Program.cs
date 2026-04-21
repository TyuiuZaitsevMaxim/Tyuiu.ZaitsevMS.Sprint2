using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZaitsevMS.Sprint2.Task6.V0.Lib;

namespace Tyuiu.ZaitsevMS.Sprint2.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Зайцев М. С. | ИБКСб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Получение результата из Switch                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнил: Зайцев Максим Сергеевич | ИБКСб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая определяет название месяца по его номеру    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер месяца: ");
            int NumMouth = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((NumMouth < 1) || (NumMouth > 12))
            {
                res = "Введено неверное значение";
            }
            else
            {
                res = NumMouth + " месяц - это " + ds.FindMonthName(NumMouth);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
