using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codility_lessons.Lessons.lesson_09.max_profit
{
    public class max_profit
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int min = int.MaxValue;
            int N = A.Length;
            int maxProfit = 0;
            foreach (int a in A)
            {
                if (min > a)
                    min = a;
                else
                {
                    maxProfit = Math.Max(maxProfit, a - min);
                }
            }
            return maxProfit;
        }
    }
}
