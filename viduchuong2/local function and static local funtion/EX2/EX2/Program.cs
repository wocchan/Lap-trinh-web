using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // areofCircle is the local function of the main function
            void AreaOfCircle (double a)
            {
                double ar;
                Console.WriteLine("Radius of the circle: " + a);
                ar = 3.14 * a * a;
                Console.WriteLine("Area of circle: " + ar);
                // calling static local function
                Circumference(a);
                // circumference is the Static local function
                void Circumference(double radii)
                {
                    double cr;
                    cr = 2* 3.14 * radii;
                    Console.WriteLine($"Circumference of the circle is:{cr:N2}");
                }
            } // end AreaOfCircle
            // calling function
            AreaOfCircle(10);
            Console.ReadLine();
        } //end Main
    }
}
