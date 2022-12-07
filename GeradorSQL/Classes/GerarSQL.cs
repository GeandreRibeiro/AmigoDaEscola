using GeradorSQL.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorSQL.Classes
{
    public class GerarSQL : ISQL
    {
        public string GerarDelete(string tabela, List<ICondicao> condicoes)
        {
            if (string.IsNullOrWhiteSpace(tabela)) 
                return string.Empty;

            if(condicoes.Count == 0) 
                return string.Empty;

            string strSQL = $"DELETE FROM {tabela} WHERE ";

            foreach (var item in condicoes)
            {
                strSQL += $"{item.Campo} {item.Comparador} @{item.Campo} {item.Juncao}";
            }

            return strSQL;
        }

        public string GerarInsert(string tabela, List<ICampos> campos)
        {
            if (string.IsNullOrWhiteSpace(tabela)) 
                return string.Empty;

            if (campos.Count == 0)
                return string.Empty;

            ICampos? ultimoCampo = campos.LastOrDefault();

            string strSQL = $"INSERT INTO {tabela}(";
            foreach (var item in campos)
            {
                if(item == ultimoCampo)
                {
                    strSQL += item.Campo;
                }
                else
                {
                    strSQL += item.Campo + ", ";
                }
            }

            strSQL += ")VALUES(";
            ultimoCampo = campos.LastOrDefault();
            foreach (var item in campos)
            {
                if (item == ultimoCampo)
                {
                    strSQL += "@"+item.Campo;
                }
                else
                {
                    strSQL += item.Campo + ", ";
                }
            }

            strSQL += ")";

            return strSQL;

        }

        public string GerarSelect(string tabela, List<ICampos> campos, List<ICondicao> condicoes)
        {
            if (string.IsNullOrWhiteSpace(tabela)) 
                return string.Empty;

            if (condicoes.Count == 0) 
                return string.Empty;

            if (campos.Count == 0)
                return string.Empty;

            string strSQL = $"SELECT ";
            ICampos? utilmoCampo = campos.LastOrDefault();

            foreach (var item in campos)
            {
                if(utilmoCampo == item)
                {
                    strSQL += item.Campo + " ";
                }
                else
                {
                    strSQL += item.Campo + ", ";
                }
                
            }

            strSQL += "WHERE ";

            foreach (var item in condicoes)
            {
                strSQL += $"{item.Campo} {item.Comparador} @{item.Campo} {item.Juncao}";
            }

            return strSQL;
        }

        public string GerarUpdate(string tabela, List<ICampos> campos, List<ICondicao> codicoes)
        {
            if (string.IsNullOrWhiteSpace(tabela))
                return string.Empty;

            if (campos.Count == 0)
                return string.Empty;

            if (codicoes.Count == 0)
                return string.Empty;

            var ultimoCampo = campos.LastOrDefault();
            
            string strSQL = $"UPDATE {tabela} SET ";
            foreach (var item in campos)
            {
                if(ultimoCampo == item)
                {
                    strSQL += $"{item} = @{item} ";
                }
                else
                {
                    strSQL += $"{item} = @{item}, ";
                }
            }

            strSQL += "WHERE ";

            foreach (var item in codicoes)
            {
                strSQL += $"{item.Campo} {item.Comparador} {item.Valor} {item.Juncao}";
            }

            return strSQL;
        }
    }
}
