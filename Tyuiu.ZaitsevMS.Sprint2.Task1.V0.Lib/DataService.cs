using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZaitsevMS.Sprint2.Task1.V24.Lib
{
    public class DataService : ISprint2Task1V24
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a == b) | (c > d);       // True  | False = True
            res[1] = (a == b) & (c > d);       // True  & False = False
            res[2] = (a == b) || (c > d);      // True  || False = True
            res[3] = (a == b) && (c > d);      // True  && False = False
            res[4] = !(c > d);                 // !False = True
            res[5] = (a > c) ^ (a > c);        // True  ^ True  = False

            return res;
        }
    }
}