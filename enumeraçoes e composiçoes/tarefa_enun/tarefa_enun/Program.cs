namespace tarefa_enun{
    class Program
    {
        static void Main(string[] args)
        {
            Tarefa tarefa1 = new Tarefa("compra das peças", StatusTarefa.Pendente);
            Console.WriteLine(tarefa1);
            tarefa1.AtualizarStatus(StatusTarefa.EmProgresso);
            Console.WriteLine(tarefa1);
            tarefa1.AtualizarStatus(StatusTarefa.Concluida);
            Console.WriteLine(tarefa1);
        }
    }
}