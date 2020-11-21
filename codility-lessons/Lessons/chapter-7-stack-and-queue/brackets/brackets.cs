using System;
using System.Collections.Generic;

namespace codility_lessons.Lessons.chapter_7_stack_and_queue
{
    public class brackets
    {
        public int solution(string[] S)
        {
            Stack<char> braces = new Stack<char>();

            char current;
            for (int i = 0; i < S.Length; i++)
            {
                current = Convert.ToChar(S[i]);
                switch (current)
                {
                    case '}':
                        if (braces.Count == 0 || braces.Pop() != '{')
                            return 0;
                        break;
                    case ']':
                        if (braces.Count == 0 || braces.Pop() != '[')
                            return 0;
                        break;
                    case ')':
                        if (braces.Count == 0 || braces.Pop() != '(')
                            return 0;
                        break;
                    default:
                        braces.Push(current);
                        break;
                }
            }
            return braces.Count > 0 ? 0 : 1;
        }
    }
}
