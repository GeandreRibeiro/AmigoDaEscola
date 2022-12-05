using MinhaEscola.Dominio;
using MinhaEscola.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaEscola.Repositorio.Base.Inrerface
{
    public interface IBase
    {
        bool Gravar();
        IDominio Buscar(int Id);
        bool Alterar(int Id);
        bool Excluir(int Id);
    }
}
