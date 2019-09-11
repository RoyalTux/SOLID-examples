using System;
using OpenClosedPrinciple.Abstract;

namespace OpenClosedPrinciple.Class
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area() => Radius * Radius * Math.PI;
    }
}
