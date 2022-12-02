using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MinhaEscola.Repositorio.Base
{
    public abstract class RepositorioBase : IDisposable
    {
        protected SqlConnection Cnn { get; private set; } = new SqlConnection();
        
        public RepositorioBase(string source = @"DESKTOP-15SRLCA\SQLEXPRESS", string dataBase = "AmigoDaEscolaDB")
        {
            try
            {
                
                
                string connectionString = $@"Data Source={source}; Initial Catalog={dataBase}; Integrated Security=true;
														encrypt=true; trustServerCertificate=true";

                Cnn.ConnectionString = connectionString;
                Cnn.Open();

            }
            catch (Exception)
            {

                throw;
            }
            
        }
        
        public DataSet ExecutarSelect(string sql, List<SqlParameter> parameters) 
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, this.Cnn);
                cmd.Parameters.AddRange(parameters.ToArray());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int ExecutarComando(string sql, List<SqlParameter> parameters) 
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, this.Cnn);
                cmd.Parameters.AddRange(parameters.ToArray());
                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Dispose()
        {
            Cnn.Close();
        }
    }
}
