using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaEscola.Dominio.TiposDeCampos
{
    public class UFEstado
    {
        public UFEstado(string uF)
        {
            if (uF.Length > 2)
                UF = uF.Substring(2);
            else
                this.UF = uF;
        }

        public string UF { get; private set; }

        public override string ToString()
        {
            return this.UF; 
        }
    }
}
