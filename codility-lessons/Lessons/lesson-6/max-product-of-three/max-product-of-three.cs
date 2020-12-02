using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codility_lessons.Lessons.lesson_6.max_product_of_three
{
    public class max_product_of_three
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int N = A.Length;
            if (N < 3)
                return 0;

            Array.Sort(A);
            int tmp1 = A[0] * A[1];
            int tmp2 = A[N - 2] * A[N - 3];

            if (A[N - 1] > 0)
                return A[N - 1] * (tmp1 > tmp2 ? tmp1 : tmp2);
            else
                return A[N - 1] * (tmp1 < tmp2 ? tmp1 : tmp2);

        }
    }
}
