using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal
{
    internal class Cachorro : Animal
    {
        public Cachorro(string nome, int idade) : base(nome, idade)
        {
        }

        public override void emitirSom()
        {
            Console.WriteLine($"o cachorro do nome {Nome}, idade {Idade} faz auau");
        }
    }
}
