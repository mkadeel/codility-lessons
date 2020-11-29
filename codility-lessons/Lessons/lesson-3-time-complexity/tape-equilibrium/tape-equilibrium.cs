using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codility_lessons.Lessons.lesson_3_time_complexity.tape_equilibrium
{
    public class tape_equilibrium
    {
        public int solution(int[] A)
        {
            int N = A.Length;
            int sumA = A[0];
            int sumB = Sum(A, 1);
            int difference = Math.Abs(sumA - sumB);
            for (int i = 1; i < N - 1; i++)
            {
                sumA += A[i];
                sumB -= A[i];
                int tempDifference = Math.Abs(sumA - sumB);
                if (tempDifference < difference)
                    difference = tempDifference;
            }

            return difference;
        }

        private int Sum(int[] A, int start)
        {
            int sum = 0;
            for (int i = start; i < A.Length; i++)
            {
                sum += A[i];
            }
            return sum;
        }
    }
}
