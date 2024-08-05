using private_encapsulamento;
using System.Globalization;

namespace private_encapsulamneto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("tv", 500.00, 10);
            
            
            p.setNome("tv do igor");
            Console.WriteLine($"tv é de quem: {p.getNome()} e quanto custou: {p.getPreco():n} e agora quantas tvs eu tenho {p.getQuantidade()}");
        }
    }
}