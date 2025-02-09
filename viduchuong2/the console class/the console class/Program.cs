using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace the_console_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double d;
            int i;
            string s;
            DateTime date;
            Console.WriteLine("***** Data Type Parsing *****");
            Console.Write("Enter a String value:");
            s = Console.ReadLine();
            Console.Write("Enter a Double value:");
            d = double.Parse(Console.ReadLine());
            Console.Write("Enter a Interger value:");
            i = int.Parse(Console.ReadLine());
            Console.Write("Enter a Data value:");
            date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"Value of s:{s}, i:{i}, d:{d}, date:{date:dd/MM/yyyy}");
            Console.ReadLine();
        }
    }
}
