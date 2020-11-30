using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codility_lessons.Lessons.chapter_7_stack_and_queue
{
    public class Nesting
    {
        public int Solution(string S)
        {
            var stack = new Stack<char>();
            char current;
            foreach(var c in S)
            {
                if (c == '(')
                    stack.Push(c);
                else if (stack.Count > 0)
                {
                   current = stack.Pop();
                    if (current != ')')
                        return 0;
                }
                else
                    return 0;
            }
            return stack.Count > 0 ? 0 : 1;
        }
    }
}
