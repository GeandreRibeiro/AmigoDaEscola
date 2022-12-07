using GeradorSQL.Classes;
using GeradorSQL.Interfaces;
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
        private ISQL _sql;
        private const string _tabela = "Cidades";
        private List<ICampos> _campos = new List<ICampos>();
        public CidadeRepositorio(IDominio cidade, ISQL sql) : base()
        {
            _cidade = (ECidade)cidade;
            _sql = (GerarSQL)sql;
        }

        private void carregarCampos()
        {
            //campos para serem alterados
            _campos.Add(new Campos("Descricao", _cidade.Descricao.ToString()));
            _campos.Add(new Campos("CodigoIBGE", _cidade.CodigoIBGE.ToString()));
            _campos.Add(new Campos("EstadoId", _cidade.EstadoId.ToString()));
        }

        public bool Alterar(int Id)
        {
            try
            {
                carregarCampos();
                //Condições para a alteração
                List<ICondicao> condicoes = new List<ICondicao>();
                condicoes.Add(new Condicao("Id", Id.ToString(), Comparador.Igual));
                
                //Gerando o sql
                string strSQL = _sql.GerarUpdate(_tabela, _campos, condicoes);

                //Criando os Parametros
                List<SqlParameter> par = new List<SqlParameter>();
                foreach (var item in _campos)
                {
                    par.Add(new SqlParameter("@"+item.Campo, item.Valor));
                }

                if (base.ExecutarComando(strSQL, par) == 0)
                    return false;

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IDominio Buscar(int Id)
        {
            try
            {
                ECidade cidade = new();
                carregarCampos();
                List<ICondicao> condicoes = new List<ICondicao>();
                condicoes.Add(new Condicao("Id", Comparador.Igual));

                string strSQL = _sql.GerarSelect(_tabela, _campos, condicoes);
                
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
                List<ICondicao> condicoes = new List<ICondicao>();
                
                condicoes.Add(new Condicao("Id", Comparador.Igual));

                string strSQL = _sql.GerarDelete(_tabela, condicoes);

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
                string strSQL = _sql.GerarInsert(_tabela, _campos);

                List<SqlParameter> list = new List<SqlParameter>();

                foreach (var item in _campos)
                {
                    list.Add(new SqlParameter("@"+item.Campo, item.Valor));
                }

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
    }
}
