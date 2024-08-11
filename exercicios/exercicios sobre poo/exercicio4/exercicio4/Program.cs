using exercicio4.entidades;
using exercicio4.entidades.Enums;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            IVeiculo carro = new Carro("fusca", 50.00);
            IVeiculo moto = new Moto("CB500", 30.00);

            Reserva reservaCarro = new Reserva(carro, 5, EstadoReserva.Ativa);
            Reserva reservaMoto = new Reserva(moto, 3, EstadoReserva.Cancelar);

            Console.WriteLine(carro.ObterDetalhes());
            Console.WriteLine($"custo da reserva do carro: {reservaCarro.CalcularCusto():c}");
            reservaCarro.Cancelar();  
            
            Console.WriteLine(moto.ObterDetalhes());
            Console.WriteLine($"custo da reserva do carro: {reservaMoto.CalcularCusto():c}");
            reservaMoto.Cancelar();

        }
    }
}