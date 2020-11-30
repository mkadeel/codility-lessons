using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codility_lessons.Lessons.lesson_5_prefix_sums.min_avg_two_slice
{
    public class min_avg_slice
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            double minV = (A[0] + A[1]) / 2;
            int minP = 0;
            int N = A.Length;
            for (int i = 0; i < N - 2; i++)
            {
                double tempMinV = min((A[i] + A[i + 1]) / 2.0, (A[i] + A[i + 1] + A[i + 2]) / 3.0);
                if (tempMinV < minV)
                {
                    minV = tempMinV;
                    minP = i;
                }
            }

            if ((A[N - 2] + A[N - 1]) / 2.0 < minV)
                minP = N - 2;

            return minP;
        }

        double min(double a, double b)
        {
            return a < b ? a : b;
        }
    }
}
