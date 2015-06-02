using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAreaAndPerimeterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Radius Of Circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n\nThe Area of Circle : " + CircleArea(radius));
            Console.WriteLine("\n\nThe Perimeter of Circle : " + CirclePerimeter(radius));
            Console.ReadKey();
        }

        static double CircleArea(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }

        static double CirclePerimeter(double radius)
        {
            double perimeter = 2 * Math.PI * radius;
            return perimeter;
        }
    }
}
