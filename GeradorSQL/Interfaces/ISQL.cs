using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorSQL.Interfaces
{
    public interface ISQL
    {
        string GerarSelect(string tabela, List<ICampos> campos, List<ICondicao> condicoes);
        string GerarInsert(string tabela, List<ICampos> campos);
        string GerarUpdate(string tabela, List<ICampos> campos, List<ICondicao> codicoes);
        string GerarDelete(string tabela, List<ICondicao> codicoes);
    }
}
