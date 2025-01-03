using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Nhap so nguyen A: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Nhap so nguyen B: ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("Nhap phep tinh (+, -, *, /): ");
                char pheptinh = Console.ReadKey().KeyChar;
                Console.WriteLine();

                double c = 0;
                bool isValidOperator = true;

                switch (pheptinh)
                {
                    case '+':
                        c = a + b;
                        Console.WriteLine("a + b = c : {0} + {1} = {2}", a, b, c);
                        break;

                    case '-':
                        c = a - b;
                        Console.WriteLine("a - b = c : {0} - {1} = {2}", a, b, c);
                        break;

                    case '*':
                        c = a * b;
                        Console.WriteLine("a * b = c : {0} * {1} = {2}", a, b, c);
                        break;

                    case '/':
                        if (b != 0)
                        {
                            c = (double)a / b;
                            Console.WriteLine("a / b = c : {0} / {1} = {2}", a, b, c);
                        }
                        else
                        {
                            Console.WriteLine("Loi: Khong the chia cho 0!");
                            return;
                        }
                        break;

                    default:
                        isValidOperator = false;
                        Console.WriteLine("Loi: Phep tinh khong hop le!");
                        break;
                }

                if (isValidOperator)
                {
                    Console.WriteLine($"Result of {a} {pheptinh} {b} = {c}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Loi: Vui long nhap so nguyen hop le!");
            }

            // Dừng màn hình chờ người dùng nhấn phím
            Console.WriteLine("Nhan phim bat ky de ket thuc...");
            Console.ReadLine();
        }
    }
}
