using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    internal class Program
    {
        static (string first, string middle, string last) SplitNames(string fullname)
        {
            string[] strArray = fullname.Split(' ');
            return (strArray[0], strArray[1], strArray[2]);
        }
        static void Main(string[] args)
        {
            var (first, _, last) = SplitNames("Philip F Japikse");
            Console.WriteLine($"{first}:{last}");
            Console.ReadLine();
        }
    }
}
