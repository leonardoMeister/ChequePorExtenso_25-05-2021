using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChequePorExtenso.Dominio;
using System;

namespace TesteChequePorExtenso
{
    [TestClass]
    public class TesteConversorEspecifico
    {
        [TestMethod]
        public void DeveRetornarValoresSimples()
        {
            Simples tresPrimeirosValores = new Simples(1, 1, 3);

            string unidade = tresPrimeirosValores.StringUnidade();
            string dezena = tresPrimeirosValores.StringDezena();
            string centena = tresPrimeirosValores.StringCentena();

            Assert.AreEqual("Três", unidade);

            Assert.AreEqual("Treze", dezena);

            Assert.AreEqual("Cento e Treze", centena);

            tresPrimeirosValores = new Simples(9, 2, 0);

            unidade = tresPrimeirosValores.StringUnidade();
            dezena = tresPrimeirosValores.StringDezena();
            centena = tresPrimeirosValores.StringCentena();

            Assert.AreEqual("", unidade);

            Assert.AreEqual("Vinte", dezena);

            Assert.AreEqual("Novecentos", centena);
        }

        [TestMethod]
        public void DeveRetornarValoresMilhar()
        {
            Milhar tresPrimeirosValores = new Milhar(1, 1, 3);

            string unidade = tresPrimeirosValores.StringUnidade();
            string dezena = tresPrimeirosValores.StringDezena();
            string centena = tresPrimeirosValores.StringCentena();

            Assert.AreEqual("Três Mil", unidade);

            Assert.AreEqual("Treze mil", dezena);

            Assert.AreEqual("Cento e Treze mil", centena);

            tresPrimeirosValores = new Milhar(9, 2, 0);

            unidade = tresPrimeirosValores.StringUnidade();
            dezena = tresPrimeirosValores.StringDezena();
            centena = tresPrimeirosValores.StringCentena();

            Assert.AreEqual("Mil", unidade);

            Assert.AreEqual("Vinte", dezena);

            Assert.AreEqual("Novecentos", centena);
        }

        [TestMethod]
        public void DeveRetornarValoresMilhao()
        {
            Milhao tresPrimeirosValores = new Milhao(1, 1, 3);

            string unidade = tresPrimeirosValores.StringUnidade();
            string dezena = tresPrimeirosValores.StringDezena();
            string centena = tresPrimeirosValores.StringCentena();

            Assert.AreEqual("Três Milhões", unidade);

            Assert.AreEqual("Treze Milhões", dezena);

            Assert.AreEqual("Cento e Treze Milhões", centena);

            tresPrimeirosValores = new Milhao(9, 2, 0);

            unidade = tresPrimeirosValores.StringUnidade();
            dezena = tresPrimeirosValores.StringDezena();
            centena = tresPrimeirosValores.StringCentena();

            Assert.AreEqual("Milhões", unidade);

            Assert.AreEqual("Vinte", dezena);

            Assert.AreEqual("Novecentos", centena);
        }

        [TestMethod]
        public void DeveRetornarValoresBilhao()
        {
            Bilhao tresPrimeirosValores = new Bilhao(1, 1, 3);

            string unidade = tresPrimeirosValores.StringUnidade();
            string dezena = tresPrimeirosValores.StringDezena();
            string centena = tresPrimeirosValores.StringCentena();

            Assert.AreEqual("Três Bilhões", unidade);

            Assert.AreEqual("Treze Bilhões", dezena);

            Assert.AreEqual("Cento e Treze Bilhões", centena);

            tresPrimeirosValores = new Bilhao(9, 2, 0);

            unidade = tresPrimeirosValores.StringUnidade();
            dezena = tresPrimeirosValores.StringDezena();
            centena = tresPrimeirosValores.StringCentena();

            Assert.AreEqual("Bilhões", unidade);

            Assert.AreEqual("Vinte", dezena);

            Assert.AreEqual("Novecentos", centena);
        }

        [TestMethod]
        public void DeveRetornarValoresCentavos()
        {
            Centavos tresPrimeirosValores = new Centavos( 1, 3);

            string unidade = tresPrimeirosValores.StringUnidade();
            string dezena = tresPrimeirosValores.StringDezena();

            Assert.AreEqual("Três Centavos", unidade);

            Assert.AreEqual("Treze Centavos", dezena);

            tresPrimeirosValores = new Centavos( 2, 0);

            unidade = tresPrimeirosValores.StringUnidade();
            dezena = tresPrimeirosValores.StringDezena();

            Assert.AreEqual("Centavos", unidade);

            Assert.AreEqual("Vinte", dezena);

            tresPrimeirosValores = new Centavos(4, 8);

            unidade = tresPrimeirosValores.StringUnidade();
            dezena = tresPrimeirosValores.StringDezena();

            Assert.AreEqual("Oito Centavos", unidade);

            Assert.AreEqual("Quarenta", dezena);
        }
    }
}
