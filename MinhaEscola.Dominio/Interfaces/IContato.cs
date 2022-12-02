using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaEscola.Dominio.Interfaces
{
    public interface IContato
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public bool ReceberInf { get; set; }
        public bool Contatado { get; set; }

        public bool GravarContrato(IContato contato);
    }
}
