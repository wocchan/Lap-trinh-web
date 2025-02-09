using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variables of main method
            int x = 1;
            int y = 2;
            // local function
            void AddValue(int a, int b)
            {
                Console.WriteLine("Value of a is: " + a);
                Console.WriteLine("Value of b is: " + b);
                Console.WriteLine("Value of x is: " + x);
                Console.WriteLine("Value of y is: " + y);
                Console.WriteLine("Sum: {0}", a + b + x + y);
                Console.WriteLine();
            }
            // calling local function
            AddValue(3, 4);
            AddValue(5, 6);
            Console.ReadLine();
        }
    }
}
