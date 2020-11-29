using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codility_lessons.Lessons.lesson_3_time_complexity.prem_missing_elem
{
    public class PremMissingElem
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int N = A.Length + 1;
            long missing = (N * (N + 1)) / 2;
            foreach (int m in A)
            {
                missing -= m;
            }
            return (int)missing;
        }
    }
}
