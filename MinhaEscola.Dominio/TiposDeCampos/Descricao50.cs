using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaEscola.Dominio.TiposDeCampos
{
    public class Descricao50
    {
        public Descricao50(string descricao)
        {
            this.Descricao = descricao;

            if(descricao.Length > 50)
            {
                this.Descricao = descricao.Substring(0,50);
            }
        }

        public string Descricao { get; private set; }

        public override string ToString()
        {
            return this.Descricao; 
        }
    }
}
