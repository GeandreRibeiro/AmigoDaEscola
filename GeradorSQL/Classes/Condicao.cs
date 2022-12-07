using GeradorSQL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorSQL.Classes
{
    public class Condicao : ICondicao
    {
        public Condicao(string campo, Comparador comparador, Jucao juncao = Jucao.Nemhum)
        {
            Campo = campo;
            
            //Comparadores
            if(comparador == Classes.Comparador.Igual)
                Comparador = "=";
            else if(comparador == Classes.Comparador.Diferente) 
                Comparador = "<>";
            else if(comparador == Classes.Comparador.Maior)
                Comparador= ">";
            else if (comparador == Classes.Comparador.Menor)
                Comparador = "<";

            //junções
            if(juncao == Jucao.AND)
                Juncao = "AND";
            else if (juncao == Jucao.OR)
                Juncao = "OR";
            else if (juncao == Jucao.Nemhum)
                Juncao = "";

        }

        public string Campo { get; set; }
        public string Juncao { get; set; }
        public string Comparador { get; set; }
    }

    public enum Jucao
    {
        AND = 1,
        OR = 2,
        Nemhum = 3
    }
    public enum Comparador
    {
        Igual = 1,
        Maior = 2,
        Menor = 3,
        Diferente = 4,
    }
}
