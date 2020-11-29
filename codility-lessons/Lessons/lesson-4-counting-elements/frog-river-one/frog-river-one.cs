using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codility_lessons.Lessons.lesson_4_counting_elements
{
    public class frog_river_one
    {
        public int solution(int X, int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int N = A.Length;
            bool[] landed = new bool[X + 1];
            for (int i = 0; i < N; i++)
            {
                if (!landed[A[i] - 1])
                {
                    landed[A[i] - 1] = true;
                    if (--X == 0)
                        return i;
                }
            }

            return -1;
        }
    }
}
