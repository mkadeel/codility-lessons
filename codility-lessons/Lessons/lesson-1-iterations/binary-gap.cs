using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codility_lessons.Lessons.chapter_1_iterations
{
   public class binary_gap
    {
        public int solution(int N)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            string binary = Convert.ToString(N, 2);
            int maxCount = 0;
            int currentCount = 0;
            bool firstOne = false;
            for (int i = 0; i < binary.Length; i++)
            {
                if (firstOne && binary[i] == '1')
                {
                    firstOne = false;
                    if (currentCount > maxCount)
                        maxCount = currentCount;
                    currentCount = 0;
                }

                if (!firstOne && binary[i] == '1')
                    firstOne = true;

                if (firstOne && binary[i] != '1')
                    currentCount++;
            }
            return maxCount;
        }
    }
}
