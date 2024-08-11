using exercicio4.entidades.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4.entidades
{
    internal class Reserva
    {
        public IVeiculo Veiculo { get; set; }
        public int Dias { get; set; }

        public EstadoReserva Estado { get; set; }

        public Reserva( IVeiculo veiculo, int dias, EstadoReserva estado)
        {
            Veiculo = veiculo;
            Dias = dias;
            Estado = estado;
        }

        public double CalcularCusto()
        {
            return Veiculo.CalcularCusto(Dias);
        }

        public void Cancelar()
        {
            if (Estado == EstadoReserva.Ativa)
            {
                
                Console.WriteLine("reserva ativa");
            }
            else
            {
                Console.WriteLine("reserva cancelada");
            }
        }
    }
}
