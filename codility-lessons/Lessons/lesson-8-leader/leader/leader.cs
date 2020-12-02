using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codility_lessons.Lessons.lesson_8_leader.leader
{
    public class leader
    {
        public int Solution()
        {
            int[] A = { 4, 6, 6, 6, 6, 8, 8 };
            int N = A.Length;
            int size = 0;
            int value = 0;
            for (int i = 0; i < N; i++)
            {
                if (size == 0)
                {
                    size++;
                    value = A[i];
                }
                else if (value != A[i])
                {
                    size--;
                }
                else
                    size++;
            }

            int candidate = -1;
            if (size > 0)
                candidate = value;
            int leader = -1;
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                if (A[i] == candidate)
                    count++;
            }

            if (count > N / 2)
                leader = candidate;
            return leader;
        }
    }
}
