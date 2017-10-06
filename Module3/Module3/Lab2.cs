using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3
{
    class Lab2
    {
        internal static int Divide(int x, int y)
        {
            int result = 0;
            try
            {
                result = x / y;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Attempted to divide by zero.\nException: {ex}");
            }
            
            return result;
        }

        internal static double Divide(double x, double y)
        {
            double result = 0;
            try
            {
                result = x / y;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Attempted to divide by zero.\nException: {ex");
            }

            return result;
        }
    }
}
