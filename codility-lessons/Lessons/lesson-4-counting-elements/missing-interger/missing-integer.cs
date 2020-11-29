using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codility_lessons.Lessons.lesson_4_counting_elements.missing_interger
{
   public class missing_integer
    {
        public int Solution(int[] A)
        {
            Array.Sort(A);
            int N = A.Length;
            if (A[N - 1] <= 0)
                return 1;

            if (A[0] > 1)
                return 1;

            for (int i = 0; i < N - 1; i++)
            {
                if (A[i] <= 0)
                {
                    if (A[i + 1] > 1)
                        return 1;
                    continue;
                }
                if (A[i + 1] - A[i] > 1)
                    return A[i] + 1;
            }
            return A[N - 1] + 1;
        }
    }
}
