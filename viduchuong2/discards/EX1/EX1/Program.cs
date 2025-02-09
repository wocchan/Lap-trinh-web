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
            string[] stringArray = { "12", "Hello", "3.14", "20" };
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (int.TryParse(stringArray[i], out _))
                    Console.WriteLine($"{stringArray[i]}: valid");
                else
                    Console.WriteLine($"{stringArray[i]}: invalid");
            }
            Console.ReadLine();
        }
    }
}
