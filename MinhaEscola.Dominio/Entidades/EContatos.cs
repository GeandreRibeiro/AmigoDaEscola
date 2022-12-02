using MinhaEscola.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaEscola.Dominio.Entidades
{
    public class EContatos : IContato
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public string SobreNome { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public string Cep { get; set; } = string.Empty;
        public bool ReceberInf { get; set; }
        public bool Contatado { get; set; }

        public bool GravarContrato(IContato contato)
        {
            throw new NotImplementedException();
        }
    }
}
