using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaEscola.Dominio.Entidades
{
    public class EContas : IDominio
    {
        public EContas(
            int id, 
            int escolaId, 
            string contaTipo, 
            DateTime dataLancamento, 
            DateTime dataVencimento, 
            decimal valor, 
            int alunoId, 
            int professorId, 
            int paisId, 
            string observacao, 
            DateTime dataBaixa, 
            decimal valorRecebido
            )
        {
            Id = id;
            EscolaId = escolaId;
            ContaTipo = contaTipo;
            DataLancamento = dataLancamento;
            DataVencimento = dataVencimento;
            Valor = valor;
            AlunoId = alunoId;
            ProfessorId = professorId;
            PaisId = paisId;
            Observacao = observacao;
            DataBaixa = dataBaixa;
            ValorRecebido = valorRecebido;
        }

        public int Id { get; private set; }
        public int EscolaId { get; private set; }
        public string ContaTipo { get; private set; }
        public DateTime DataLancamento { get; private set; }
        public DateTime DataVencimento { get; private set; }
        public decimal Valor { get; private set; }
        public int AlunoId { get; private set; }
        public int ProfessorId { get; private set; }
        public int PaisId { get; private set; }
        public string Observacao { get; private set; }
        public DateTime DataBaixa { get; private set; }
        public decimal ValorRecebido { get; private set; }
    }
}
