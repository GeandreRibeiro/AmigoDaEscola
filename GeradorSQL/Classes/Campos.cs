using GeradorSQL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorSQL.Classes
{
    public class Campos : ICampos
    {
        public Campos(string campo, string valor = "")
        {
            Campo = campo;
            Valor = valor;
        }

        public string Campo { get; set; }
        public string Valor { get; set; }
    }
}
