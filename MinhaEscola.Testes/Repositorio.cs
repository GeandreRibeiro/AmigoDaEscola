using MinhaEscola.Dominio.Entidades;
using MinhaEscola.Repositorio;

namespace MinhaEscola.Testes
{
    [TestClass]
    [TestCategory("Repositorio")]
    public class Repositorio
    {
        [TestMethod]
        public void Deve_retornar_false_ao_tentar_efetuar_login()
        {
            var login = new ELogin(0, "naoExiste@hotmail.com", "123");
            Assert.IsFalse(new LoginRepositorio(login).ChekLongin());
        }

        [TestMethod]
        public void Deve_retornar_true_ao_tentar_efetuar_login()
        {
            var login = new ELogin(0, "geandre-ribeiro@hotmail.com", "ge830203");
            Assert.IsTrue(new LoginRepositorio(login).ChekLongin());
        }

        [TestMethod]
        public void Deve_retornar_true_ao_tentar_cadastrar_um_contato()
        {
            var contato = new EContatos(
                0,
                "lourdes@gmail.com",
                "67981179438",
                "Lourdes",
                "Franco Ribeiro",
                "Cassilândia",
                "MS",
                "79540000",
                true,
                false
                );
            Assert.IsTrue(new ContatoRepositorio(contato).Gravar());
            
        }
    }
}