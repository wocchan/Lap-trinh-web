using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_2
{
    internal class Program
    {
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
