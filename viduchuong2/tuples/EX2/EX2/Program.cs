using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    internal class Program
    {
        static (int sum, int count) MyMethod(int[] values)
        {
            // declare a tuple
            var r = (sum: 0, count: 0);
            for (int i = 0; i < values.Length; i++)
            {
                if (IsEvenNumber(values[i]))
                {
                    r.sum += values[i];
                    r.count++;
                }
            }
            return r;
            bool IsEvenNumber(int n)
            {
                return n % 2 == 0;
            }
        }
        static void Main(string[] args)
        {
            int[] numbers = {2, 1, 5, 6, 3, 4, 7, 8, 10, 9};
            var (sum, count) = MyMethod(numbers);
            Console.WriteLine($"Sum: {sum}, Count: {count}");
            Console.ReadLine();
        }
    }
}
