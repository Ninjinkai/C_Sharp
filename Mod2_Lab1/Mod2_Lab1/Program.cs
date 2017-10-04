using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an if decision block
            // Use this if block to check for an even number

            // Request user input with ReadLine()
            Console.WriteLine("Please enter an integer value and press enter.");

            // Assign the entered value to the variable input
            // Convert input to an integer before using
            int input = Int32.Parse(Console.ReadLine());

            // Check to see if the number is even
            if (input % 2 == 0)
            {
                Console.WriteLine("{0} is an even number.", input);
            }
            else
            {
                Console.WriteLine("{0} is an odd number.", input);
            }

        }
    }
}
