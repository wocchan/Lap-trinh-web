using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class Ex4
    {
        static void Main(string[] args)
        {
            int n, tong = 0;
            Console.Write("Nhap vao mot so nguyen lon hon 0: ");
            n = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 1) continue;
                tong += i;
            }
            Console.WriteLine("tong cua day la: {0} ", tong);
        }

    }
}
