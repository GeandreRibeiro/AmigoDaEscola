using MinhaEscola.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MinhaEscola.Dominio.Entidades
{
    public class ELogin : ILogin
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;

        public bool ChekLongin()
        {
            throw new NotImplementedException();
        }
    }
}
