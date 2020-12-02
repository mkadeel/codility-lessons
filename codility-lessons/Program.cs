using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codility_lessons
{
   public class Program
    {
        public static void Main(string[] args)
        {
            int[] A = { 5, -7, 3, 5, -2, 4, -1 };
            int max_slice, max_ending;
            max_ending = max_slice = 0;
            foreach(int a in A)
            {
                max_ending = max(0, max_ending + a);
                max_slice= max(max_slice, max_ending);
            }

            Console.WriteLine( max_slice);

        }

        static int max(int a , int b)
        {
            return a < b ? b : a;
        }
    }
}
