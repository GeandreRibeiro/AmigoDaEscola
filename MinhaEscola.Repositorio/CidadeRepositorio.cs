using MinhaEscola.Dominio;
using MinhaEscola.Dominio.Entidades;
using MinhaEscola.Dominio.TiposDeCampos;
using MinhaEscola.Repositorio.Base;
using MinhaEscola.Repositorio.Base.Inrerface;
using MinhaEscola.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MinhaEscola.Repositorio
{
    public class CidadeRepositorio :RepositorioBase, IRepositorio
    {
        private readonly ECidade _cidade;

        public CidadeRepositorio(IDominio cidade) : base()
        {
            _cidade = (ECidade)cidade;
        }

        public bool Alterar(int contatoId)
        {
            throw new NotImplementedException();
        }

        public IDominio Buscar(int Id)
        {
            try
            {
                ECidade cidade = new();
                
                string strSQL = "SELECT Id, Descricao, CodigoIBGE,  EstadoId FROM Cidades " + 
                    "WHERE Id = @Id";
                
                List<SqlParameter> sp = new List<SqlParameter>();
                sp.Add(new SqlParameter("@Id", Id));

                if(base.ChekConexao())
                {
                    var ds =  base.ExecutarSelect(strSQL, sp);

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        Descricao50 nome = new Descricao50(row["Descricao"].ToString());
                        Descricao50 IBGE = new Descricao50(row["CodigoIBGE"].ToString());
                        cidade = new ECidade(nome, IBGE, (int)row["EstadoId"], new EEstado(0, new Descricao50("MatoGrosso do Sul"), new UFEstado("MS"), IBGE));

                    }
                }
                    
                return cidade;


            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Excluir(int Id)
        {
            try
            {
                string strSQL = "DELETE FROM Cidades WHERE Id = @Id";
                List<SqlParameter> list = new List<SqlParameter>();
                list.Add(new SqlParameter("@Id", Id));

                if (base.ChekConexao())
                    if (base.ExecutarComando(strSQL, list) == 0)
                        return false;

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Gravar()
        {
            try
            {
                string strSQL = "INSER INTO Cidades (Descricao, CodigoIBGE, EstadoId)VALUES(" +
                    "@Descricao, @CodigoIBGE, @EstadoId)";

                List<SqlParameter> list = new List<SqlParameter>();
                list.Add(new SqlParameter("@Descricao", _cidade.Descricao));
                list.Add(new SqlParameter("@CodigoIBGE", _cidade.CodigoIBGE));
                list.Add(new SqlParameter("@EstadoId", _cidade.EstadoId));

                if (base.ChekConexao())
                    if (ExecutarComando(strSQL, list) == 0)
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
