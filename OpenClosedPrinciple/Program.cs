using System;
using OpenClosedPrinciple.Class;

namespace OpenClosedPrinciple
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("---Open Close Principle---\n");

            Console.Write("Enter the radius of a circle: ");
            var radius = Convert.ToInt32(Console.ReadLine());

            var circle = new Circle
            {
                Radius = radius,
            };

            Console.Write("Enter the width of the rectangle: ");
            var recWidth = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the height of the rectangle: ");
            var recHeight = Convert.ToInt32(Console.ReadLine());

            var rectangle = new Rectangle
            {
                Width = recWidth,
                Height = recHeight,
            };

            Console.Write("Enter the width of the triangle; ");
            var triWidth = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the height of the triangle: ");
            var triHeight = Convert.ToInt32(Console.ReadLine());

            var triangle = new Triangle
            {
                Width = triWidth,
                Height = triHeight,
            };

            var areaCalc = new AreaCalc();

            Console.WriteLine("\n---Results---\n");
            Console.WriteLine($"Circle area: {areaCalc.Area(circle)}");
            Console.WriteLine($"Rectangle area: {areaCalc.Area(rectangle)}");
            Console.WriteLine($"Triangle area: {areaCalc.Area(triangle)}");
        }
    }
}
