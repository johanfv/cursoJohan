using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Abstraction_POO
{
    public class circle : Shape
    {
        private double Radius;

        public circle(double radius)
        {
            Radius = radius;
        }

        public override double Area()
        {
            //Area del circulo = PI * R^2

            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
