using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorSQL.Interfaces
{
    public interface IValores
    {
        string Campo { get; set; }
        string Valor { get; set; }
    }
}
