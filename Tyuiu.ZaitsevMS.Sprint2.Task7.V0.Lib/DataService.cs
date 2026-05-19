using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZaitsevMS.Sprint2.Task7.V5.Lib
{
    public class DataService : ISprint2Task7V5
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((y <= Math.Exp(-x)) && (y <= Math.Exp(x)) && (y >= Math.Pow(x, 2)))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}