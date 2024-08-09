using pessoa.entidades;

namespace pessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Endereco endereco = new Endereco("rua queluz", "sao joao de meriti", "rio de janeiro");
            Pessoa pessoa = new Pessoa("igor felipe", 26, endereco);

            pessoa.MostrarDetalhes();
        }
    }
}