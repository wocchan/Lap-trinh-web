using System;
using System.Collections.Generic;
using System.Linq;

namespace EX1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap danh sach so thap phan:");
            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            numbers = SumAdjacentEqualNumbers(numbers);

            Console.WriteLine("Xuat:");
            Console.WriteLine(string.Join(" ", numbers));
        }

        static List<double> SumAdjacentEqualNumbers(List<double> numbers)
        {
            Queue<double> queue = new Queue<double>(numbers);
            List<double> result = new List<double>();

            while (queue.Count > 0)
            {
                if (result.Count > 0 && result.Last() == queue.Peek())
                {
                    result[result.Count - 1] += queue.Dequeue();
                }
                else
                {
                    result.Add(queue.Dequeue());
                }
            }

            return (result.SequenceEqual(numbers)) ? result : SumAdjacentEqualNumbers(result);
        }
    }
}
