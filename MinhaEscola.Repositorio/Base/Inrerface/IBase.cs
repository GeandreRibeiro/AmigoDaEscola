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
        bool Buscar(int contatoId);
        bool Alterar(int contatoId);
        bool Excluir(int contatoId);
    }
}
