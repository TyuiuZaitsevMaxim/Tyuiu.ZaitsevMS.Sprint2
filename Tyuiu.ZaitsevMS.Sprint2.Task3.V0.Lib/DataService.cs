using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZaitsevMS.Sprint2.Task3.V8.Lib
{
    public class DataService : ISprint2Task3V8
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 0)
            {
                y = (Math.Sin(x) + Math.Cos(x)) / (Math.Cos(x) - Math.Sin(x));
            }
            else
            {
                if (x == 0)
                {
                    y = (x * x - Math.Cos(x) * Math.Cos(x) + 10) /
                        (x * x - Math.Sin(x) * Math.Sin(x) + 12);
                }
                else
                {
                    if (x > -12)
                    {
                        y = 1 + 3 / (x * x);
                    }
                    else
                    {
                        y = x + 10 * x - 5 / x;
                    }
                }
            }

            return Math.Round(y, 3);
        }
    }
}