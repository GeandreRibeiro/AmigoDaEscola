using MinhaEscola.Dominio.Interfaces;
using MinhaEscola.Repositorio.Base;
using System.Data.SqlClient;

namespace MinhaEscola.Repositorio
{
    public class ContatoRepositorio : RepositorioBase, IContato
    {
        public ContatoRepositorio(string source, string dataBase) : base(source, dataBase)
        {

        }

        public ContatoRepositorio() : base()
        {

        }

        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string Nome { get; set; } = string.Empty;
        public string SobreNome { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public string Cep { get; set; } = string.Empty;
        public bool ReceberInf { get; set; }
        public bool Contatado { get; set; }

        public bool GravarContrato(IContato contato)
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
            parametros.Add(new SqlParameter("@Email", contato.Email));
            parametros.Add(new SqlParameter("@Telefone", contato.Telefone));
            parametros.Add(new SqlParameter("@Nome", contato.Nome));
            parametros.Add(new SqlParameter("@SobreNome", contato.SobreNome));
            parametros.Add(new SqlParameter("@Cidade", contato.Cidade));
            parametros.Add(new SqlParameter("@Estado", contato.Estado));
            parametros.Add(new SqlParameter("@Cep", contato.Cep));
            parametros.Add(new SqlParameter("@ReceberInf", contato.ReceberInf));
            parametros.Add(new SqlParameter("@Contatado", contato.Contatado));


            if (base.ExecutarComando(strSQL, parametros) > 0)
                return true;

            return false;

        }
    }
}