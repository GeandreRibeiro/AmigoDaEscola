using MinhaEscola.Dominio.TiposDeCampos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaEscola.Dominio.Entidades
{
    public class EEscola : IDominio
    {
        public EEscola(
            int id, 
            Descricao100? nome, 
            Descricao100? diretor, 
            ECidade? cidade, 
            Descricao50? bairro, 
            Descricao50? rua, 
            Descricao50? numero, 
            Descricao50? cEP, 
            Telefone? telefone, 
            DateTime dataCadastro, 
            DateTime dataVencimento, 
            Descricao50? tipoAssinatura, 
            string xml
            )
        {
            Id = id;
            Nome = nome;
            Diretor = diretor;
            Cidade = cidade;
            Bairro = bairro;
            Rua = rua;
            Numero = numero;
            CEP = cEP;
            Telefone = telefone;
            DataCadastro = dataCadastro;
            DataVencimento = dataVencimento;
            TipoAssinatura = tipoAssinatura;
            Xml = xml;
        }

        public int Id { get; private set; }
        public Descricao100? Nome { get; private set; }
        public Descricao100? Diretor { get; private set; }
        public ECidade? Cidade { get; private set; }
        public Descricao50? Bairro { get; private set; }
        public Descricao50? Rua { get; private set; }
        public Descricao50? Numero { get; private set; }
        public Descricao50? CEP { get; private set; }
        public Telefone? Telefone { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public DateTime DataVencimento { get; private set; }
        public Descricao50? TipoAssinatura { get; private set; }
        public string Xml { get; private set; }
    }
}
