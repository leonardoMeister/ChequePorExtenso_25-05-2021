using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChequePorExtenso.Dominio;

using System;

namespace TesteChequePorExtenso
{
    [TestClass]
    public class TesteConversaoGrupoTres
    {
        [TestMethod]
        public void DeveRetornarPorExtensoEmGrupoTresMilhar()
        {
            Conversor auxConvert = new Conversor();

            string auxMilhar = auxConvert.ConvertGrupoTresMilhar("921");

            Assert.AreEqual("Novecentos e Vinte Um Mil" , auxMilhar);

            auxMilhar = auxConvert.ConvertGrupoTresMilhar("364");

            Assert.AreEqual("Trezentos e Sessenta Quatro Mil", auxMilhar);

             auxMilhar = auxConvert.ConvertGrupoTresMilhar("111");

            Assert.AreEqual("Cento e Onze mil", auxMilhar);

        }

        [TestMethod]
        public void DeveRetornarPorExtensoEmGrupoTresMilhao()
        {
            Conversor auxConvert = new Conversor();

            string auxMilhar = auxConvert.ConvertGrupoTresMilhao("921");

            Assert.AreEqual("Novecentos e Vinte Um Milhões", auxMilhar);

            auxMilhar = auxConvert.ConvertGrupoTresMilhao("364");

            Assert.AreEqual("Trezentos e Sessenta Quatro Milhões", auxMilhar);

            auxMilhar = auxConvert.ConvertGrupoTresMilhao("111");

            Assert.AreEqual("Cento e Onze Milhões", auxMilhar);

        }

        [TestMethod]
        public void DeveRetornarPorExtensoEmGrupoTresSimples()
        {
            Conversor auxConvert = new Conversor();

            string auxMilhar = auxConvert.ConvertGrupoTres("921");

            Assert.AreEqual("Novecentos e Vinte Um", auxMilhar);

            auxMilhar = auxConvert.ConvertGrupoTres("364");

            Assert.AreEqual("Trezentos e Sessenta Quatro", auxMilhar);

            auxMilhar = auxConvert.ConvertGrupoTres("111");

            Assert.AreEqual("Cento e Onze", auxMilhar);

        }
        [TestMethod]
        public void DeveRetornarPorExtensoEmGrupoTresBilhao()
        {
            Conversor auxConvert = new Conversor();

            string auxMilhar = auxConvert.ConvertGrupoTresBilhao("921");

            Assert.AreEqual("Novecentos e Vinte Um Bilhões", auxMilhar);

            auxMilhar = auxConvert.ConvertGrupoTresBilhao("364");

            Assert.AreEqual("Trezentos e Sessenta Quatro Bilhões", auxMilhar);

            auxMilhar = auxConvert.ConvertGrupoTresBilhao("111");

            Assert.AreEqual("Cento e Onze Bilhões", auxMilhar);

        }
        
        [TestMethod]
        public void DeveRetornarPorExtensoEmGrupoTresCentavos()
        {
            Conversor auxConvert = new Conversor();

            string auxMilhar = auxConvert.ConvertCentavos("21");

            Assert.AreEqual("Vinte Um Centavos", auxMilhar);

            auxMilhar = auxConvert.ConvertCentavos("34");

            Assert.AreEqual("Trinta Quatro Centavos", auxMilhar);

            auxMilhar = auxConvert.ConvertCentavos("11");

            Assert.AreEqual("Onze Centavos", auxMilhar);

        }
    }
}
