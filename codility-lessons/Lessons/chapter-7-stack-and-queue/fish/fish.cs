using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codility_lessons.Lessons.chapter_7_stack_and_queue
{
    public class fish
    {
        public int solution(int[] A, int[] B)
        {
            A = new int[] { 4, 3, 2, 1, 5 };
            B = new int[] { 0, 1, 0, 0, 0 };
            int DOWNSTREAM = 1;
            var downStream = new Stack<int>();
            int noOfFishes = A.Length;

            for (int i = 0; i < A.Length; i++)
            {
                if (B[i] == DOWNSTREAM)
                    downStream.Push(A[i]);
                else
                {
                    while (downStream.Count > 0)
                    {
                        if (A[i] > downStream.Peek())
                        {
                            noOfFishes--;
                            break;
                        }
                        else if (A[i] < downStream.Peek())
                        {
                            noOfFishes--;
                            downStream.Pop();
                        }
                    }
                }
            }
            return noOfFishes;

        }
    }
}
