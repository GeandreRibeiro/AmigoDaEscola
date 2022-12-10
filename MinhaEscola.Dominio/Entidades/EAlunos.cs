using MinhaEscola.Dominio.TiposDeCampos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaEscola.Dominio.Entidades
{
    public class EAlunos : IDominio
    {
        public EAlunos(
            int id, 
            int escolaId, 
            EEscola escola, 
            Descricao100 nome, 
            Descricao100 sobreNome, 
            CPF cpf, 
            string rg, 
            string rgOrgao, 
            string rgEstado, 
            int cidadeId, 
            ECidade cidade, 
            Descricao100 endereco, 
            Descricao50 numero, 
            Descricao100 bairro, 
            Descricao50 celular, 
            Descricao50 whatsApp, 
            Descricao100 email, 
            int paisId, 
            EPais pais
            )
        {
            Id = id;
            EscolaId = escolaId;
            Escola = escola;
            Nome = nome;
            SobreNome = sobreNome;
            Cpf = cpf;
            Rg = rg;
            RgOrgao = rgOrgao;
            RgEstado = rgEstado;
            CidadeId = cidadeId;
            Cidade = cidade;
            Endereco = endereco;
            Numero = numero;
            Bairro = bairro;
            Celular = celular;
            WhatsApp = whatsApp;
            Email = email;
            PaisId = paisId;
            Pais = pais;
        }

        public int Id { get; private set; }
        public int EscolaId { get; private set; }
        public EEscola Escola { get; set; }
        public Descricao100 Nome { get; private set; }
        public Descricao100 SobreNome { get; private set; }
        public CPF Cpf { get; private set; }
        public string Rg { get; private set; }
        public string RgOrgao { get; private set; }
        public string RgEstado { get; private set; }
        public int CidadeId { get; private set; }
        public ECidade Cidade { get; set; }
        public Descricao100 Endereco { get; private set; }
        public Descricao50 Numero { get; private set; }
        public Descricao100 Bairro { get; private set; }
        public Descricao50 Celular { get; private set; }
        public Descricao50 WhatsApp { get; private set; }
        public Descricao100 Email { get; private set; }
        public int PaisId { get; private set; }
        public EPais Pais { get; set; }
    }
}
