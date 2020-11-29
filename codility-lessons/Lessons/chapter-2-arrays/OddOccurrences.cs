using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codility_lessons.Lessons.chapter_2_arrays
{
    public class OddOccurrences
    {
        public int Solution(int[] A)
        {
            int ret=0;
            int N = A.Length;
            for(int i=0;i<N;i++)
            {
                ret = ret ^ A[i];
            }
            return ret;
        }
    }
}
