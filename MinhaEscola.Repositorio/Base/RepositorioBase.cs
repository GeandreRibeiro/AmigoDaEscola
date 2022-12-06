using MinhaEscola.Repositorio.Base.Inrerface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MinhaEscola.Repositorio.Base
{
    public abstract class RepositorioBase : IDisposable, IBaseDados
    {
        protected SqlConnection Cnn { get; private set; } = new SqlConnection();

        private readonly string _source = @"DESKTOP-15SRLCA\SQLEXPRESS";
        private  string _dataBase = "AmigoDaEscolaDB";

        public RepositorioBase(string source = "", string dataBase = "")
        {
            if(!string.IsNullOrWhiteSpace(source))
                this._source = source;
            
            if(!string.IsNullOrWhiteSpace(dataBase))
                this._dataBase = dataBase;

            ConectarBaseDados();
        }
        
        public bool ConectarBaseDados()
        {
            try
            {


                string connectionString = $@"Data Source={_source}; Initial Catalog={_dataBase}; Integrated Security=true;
														encrypt=true; trustServerCertificate=true";

                Cnn.ConnectionString = connectionString;
                
                if(Cnn.State== ConnectionState.Closed)
                    Cnn.Open();
                
                return true;
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
            Cnn = null;
        }

        public bool ChekConexao()
        {
            if (Cnn.State == ConnectionState.Open)
                return true;
            else 
                return false;
        }

       
    }
}
