using MinhaEscola.Dominio.TiposDeCampos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaEscola.Dominio.Entidades
{
    public class EEstado : IDominio
    {

        public EEstado(int id, Descricao50 descricao, UFEstado sigla, Descricao50 codigoIbge)
        {
            this.Id = id;
            this.Descricao = descricao;
            this.Sigla = sigla;
            this.CodigoIBGE= codigoIbge;
        }

        public int Id { get; private set; }
        public Descricao50 Descricao { get; private set; }
        public UFEstado Sigla { get; private set; }
        public Descricao50 CodigoIBGE { get; private set; }

    }
}
