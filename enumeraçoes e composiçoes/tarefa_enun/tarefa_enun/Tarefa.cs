using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa_enun
{
    internal class Tarefa
    {
        public string Descricao { get; set; }
        public StatusTarefa Status { get; set; }

        public Tarefa(string descricao, StatusTarefa status)
        {
            Descricao = descricao;
            Status = status;
        }

        public void AtualizarStatus(StatusTarefa novoStatus)
        {
            Status = novoStatus;
        }

        public override string ToString()
        {
            return $"Descriçao: {Descricao}, Status da compra: {Status}";
        }
    }
}
