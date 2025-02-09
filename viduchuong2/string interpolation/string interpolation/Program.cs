using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salary = 200.234;
            string name = "Soren";
            // using curly-braket syntax
            string str1 = string.Format("Name{0,6}, Salary{1,7:N2}", name, salary);
            Console.WriteLine(str1);
            // using string interpolation
            string str2 = $"Name{name,7}, Salary{salary,8:N2}";
            Console.WriteLine(str2);
            Console.ReadLine();
        }
    }
}
