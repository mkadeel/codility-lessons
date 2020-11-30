using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codility_lessons.Lessons.lesson_7_stack_and_queue.stone_wall
{
    public class stone_wall
    {
        public int solution(int[] H)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int N = H.Length;
            Stack<int> stack = new Stack<int>();
            stack.Push(H[0]);

            int blocks = 1;

            for (int i = 0; i < N; i++)
            {
                int currentHeight = 0;
                if (stack.Count > 0)
                {
                    currentHeight = stack.Peek();
                }

                if (currentHeight > H[i])
                {
                    stack.Pop();
                    i--;
                }
                else if (currentHeight < H[i])
                {
                    stack.Push(H[i]);
                    blocks++;
                }
            }

            return blocks;
        }
    }
}
