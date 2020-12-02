using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codility_lessons.Lessons.lesson_09
{
    public class max_double_slice_sum
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int N = A.Length;
            if (N < 4)
                return 0;
            int[] starting_sum = new int[N];
            int[] ending_sum = new int[N];
            starting_sum[0] = 0;
            ending_sum[N - 1] = 0;
            starting_sum[N - 1] = 0;
            ending_sum[0] = 0;


            for (int i = 1; i < N - 1; i++)
            {
                ending_sum[i] = max(0, ending_sum[i - 1] + A[i]);
                starting_sum[N - 1 - i] = max(0, starting_sum[N - i] + A[N - 1 - i]);
            }

            int maxim = 0;
            for (int i = 1; i < N - 1; i++)
            {
                maxim = max(maxim, ending_sum[i - 1] + starting_sum[i + 1]);
            }
            return maxim;
        }

        int max(int a, int b)
        {
            return a < b ? b : a;
        }
    }
}
