using MinhaEscola.Dominio.TiposDeCampos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaEscola.Dominio.Entidades
{
    public class ECidade : IDominio
    {
        public ECidade(Descricao50 descricao, Descricao50 codigoIBGE, int estadoId, EEstado estado)
        {
            Descricao = descricao;
            CodigoIBGE = codigoIBGE;
            EstadoId = estadoId;
            Estado = estado;
        }
        public ECidade()
        {

        }
        public Descricao50 Descricao { get; private set; }
        public Descricao50 CodigoIBGE { get; private set; }
        public int EstadoId { get; private set; }
        public EEstado Estado { get; private set; }

    }
}
