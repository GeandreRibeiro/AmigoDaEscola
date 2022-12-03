using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MinhaEscola.Dominio.Entidades
{
    public class ELogin
    {
        public ELogin(int id, string email, string senha)
        {
            Id = id;
            Email = email;
            Senha = senha;
        }

        public int Id { get; private set; }
        public string Email { get; private set; } = string.Empty;
        public string Senha { get; private set; } = string.Empty;

    }
}
