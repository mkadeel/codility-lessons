using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codility_lessons.Lessons.lesson_3_time_complexity
{
    public class FrogJump
    {
        public int solution(int X, int Y, int D)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            return (int)Math.Ceiling((double)(Y - X) / D);
        }
    }
}
