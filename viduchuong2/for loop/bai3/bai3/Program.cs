using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class Ex3
    {
        static void Main(string[] args)
        {
            int n, tong = 0;
            Console.Write("Nhap vao mot so nguyen lon hon 0: ");
            n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                tong = tong + i;

            }
            Console.WriteLine("tong cua day la: {0}", tong);
        }
    }
}
