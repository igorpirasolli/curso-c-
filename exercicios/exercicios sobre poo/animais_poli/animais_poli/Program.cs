using animais_poli.entidades;

namespace animais_poli
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal gato = new Gato("romeu", 2);
            Animal cachorro = new Cachorro("kiara", 3);
            Animal vaca = new Vaca("michele", 5);

            gato.emitirSom();
            cachorro.emitirSom();
            vaca.emitirSom();
        }
    }
}