using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animais_poli.entidades
{
    internal class Cachorro : Animal
    {
        public Cachorro(string nome, int idade) : base(nome, idade)
        {
        }

        public override void emitirSom()
        {
            Console.WriteLine($"nome do cachorro: {Nome}, idade {Idade}, som: miau");
            ;
        }
    }
}
