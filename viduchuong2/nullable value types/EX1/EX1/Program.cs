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
            double? pi = 3.14;
            char? letter = 'a';

            int m2 = 10;
            int? m = m2;
            bool? flag = null;
            //An array of a nullable value type:
            int?[] arr = new int?[10];

            int? a= null;
            if (a is null)
            {
                Console.WriteLine("a does not have a value");
                a = 2050;
            }
            if (a is int valueOfA)
            {
                Console.WriteLine($"a is {valueOfA}"); 
            }
            Console.ReadLine();
        }
    }
}
