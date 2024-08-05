using System;
using System.Collections.Generic;
using metodos_abstratos.entidades.Enun;

namespace metodos_abstratos.entidades
{
    abstract class Shape
    {
        public Color Color { get; set; }

        protected Shape()
        {
        }

        protected Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
        
    }
}
