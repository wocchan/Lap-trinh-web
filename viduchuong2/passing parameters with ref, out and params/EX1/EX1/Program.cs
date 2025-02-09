using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    internal class Program
    {
        static void MyMethod(int a, ref int b, out int c)
        {
            a = 3;
            b = 4;
            c = 5;
        }
        static void Main(string[] args)
        {
            int x = 1, y = 2, z;
            MyMethod(x, ref y, out z);
            Console.WriteLine($"x:{x}, y:{y}, z:{z}");
            Console.ReadLine();
        }
    }
}
