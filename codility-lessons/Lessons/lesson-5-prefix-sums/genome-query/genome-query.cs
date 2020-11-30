using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codility_lessons.Lessons.lesson_5_prefix_sums.genome_query
{
    public class genome_query
    {
        public int[] solution(string S, int[] P, int[] Q)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int[,] genome = new int[3, S.Length + 1];
            short a, c, g;
            for (int i = 0; i < S.Length; i++)
            {
                a = c = g = 0;
                if (S[i] == 'A')
                    a = 1;
                else if (S[i] == 'C')
                    c = 2;
                else if (S[i] == 'G')
                    g = 3;

                genome[0, i + 1] = genome[0, i] + a;
                genome[1, i + 1] = genome[1, i] + c;
                genome[2, i + 1] = genome[2, i] + g;
            }

            int[] result = new int[P.Length];
            for (int i = 0; i < P.Length; i++)
            {
                int fromIndex = P[i];
                int toIndex = Q[i] + 1;
                if (genome[0, toIndex] - genome[0, fromIndex] > 0)
                    result[i] = 1;
                else if (genome[1, toIndex] - genome[1, fromIndex] > 0)
                    result[i] = 2;
                else if (genome[2, toIndex] - genome[2, fromIndex] > 0)
                    result[i] = 3;
                else result[i] = 4;
            }

            return result;
        }
    }
}
