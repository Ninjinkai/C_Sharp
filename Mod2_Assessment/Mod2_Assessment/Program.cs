using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 8;
            int columns = 8;
            string line = "";

            for (int i = 0; i < rows; i++)
            {
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (i % 2 == j % 2)
                        {
                            line += "X";
                        }
                        else
                        {
                            line += "O";
                        }
                    }
                }
                
                Console.WriteLine(line);
                line = "";
            }
        }
    }
}
