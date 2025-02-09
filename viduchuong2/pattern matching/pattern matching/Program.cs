using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_matching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input data: ");
            int.TryParse(Console.ReadLine(), out int n);
            if (n is int count && count > 0)
            {
                Console.WriteLine(new string('*', count));
            }
            else
            {
                Console.WriteLine("Data invalid");
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            {
                Console.Write("Input data: ");
                int.TryParse(Console.ReadLine(), out int n);
                switch (n)
                {
                    case int count when count > 0:
                        Console.WriteLine(new string('*', count));
                        break;
                    default:
                        Console.WriteLine("Data invalid. ");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}