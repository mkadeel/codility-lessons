using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codility_lessons.Lessons.lesson_4_counting_elements.prem_check
{
    public class prem_check
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int N = A.Length;
            bool[] check = new bool[N + 1];
            for (int i = 0; i < N; i++)
            {
                if (A[i] > N) return 0;
                if (check[A[i]]) return 0;
                check[A[i]] = true;
            }
            return 1;
        }
    }
}
