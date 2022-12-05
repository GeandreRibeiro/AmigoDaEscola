using MinhaEscola.Dominio;
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
    public class LoginRepositorio : RepositorioBase, IRepositorio
    {
        private readonly ELogin _login; 
        public LoginRepositorio(IDominio contato, string source, string dataBase) : base(source, dataBase)
        {
            _login = (ELogin)contato;
        }

        public LoginRepositorio(IDominio contato) : base()
        {
            _login = (ELogin)contato;
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

        public bool Gravar()
        {
            throw new NotImplementedException();
        }

        public IDominio Buscar(int contatoId)
        {
            throw new NotImplementedException();
        }

        public bool Alterar(int contatoId)
        {
            throw new NotImplementedException();
        }

        public bool Excluir(int contatoId)
        {
            throw new NotImplementedException();
        }
    }
}
