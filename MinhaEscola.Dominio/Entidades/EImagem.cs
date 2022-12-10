using MinhaEscola.Dominio.TiposDeCampos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaEscola.Dominio.Entidades
{
    public class EImagem:IDominio
    {
        public EImagem(
            int id, 
            int alunoId, 
            int paisId, 
            int professorId,
            Descricao50 descricao, 
            BitArray imagem
            )
        {
            Id = id;
            AlunoId = alunoId;
            PaisId = paisId;
            ProfessorId = professorId;
            Descricao = descricao;
            Imagem = imagem;
        }

        public int Id { get; private set; }
        public int AlunoId { get; private set; }
        public int PaisId { get; private set; }
        public int ProfessorId { get; private set; }
        public Descricao50 Descricao { get; private set; }
        public BitArray Imagem { get; private set; }

    }
}
