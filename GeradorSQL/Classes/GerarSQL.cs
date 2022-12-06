using GeradorSQL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorSQL.Classes
{
    public class GerarSQL : ISQL
    {
        public string GerarDelete(string tabela, List<ICodicao> codicoes)
        {
            if (string.IsNullOrWhiteSpace(tabela)) return string.Empty;
            if(codicoes.Count == 0) return string.Empty;

            string strSQL = $"DELETE FROM {tabela} WHERE ";

            foreach (var item in codicoes)
            {
                strSQL += $"{item.Campo} {item.Comparador} {item.Valor} {item.Juncao}";
            }

            return strSQL;
        }

        public string GerarInsert(string tabela, List<string> campos, List<string> valores)
        {
            if (string.IsNullOrWhiteSpace(tabela)) 
                return string.Empty;

            if(valores.Count == 0) 
                return string.Empty;

            string? ultimoCampo = campos.LastOrDefault();

            string strSQL = $"INSERT INTO {tabela}(";
            foreach (var item in campos)
            {
                if(item == ultimoCampo)
                {
                    strSQL += item;
                }
                else
                {
                    strSQL += item + ", ";
                }

                
            }
            strSQL += ")VALUES(";
            ultimoCampo = valores.LastOrDefault();
            foreach (var item in valores)
            {
                if (item == ultimoCampo)
                {
                    strSQL += item;
                }
                else
                {
                    strSQL += item + ", ";
                }
            }

            strSQL += ")";

            return strSQL;

        }

        public string GerarSelect(string tabela, List<string> campos, List<ICodicao> condicoes)
        {
            string strSQL = $"SELECT ";

            foreach (var item in campos)
            {
                strSQL += item;
            }

            return strSQL;
        }

        public string GerarUpdate(string tabela, List<IValores> valores, List<ICodicao> codicoes)
        {
            throw new NotImplementedException();
        }
    }
}
