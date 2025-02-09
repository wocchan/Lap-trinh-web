using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    internal class Program
    {
        static void PrintFullName(string first, string? middle, string last)
        {
            Console.WriteLine(middle?.Length);
            Console.WriteLine(first + middle + last);
        }
        static void Main(string[] args)
        {
            string firstName = "Mike";
            string? middleName = " ";
            string lastName = "John";
            PrintFullName(firstName, middleName, lastName);
            Console.ReadLine();
        }
    }
}
