using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3, y = 4, z = 5, zero = 0;
            Lab1.Sum(x, y);
            Lab1.Sum((double) x/2, (double) y/2);
            Lab1.Sum(x, y, z);
            Console.WriteLine($"The sum of {x} and {y} is {Lab1.ReturnSum(x, y).ToString()}.");

            Console.WriteLine($"{x} divided by {y} is {Lab2.Divide(x, y)}.");
            Console.WriteLine($"{x} divided by {y} is {Lab2.Divide((double) x, (double) y)}.");

            Console.WriteLine($"{x} divided by {zero} is {Lab2.Divide(x, zero)}.");
            Console.WriteLine($"{x} divided by {zero} is {Lab2.Divide((double) x, (double) zero)}.");
        }
    }
}
