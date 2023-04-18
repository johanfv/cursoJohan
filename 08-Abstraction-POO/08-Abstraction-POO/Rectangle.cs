using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Abstraction_POO
{
    internal class Rectangle : Shape
    {
        private double Width;
        private double Height;

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height; 
        }
        public override double Area()
        {
            return Width * Height;
        }
    }
}
