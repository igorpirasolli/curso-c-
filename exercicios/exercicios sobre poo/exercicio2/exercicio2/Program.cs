using exercicio2.entidades;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca("biblioteca central", "rua das flores, 123");

            Midia livro = new Livro("Dom quixote", 1605, "miguel de cerventes", 1072);
            Midia filme = new Filme("o senhor dos aneis", 2001, "peter jackson", 178);
            Midia musica = new Musica("bohemia rhapsody", 1975, "queen", 354);

            biblioteca.AdicionarMidia(livro);
            biblioteca.AdicionarMidia(filme);
            biblioteca.AdicionarMidia(musica);

            biblioteca.MostrarMidias();
        }
    }
}