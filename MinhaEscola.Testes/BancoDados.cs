using MinhaEscola.Dominio.Entidades;
using MinhaEscola.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaEscola.Testes
{
    [TestClass]
    [TestCategory("BancoDeDados")]
    public class BancoDados
    {
        [TestMethod]
        public void Deve_retornar_true_ao_tentar_checar_a_conexao()
        {
            var l = new ELogin(0, "", "");
            var rep = new LoginRepositorio(l);
            Assert.IsTrue(rep.ChekConexao());
        }
    }
}
