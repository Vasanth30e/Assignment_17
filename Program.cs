using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            circle.PrintInfo();

            Rectangle rectangle = new Rectangle(3, 7);
            rectangle.PrintInfo();

            Triangle triangle = new Triangle(2, 2, 2);
            triangle.PrintInfo();

            Console.ReadKey();
        }
    }
}
