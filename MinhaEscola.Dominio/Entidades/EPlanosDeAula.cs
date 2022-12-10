using MinhaEscola.Dominio.TiposDeCampos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaEscola.Dominio.Entidades
{
    public class EPlanosDeAula : IDominio
    {
        public EPlanosDeAula(
            int id, 
            int escolaId,
            DateTime data, 
            string objetivoGeral, 
            string publicoAlvo, 
            string conteudo, 
            string procedimentos, 
            string recursos, 
            string avaliacao, 
            Descricao50 palavraChave, 
            string observacao
            )
        {
            Id = id;
            EscolaId = escolaId;
            Data = data;
            ObjetivoGeral = objetivoGeral;
            PublicoAlvo = publicoAlvo;
            Conteudo = conteudo;
            Procedimentos = procedimentos;
            Recursos = recursos;
            Avaliacao = avaliacao;
            PalavraChave = palavraChave;
            Observacao = observacao;
        }

        public int Id { get; private set; }
        public int EscolaId { get; private set; }
        public DateTime Data { get; private set; }
        public string ObjetivoGeral { get; private set; }
        public string PublicoAlvo { get; private set; }
        public string Conteudo { get; private set; }
        public string Procedimentos { get; private set; }
        public string Recursos { get; private set; }
        public string Avaliacao { get; private set; }
        public Descricao50 PalavraChave { get; private set; }
        public string Observacao { get; private set; }
    }
}
