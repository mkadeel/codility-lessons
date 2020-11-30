using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codility_lessons.Lessons.lesson_5_prefix_sums
{
    public class count_div
    {
        public int solution(int A, int B, int K)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int remainderA = A % K;
            if (remainderA > 0)
            {
                A = A + (K - remainderA);
            }

            if (A > B)
                return 0;
            return (B - A) / K + 1;
        }
    }
}
