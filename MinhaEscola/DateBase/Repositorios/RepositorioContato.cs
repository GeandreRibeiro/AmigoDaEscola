using Microsoft.Data.SqlClient;
using MinhaEscola.Models;

namespace MinhaEscola.DateBase.Repositorios
{
    public class RepositorioContato
    {
        public bool IncluirContato(ContatoModel contato)
        {
			try
			{
				string strSQL = "INSERT INTO Contato (" +
                    "Email, " +
                    "Telefone, " +
                    "Nome, " +
                    "SobreNome, " +
                    "Cidade, " +
                    "Estado, " +
                    "Cep, " +
                    "ReceberInf, " +
                    "Contatado" +
                    ")Values(" +
                    "@Email, " +
                    "@Telefone, " +
                    "@Nome, " +
                    "@SobreNome, " +
                    "@Cidade, " +
                    "@Estado, " +
                    "@Cep, " +
                    "@ReceberInf, " +
                    "@Contatado)";

                List<SqlParameter> sp = new List<SqlParameter>();
                sp.Add(new SqlParameter("@Email", contato.Email));
                sp.Add(new SqlParameter("@Telefone", contato.Telefone));
                sp.Add(new SqlParameter("@Nome", contato.Nome));
                sp.Add(new SqlParameter("@SobreNome", contato.SobreNome));
                sp.Add(new SqlParameter("@Cidade", contato.Cidade));
                sp.Add(new SqlParameter("@Estado", contato.Estado));
                sp.Add(new SqlParameter("@Cep", contato.Cep));
                sp.Add(new SqlParameter("@ReceberInf", contato.ReceberInf));
                sp.Add(new SqlParameter("@Contatado", contato.Contatado));

                return DBConection.ExecutCommand(strSQL, sp);

			}
			catch (Exception)
			{

				throw;
			}
        }
    }
}
