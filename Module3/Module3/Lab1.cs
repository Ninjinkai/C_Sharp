using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3
{
    class Lab1
    {
        internal static void Sum(int first, int second)
        {
            int sum = first + second;
            Console.WriteLine($"The sum of {first} and {second} is {sum}.");
        }

        internal static void Sum(int first, int second, int third)
        {
            int sum = first + second + third;
            Console.WriteLine($"The sum of {first}, {second}, and {third} is {sum}.");
        }

        internal static void Sum(double first, double second)
        {
            double sum = first + second;
            Console.WriteLine($"The sum of {first} and {second} is {sum}.");
        }

        internal static int ReturnSum(int first, int second)
        {
            int sum = first + second;
            return sum;
        }
    }
}
