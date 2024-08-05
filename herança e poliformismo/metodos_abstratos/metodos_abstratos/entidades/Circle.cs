using System;
using System.Collections.Generic;
using metodos_abstratos.entidades.Enun;



namespace metodos_abstratos.entidades
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle()
        {
        }

        public Circle(double radius, Color color) : base (color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return 3.14 * Math.Pow(Radius, 2);
        }
    }
}
