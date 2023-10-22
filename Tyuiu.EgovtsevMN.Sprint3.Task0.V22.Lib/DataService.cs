using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.EgovtsevMN.Sprint3.Task0.V22.Lib
{
    public class DataService : ISprint3Task1V30
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double res = 0;
            double t = 0.5;

            int k = startValue;
            while (k <= stopValue)
            {
                double term = Math.Pow(t, k) + (5.0 / (k + 4)) * Math.Sin(t);
                res += term;
                k++;
            }

            return Math.Round(res, 3);
        }
    }
}
