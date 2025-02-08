using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    internal class Ex2
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i = i + 2)
            {
                Console.WriteLine("Value of i: {0}", i);
            }
        }
    }
}
