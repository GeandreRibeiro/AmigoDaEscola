using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaEscola.Dominio.TiposDeCampos
{
    public class Telefone
    {
        public Telefone(string telefone)
        {
            Descricao = telefone;
            if(telefone.Length > 13)
            {
                this.Descricao = telefone.Substring(0, 13);
            }
        }

        public string Descricao { get; private set; }

        public override string ToString()
        {
            return Descricao;
        }

    }
}
