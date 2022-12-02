using MinhaEscola.Dominio.Interfaces;
using MinhaEscola.Repositorio.Base;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaEscola.Repositorio
{
    public class LoginRepositorio : RepositorioBase, ILogin
    {
        public LoginRepositorio(ILogin contato, string source, string dataBase) : base(source, dataBase)
        {
            this.Email = contato.Email;
            this.Senha = contato.Senha;
        }

        public LoginRepositorio(ILogin contato) : base()
        {
            this.Email = contato.Email;
            this.Senha = contato.Senha;
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public bool ChekLongin()
        {
            string strSQL = "SELECT Email, Senha FROM Login WHERE Email = @email AND Senha = @senha";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@email", this.Email));
            parametros.Add(new SqlParameter("@senha", this.Senha));
            
            var ds = base.ExecutarSelect(strSQL, parametros);

            if (ds.Tables[0].Rows.Count > 0) return true;
            else return false;
            
        }

        
    }
}
