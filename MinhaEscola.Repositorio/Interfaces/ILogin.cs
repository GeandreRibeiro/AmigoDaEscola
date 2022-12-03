using MinhaEscola.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaEscola.Repositorio.Interfaces
{
    public interface ILogin : IRepositorio
    {
        bool ChekLongin();
        
    }
}
