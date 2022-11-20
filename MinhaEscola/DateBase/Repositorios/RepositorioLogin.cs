using Microsoft.Data.SqlClient;

namespace MinhaEscola.DateBase.Repositorios
{
    public class RepositorioLogin
    {
        public bool CheckCredentials(string email, string senha)
        {
			try
			{
				string strSQL = "SELECT Email, Senha from Login WHERE Email = @Email AND Senha = @Senha";
				List<SqlParameter> sp = new List<SqlParameter>();
				
				sp.Add(new SqlParameter("@Email", email));
				sp.Add(new SqlParameter("@Senha", senha));

				return DBConection.ExecutCommandSelect(strSQL, sp);
			}
			catch (Exception)
			{

				throw;
			}
        }
    }
}
