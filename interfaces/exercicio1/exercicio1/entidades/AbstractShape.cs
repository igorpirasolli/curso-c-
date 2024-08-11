using exercicio1.entidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1.entidades
{
    abstract class AbstractShape : Ishape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
