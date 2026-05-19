using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZaitsevMS.Sprint2.Task2.V14.Lib
{
    public class DataService : ISprint2Task2V14
    {
        private static readonly int[,] Grid = new int[,]
        {
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,1,1,1,1,0,0 },
            { 0,0,0,1,1,1,0,0,0,0,1,1,1,1,0 },
            { 0,1,1,1,1,0,0,0,0,1,1,1,0,0,0 },
            { 0,1,1,1,1,1,1,1,1,1,1,1,0,0,0 },
            { 0,0,1,1,1,1,1,1,0,0,0,0,0,0,0 },
            { 0,0,1,1,1,1,1,1,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,1,1,1,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,1,1,1,0,0,0,0,1,0,0 },
            { 0,0,0,0,0,1,1,1,0,0,0,0,1,0,0 },
            { 0,0,1,1,1,1,1,1,1,1,1,1,1,0,0 },
            { 0,0,0,0,0,0,1,1,1,1,0,0,1,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,1,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
            { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 },
        };

        public bool CheckDotInShadedArea(int x, int y)
        {
            if (x < 0 || x > 14 || y < 0 || y > 14)
                return false;

            return Grid[y, x] == 1;
        }
    }
}