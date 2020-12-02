using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codility_lessons.Lessons.lesson_8_leader.equileader
{
    public class equileader
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int size = 0;
            int value = 0;
            int leader = -1;
            int candidate = -1;
            int N = A.Length;
            int index = 0;

            for (int i = 0; i < N; i++)
            {
                if (size == 0)
                {
                    size++;
                    value = A[i];
                }
                else if (value != A[i])
                    size--;
                else
                    size++;
            }

            if (size > 0)
                candidate = value;
            int count = 0;

            for (int i = 0; i < N; i++)
            {
                if (A[i] == candidate)
                {
                    index = i;
                    count++;
                }
            }

            if (count < N / 2)
                return 0;
             
            leader = candidate;
            int equiCount = 0;
            int leaderCount = 0;
            for (int i = 0; i < N; i++)
            {
                if (A[i] == leader)
                {
                    leaderCount++;
                }

                if (leaderCount > (i + 1) / 2 && (count - leaderCount) > (N - i - 1) / 2)
                {
                    equiCount++;
                }
            }

            return equiCount;
        }
    }
}
