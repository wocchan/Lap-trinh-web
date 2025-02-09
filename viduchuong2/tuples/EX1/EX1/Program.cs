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
            // create tuples
            (string MyString, int MyNumber) MyValues = ("Hello world !", 2050);
            Console.WriteLine($"MyString: {MyValues.MyString}");
            Console.WriteLine($"MyNumber: {MyValues.MyNumber}"); ;
            Console.ReadLine();
        }
    }
}
