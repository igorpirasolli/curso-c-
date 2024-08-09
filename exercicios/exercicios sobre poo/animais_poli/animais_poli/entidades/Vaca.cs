using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animais_poli.entidades
{
    internal class Vaca : Animal
    {
        public Vaca(string nome, int idade) : base(nome, idade)
        {
        }

        public override void emitirSom()
        {
            Console.WriteLine($"nome do vaca: {Nome}, idade {Idade}, som: miau");
            ;
        }
    }
}
