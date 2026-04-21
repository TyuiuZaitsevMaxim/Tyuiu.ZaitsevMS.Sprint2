using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZaitsevMS.Sprint2.Task3.V0.Lib
{
    public class DataService : ISprint2Task3V0
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x>0)
            {
                y = x + 12;
            }
            else
            {
                if (x == 0)
                {
                    y = 1 / (x + 3);
                }
                else
                {
                    if ((x > -3) && (x < 0))
                    {
                        y = Math.Sin(x);
                    }
                    else
                    {
                        y = ((x - 5) / (x + 3)) + x;
                    }
                }
            }

            return Math.Round(y, 3);
        }
    }
}
