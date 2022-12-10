using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MinhaEscola.Dominio.TiposDeCampos
{
    public class CPF
    {
        public CPF(string numero)
        {
            if (numero.Length != 11)
            {
                Valido = false;
                this.Numero = "";
            }
            else
            {
                CPFCNPJ.Main doc = new CPFCNPJ.Main();
                if (doc.IsValidCPFCNPJ(this.Numero))
                {
                    Valido = true;
                    this.Numero = numero;
                }
                else
                {
                    Valido = false;
                    this.Numero = "";
                }
            }
        }

        public bool Valido { get; set; }
        public string Numero { get; set; }

        public override string ToString()
        {
            return Numero; 
        }
    }
}
