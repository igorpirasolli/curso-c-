using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4.entidades
{
    internal class Moto : IVeiculo
    {
        public string Modelo { get; set; }
        public double PrecoPorDia { get; set; }

        public Moto(string modelo, double precoPorDia)
        {
            Modelo = modelo;
            PrecoPorDia = precoPorDia;
        }

        public double CalcularCusto(int dias)
        {
            return PrecoPorDia * dias;
        }

        public string ObterDetalhes()
        {
            return $" carro: {Modelo}, Preço por dia: {PrecoPorDia:c}";

        }
    }
}
