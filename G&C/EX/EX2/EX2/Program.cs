using System;
using System.Collections.Generic;
using System.Linq;

namespace EX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            List<double> resultSums = SumAllNumbersInOrder(numbers);
            Console.WriteLine(string.Join(" ", resultSums));
        }

        static List<double> SumAllNumbersInOrder(List<double> numbers)
        {
            List<double> sums = new List<double>();
            Queue<double> queue = new Queue<double>(numbers);

            while (queue.Count > 0)
            {
                double sum = queue.Dequeue();
                if (queue.Count > 0) sum += queue.ToList().Last(); // Lay phan tu cuoi cung
                if (queue.Count > 0) queue = new Queue<double>(queue.ToList().Take(queue.Count - 1)); // Loai bo phan tu cuoi cung

                sums.Add(sum);
            }

            return sums;
        }
    }
}