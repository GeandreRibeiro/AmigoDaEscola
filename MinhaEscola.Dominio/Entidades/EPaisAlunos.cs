using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaEscola.Dominio.Entidades
{
    public class EPaisAlunos : IDominio
    {
        public EPaisAlunos(int id, int paisId, int alunoId)
        {
            Id = id;
            PaisId = paisId;
            AlunoId = alunoId;
        }

        public int Id { get; private set; }
        public int PaisId { get; private set; }
        public int AlunoId { get; private set; }
    }
}
