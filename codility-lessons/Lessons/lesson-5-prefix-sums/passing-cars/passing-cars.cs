using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codility_lessons.Lessons.lesson_5_prefix_sums.passing_cars
{
    public class passing_cars
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int counter = 0;
            int multiplier = 0;
            int N = A.Length;

            for (int i = 0; i < N; i++)
            {
                if (A[i] != 0)
                {
                    counter += multiplier;

                    if (counter > 1000000000)
                        return -1;
                }
                else
                {
                    multiplier++;
                }
            }
            return counter;
        }
    }
}
