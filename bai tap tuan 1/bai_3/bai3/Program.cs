using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    class PrimeNumberCheck
    {
        static void Main()
        {
            int n;

            do
            {
                Console.Write("Nhap mot so (n >= 2): ");
                if (int.TryParse(Console.ReadLine(), out n) && n >= 2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Gia tri khong hop le. Vui long nhap lai mot so >= 2.");
                }
            } while (true);

            //check
            if (IsPrime(n))
            {
                Console.WriteLine($"{n} la so nguyen to.");
            }
            else
            {
                Console.WriteLine($"{n} khong phai la so nguyen to.");
            }

            Console.WriteLine("Nhan phim bat ky de thoat...");
            Console.ReadLine();
        }

        //phuong thuc check
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false; //khong phai la so nguyen to
                }
            }
            return true; //la so nguyen to
        }
    }
}
