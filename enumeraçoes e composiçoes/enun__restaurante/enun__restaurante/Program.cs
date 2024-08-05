namespace enun__restaurante
{
    class Program
    {
        static void Main(string[] args)
        {
            Prato prato1 = new Prato("pao", TipoPrato.Entrada, 15.00);
            Prato prato2 = new Prato("strogonoff", TipoPrato.PratoPrincipal, 25.00);
            Prato prato3 = new Prato("pudim", TipoPrato.Sobremesa, 10.00);

            Prato[] pratos = { prato1, prato2, prato3 };

            foreach (var prato in pratos)
            {
                Console.WriteLine(prato);
            }



        }
    }
}