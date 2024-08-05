using System;
using System.Collections.Generic;
using metodos_abstratos.entidades.Enun;


namespace metodos_abstratos.entidades
{
    internal class Rectangulo : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangulo()
        {
        }

        public Rectangulo(double width, double height, Color color) : base (color)
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
