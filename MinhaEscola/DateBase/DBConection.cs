using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;
namespace MinhaEscola.DateBase
{
    public static class DBConection
    {
		/// <summary>
		/// Get Connection Data Base
		/// </summary>
		/// <param name="source">Source of Data Base</param>
		/// <param name="dataBase">Name of data base</param>
		/// <returns></returns>
        public static SqlConnection GetConnetction(string source = @"DESKTOP-15SRLCA\SQLEXPRESS", string dataBase = "AmigoDaEscolaDB")
        {
			try
			{
				
				//string path = @"D:\\Program Files\\Microsoft SQL Server\\MSSQL15.SQLEXPRESS\\MSSQL\\DATA";
				SqlConnection cnn = new SqlConnection($@"Data Source={source}; Initial Catalog={dataBase}; Integrated Security=true;
														encrypt=true; trustServerCertificate=true");//; AttachDBFilename={path}\AmigoDaEscolaDB.mdf");Database={dataBase}; 
                
				cnn.Open();
				return cnn;
			}
			catch (Exception)
			{

				throw;
			}
        }
        /// <summary>
        /// Execut comand for sql script 
        /// </summary>
        /// <param name="strSQL">Secript sql for execut</param>
        /// <param name="parameters">Parameter for sql</param>
        /// <returns>Returns true or false if something goes wrong</returns>
        public static bool ExecutCommand(string strSQL, List<SqlParameter> parameters)
		{
			try
			{
				SqlCommand cmd = new SqlCommand(strSQL, GetConnetction());
				cmd.Parameters.AddRange(parameters.ToArray());
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataSet ds = new DataSet();

				da.Fill(ds);

				if (ds.Tables[0].Rows.Count == 0)
					return false;
				
				return true;
			}
			catch (Exception)
			{

				throw;
			}
		}
    }
}
