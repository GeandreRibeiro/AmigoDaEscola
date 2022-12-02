using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaEscola.Dominio.Interfaces
{
    public interface ILogin
    {
        int Id { get; set; }
        string Email { get; set; }
        string Senha { get; set; }

        public bool ChekLongin();
        
    }
}
