using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codility_lessons.Lessons.lesson_6
{
    public class distinct
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (A.Length == 0)
                return 0;

            int distinct = 1;
            Array.Sort(A);
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] != A[i - 1])
                    distinct++;
            }
            return distinct;
        }
    }
}
