using MinhaEscola.Dominio.TiposDeCampos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaEscola.Dominio.Entidades
{
    public class EProfessores : IDominio
    {
        public EProfessores(
            int id, 
            int escolaId, 
            Descricao50 nome, 
            Descricao50 telefone, 
            int cidadeId, 
            ECidade cidade, 
            Descricao50 bairro, 
            Descricao50 rua, 
            Descricao50 numero, 
            CPF cpf, 
            string observacao, 
            DateTime dataCadastro, 
            bool ativo
            )
        {
            Id = id;
            EscolaId = escolaId;
            Nome = nome;
            Telefone = telefone;
            CidadeId = cidadeId;
            Cidade = cidade;
            Bairro = bairro;
            Rua = rua;
            Numero = numero;
            Cpf = cpf;
            Observacao = observacao;
            DataCadastro = dataCadastro;
            Ativo = ativo;
        }

        public int Id { get; private set; }
        public int EscolaId { get; private set; }
        public Descricao50 Nome { get; private set; }
        public Descricao50 Telefone { get; private set; }
        public int CidadeId { get; private set; }
        public ECidade Cidade { get; private set; }
        public Descricao50 Bairro { get; private set; }
        public Descricao50 Rua { get; private set; }
        public Descricao50 Numero { get; private set; }
        public CPF Cpf { get; private set; }
        public string Observacao { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public bool Ativo { get; private set; }

    }
}
