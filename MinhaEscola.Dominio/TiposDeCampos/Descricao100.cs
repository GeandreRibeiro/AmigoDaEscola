using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaEscola.Dominio.TiposDeCampos
{
    public class Descricao100
    {
        public Descricao100(string descricao)
        {
            this.Descricao = descricao;
            
            if(descricao.Length > 100)
                this.Descricao = descricao.Substring(0, 100);
        }
        
        public string Descricao { get; private set; }


    }
}
