using MinhaEscola.Dominio.Entidades;
using MinhaEscola.Repositorio.Base;
using MinhaEscola.Repositorio.Interfaces;
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
        private readonly ELogin _login; 
        public LoginRepositorio(ELogin contato, string source, string dataBase) : base(source, dataBase)
        {
            _login = contato;
        }

        public LoginRepositorio(ELogin contato) : base()
        {
            _login = contato;
        }


        public bool ChekLongin()
        {
            string strSQL = "SELECT Email, Senha FROM Login WHERE Email = @email AND Senha = @senha";
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@email", _login.Email));
            parametros.Add(new SqlParameter("@senha", _login.Senha));
            
            var ds = base.ExecutarSelect(strSQL, parametros);

            if (ds.Tables[0].Rows.Count > 0)
                return true;
            else 
                return false;
            
        }

    }
}
