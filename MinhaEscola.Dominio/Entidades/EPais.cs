using MinhaEscola.Dominio.TiposDeCampos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaEscola.Dominio.Entidades
{
    public class EPais : IDominio
    {
        public EPais(
            int id, 
            int escolaId, 
            Descricao100 nome, 
            Descricao100 sobreNome, 
            Descricao100 endereco, 
            Descricao50 numero, 
            int cidadeId, 
            Descricao50 celular, 
            Descricao50 email, 
            int whatsApp, Descricao50 
            telefoneTrabalho, 
            CPF cPF, 
            string rG, 
            string rGOrgao, 
            string rGEstado, 
            List<EAlunos> alunos)
        {
            Id = id;
            EscolaId = escolaId;
            Nome = nome;
            SobreNome = sobreNome;
            Endereco = endereco;
            Numero = numero;
            CidadeId = cidadeId;
            Celular = celular;
            Email = email;
            WhatsApp = whatsApp;
            TelefoneTrabalho = telefoneTrabalho;
            CPF = cPF;
            RG = rG;
            RGOrgao = rGOrgao;
            RGEstado = rGEstado;
            Alunos = alunos;
        }

        public int Id { get; private set; }
        public int EscolaId { get; private set; }
        public Descricao100 Nome { get; private set; }
        public Descricao100 SobreNome { get; private set; }
        public Descricao100 Endereco { get; private set; }
        public Descricao50 Numero { get; private set; }
        public int CidadeId { get; private set; }
        public Descricao50 Celular { get; private set; }
        public Descricao50 Email { get; private set; }
        public int WhatsApp { get; private set; }
        public Descricao50 TelefoneTrabalho { get; private set; }
        public CPF CPF { get; private set; }
        public string RG { get; private set; }
        public string RGOrgao { get; private set; }
        public string RGEstado { get; private set; }
        public List<EAlunos> Alunos { get; set; }

    }
}
