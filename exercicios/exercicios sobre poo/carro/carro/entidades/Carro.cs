using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carro.entidades
{
    internal class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }

        public Carro() { }

        public Carro(string marca, string modelo, int ano)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
        }

        public void ligar()
        {
            Console.WriteLine($"o carro do modelo {Modelo}, marca: {Marca} e ano  {Ano} esta ligando");
        }

        public void desligar()
        {
            Console.WriteLine($"o carro do modelo {Modelo}, marca: {Marca} e ano  {Ano} esta desligando");

        }

        public void mostrarDetalhes()
        {
            Console.WriteLine($"marca: {Marca}\nmodelo: {Modelo}\nano: {Ano}");
        }
    }
}
