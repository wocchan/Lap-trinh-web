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
            int i = 123;
            // boxing copies the value of i into object o
            object o = i;
            // change the value of i
            i = 456;
            // the change in i doesn't addect the value stored in o
            Console.WriteLine("The value-type value = {0}", i);
            Console.WriteLine("the object-type value = {0}", o);
            Console.ReadLine();
        }
    }
}
