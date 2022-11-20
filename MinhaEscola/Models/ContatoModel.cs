namespace MinhaEscola.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public bool ReceberInf { get; set; }
        public bool Contatado { get; set; }

    }
}
