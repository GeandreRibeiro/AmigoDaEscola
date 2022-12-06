using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorSQL.Interfaces
{
    public interface ICodicao
    {
        string Campo { get; set; }
        string Valor { get; set; }
        string Juncao { get; set; }
        string Comparador { get; set; }
    }
}
