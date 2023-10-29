using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.EgovtsevMN.Sprint3.Task6.V.Lib
{
    public class DataService : ISprint3Task6V2
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int i, j, i1;
            j = stopValue;
            int count = 0;
            for (i = startValue; i <= j; i++)
            {
                for (i1 = 1; i1 <= i; i1++)
                {
                    if (i % i1 == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
