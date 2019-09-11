using OpenClosedPrinciple.Abstract;

namespace OpenClosedPrinciple.Class
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }

        public double Height { get; set; }

        public override double Area() => Width * Height;
    }
}
