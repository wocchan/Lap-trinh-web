using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace null_condition_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = null;
            Console.WriteLine($"{array1 ?.Length.ToString()?? "Array is empty."}");
            array1 = new int[] { 1, 2, 3 };
            dynamic[] array2 = {array1,null};
            var s = array2?[0]?.Length ?? "Array is empty.";
            Console.WriteLine($"{s}");
            s = array2?[1]?.Length ?? "Array is empty.";
            Console.WriteLine($"{s}");
        }
    }
}
