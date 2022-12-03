using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaEscola.Dominio.Entidades
{
    public class EContatos
    {
        public EContatos(
            int id, 
            string email, 
            string telefone, 
            string nome, 
            string sobreNome, 
            string cidade, 
            string estado, 
            string cep, 
            bool receberInf, 
            bool contatado
            )
        {
            Id = id;
            Email = email;
            Telefone = telefone;
            Nome = nome;
            SobreNome = sobreNome;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
            ReceberInf = receberInf;
            Contatado = contatado;
        }

        public int Id { get; private set; }
        public string Email { get; private set; } = string.Empty;
        public string Telefone { get; private set; } = string.Empty;
        public string Nome { get; private set; } = string.Empty;
        public string SobreNome { get; private set; } = string.Empty;
        public string Cidade { get; private set; } = string.Empty;
        public string Estado { get; private set; } = string.Empty;
        public string Cep { get; private set; } = string.Empty;
        public bool ReceberInf { get; private set; }
        public bool Contatado { get; private set; }

    }
}
