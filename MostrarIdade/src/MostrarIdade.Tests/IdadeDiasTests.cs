using NUnit.Framework;

namespace MostrarIdade.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Deve_Retornar_Idade_Em_Dias_Com_A_Entrada_De_Valores_Positivos()
        {
            var resultado = new IdadeDias(1, 1, 10).Calcular();
            Assert.AreEqual("1 ano(s), 1 mes(es) e 10 dia(s) expressa apenas em dias e igual a 405 dias.", resultado);
        }

        [Test]
        public void Deve_Retornar_Idade_Em_Dias_Com_A_Entrada_De_Valores_Negativos()
        {
            var resultado = new IdadeDias(-1, -1, -10).Calcular();
            Assert.AreEqual("1 ano(s), 1 mes(es) e 10 dia(s) expressa apenas em dias e igual a 405 dias.", resultado);
        }

        [Test]
        public void Deve_Retornar_Idade_Em_Dias_Com_A_Entrada_De_Anos_Negativa_Demais_Positivas()
        {
            var resultado = new IdadeDias(-1, 1, 10).Calcular();
            Assert.AreEqual("1 ano(s), 1 mes(es) e 10 dia(s) expressa apenas em dias e igual a 405 dias.", resultado);
        }

        [Test]
        public void Deve_Retornar_Idade_Em_Dias_Com_A_Entrada_De_Meses_Negativa_Demais_Positivas()
        {
            var resultado = new IdadeDias(1, -1, 10).Calcular();
            Assert.AreEqual("1 ano(s), 1 mes(es) e 10 dia(s) expressa apenas em dias e igual a 405 dias.", resultado);
        }

        [Test]
        public void Deve_Retornar_Idade_Em_Dias_Com_A_Entrada_De_Dias_Negativa_Demais_Positivas()
        {
            var resultado = new IdadeDias(1, 1, -10).Calcular();
            Assert.AreEqual("1 ano(s), 1 mes(es) e 10 dia(s) expressa apenas em dias e igual a 405 dias.", resultado);
        }
    }
}