using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaEscola.Repositorio.Base.Inrerface
{
    public interface IBaseDados
    {
        bool ConectarBaseDados();
        DataSet ExecutarSelect(string sql, List<SqlParameter> parameters);
        int ExecutarComando(string sql, List<SqlParameter> parameters);
        void Dispose();
        bool ChekConexao();

    }
}
