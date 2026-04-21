using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZaitsevMS.Sprint2.Task6.V0.Lib
{
    public class DataService : ISprint2Task6V0
    {
        public string FindMonthName(int value)
        {
            string res;
            switch (value)
            {
                case 1: return "Январь";
                case 2: return "Февраль";
                case 3: return "Март";
                case 4: return "Апрель";
                case 5: return "Май";
                case 6: return "Июнь";
                case 7: return "Июль";
                case 8: return "Август";
                case 9: return "Сентябрь";
                case 10: return "Октябрь";
                case 11: return "Ноябрь";
                case 12: return "Декабрь";
                default: throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {value}"); ;
            }
        }
    }
}
