using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tao nn so
            Random random = new Random();
            int winningNumber = random.Next(1, 100);

            Console.WriteLine("Chao");
            Console.WriteLine("Ban co 7 luot doan so.\n");

            int soluot = 7;

            for (int i = 1; i <= soluot; i++)
            {
                Console.Write($"Lan doan thu {i}: Vui long nhap so: ");

                //nhan gia tri
                string input = Console.ReadLine();

                if (int.TryParse(input, out int guessedNumber))
                {
                    //check so
                    if (guessedNumber == winningNumber)
                    {
                        Console.WriteLine("Chuc mung! Ban da dona dung so!\n");
                        return;
                    }
                    else if (guessedNumber < winningNumber)
                    {
                        Console.WriteLine("So dung lon hon so ban doan.\n");
                    }
                    else
                    {
                        Console.WriteLine("So dung nho hon so ban doan.\n");
                    }
                }
                else
                {
                    Console.WriteLine("Vui long nhap hop le.\n");
                    i--; //neu nhap so ko hop le thi ko tinh so lan nhap
                }
            }

            //neu het luot ko doan trung
            Console.WriteLine($"Rat tiec, ban da het luot doan. Dap an la so: {winningNumber}.\n");
        }
    }
}
