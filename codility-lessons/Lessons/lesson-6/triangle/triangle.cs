using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codility_lessons.Lessons.lesson_6.triangle
{
    public class triangle
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int N = A.Length;
            if (N < 3)
                return 0;
            Array.Sort(A);

            for (int i = 2; i < N; i++)
            {
                if ((long)A[i] < (long)A[i - 2] + (long)A[i - 1])
                    return 1;
            }
            return 0;
        }
    }
}
