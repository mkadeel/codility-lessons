using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codility_lessons.Lessons.lesson_09.max_slice_sum
{
 public   class max_slice_sum
    {
        public int solution(int[] A)
        {
            var N = A.Length;

            var max_slice = A[0];
            var max_ending = A[0];

            for (var i = 1; i < N; i++)
            {
                max_ending = Math.Max(A[i], max_ending + A[i]);
                max_slice = Math.Max(max_slice, max_ending);
            }

            return max_slice;
        }
    }
}
