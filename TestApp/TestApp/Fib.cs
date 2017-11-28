using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class Fib
    {
        public static int RecursiveFib(int n)
        {
            if (n < 0)
            {
                return -1;
            }
            else if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return RecursiveFib(n - 1) + RecursiveFib(n - 2);
            }
        }
    }
}
