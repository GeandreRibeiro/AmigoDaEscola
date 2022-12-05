using MinhaEscola.Dominio;
using MinhaEscola.Dominio.Entidades;
using MinhaEscola.Repositorio.Base;
using MinhaEscola.Repositorio.Base.Inrerface;
using MinhaEscola.Repositorio.Interfaces;
using System.Data.SqlClient;

namespace MinhaEscola.Repositorio
{
    public class ContatoRepositorio : RepositorioBase, IRepositorio
    {
        private readonly EContatos _contato;

        public ContatoRepositorio(IDominio contato, string source, string dataBase) : base(source, dataBase)
        {
            _contato = (EContatos)contato;
        }

        public ContatoRepositorio(IDominio contato) : base()
        {
            _contato = (EContatos)contato;
        }

        public bool Gravar()
        {
            string strSQL = "INSERT INTO Contato (" +
                "Email, " +
                "Telefone, " +
                "Nome, " +
                "SobreNome, " +
                "Cidade, " +
                "Estado, " +
                "Cep, " +
                "ReceberInf, " +
                "Contatado" +
                ")VALUES(" +
                "@Email, " +
                "@Telefone, " +
                "@Nome, " +
                "@SobreNome, " +
                "@Cidade, " +
                "@Estado, " +
                "@Cep, " +
                "@ReceberInf, " +
                "@Contatado" +
                ")";
            
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@Email", _contato.Email));
            parametros.Add(new SqlParameter("@Telefone", _contato.Telefone));
            parametros.Add(new SqlParameter("@Nome", _contato.Nome));
            parametros.Add(new SqlParameter("@SobreNome", _contato.SobreNome));
            parametros.Add(new SqlParameter("@Cidade", _contato.Cidade));
            parametros.Add(new SqlParameter("@Estado", _contato.Estado));
            parametros.Add(new SqlParameter("@Cep", _contato.Cep));
            parametros.Add(new SqlParameter("@ReceberInf", _contato.ReceberInf));
            parametros.Add(new SqlParameter("@Contatado", _contato.Contatado));


            if (base.ExecutarComando(strSQL, parametros) > 0)
                return true;

            return false;

        }

        public IDominio Buscar(int contatoId)
        {
            throw new NotImplementedException();
        }

        public bool Alterar(int contatoId)
        {
            throw new NotImplementedException();
        }

        public bool Excluir(int contatoId)
        {
            throw new NotImplementedException();
        }
    }
}