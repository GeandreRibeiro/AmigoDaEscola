using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorSQL.Interfaces
{
    public interface ISQL
    {
        string GerarSelect(string tabela, List<string> campos, List<ICodicao> condicoes);
        string GerarInsert(string tabela, List<string> campos);
        string GerarUpdate(string tabela, List<string> campos, List<ICodicao> codicoes);
        string GerarDelete(string tabela, List<ICodicao> codicoes);
    }
}
