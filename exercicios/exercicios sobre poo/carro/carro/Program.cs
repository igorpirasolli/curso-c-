using carro.entidades;

namespace carro
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro("honda", "civic", 2020);
            
            carro.mostrarDetalhes();
            carro.ligar();
            carro.desligar();
        }
    }
}