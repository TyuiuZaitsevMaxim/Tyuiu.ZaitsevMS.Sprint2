using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZaitsevMS.Sprint2.Task5.V15.Lib
{
    public class DataService : ISprint2Task5V15 
    {
        public string FindDayName(int value)
        {
            if (value < 1 || value > 365)
            {
                throw new ArgumentException($"День должен быть от 1 до 365. Значение: {value}");
            }

            string res;

            switch ((value - 1) % 7)
            {
                case 0:
                    res = "Понедельник";
                    break;
                case 1:
                    res = "Вторник";
                    break;
                case 2:
                    res = "Среда";
                    break;
                case 3:
                    res = "Четверг";
                    break;
                case 4:
                    res = "Пятница";
                    break;
                case 5:
                    res = "Суббота";
                    break;
                case 6:
                    res = "Воскресенье";
                    break;
                default:
                    throw new ArgumentException();
            }

            return res;
        }
    }
}