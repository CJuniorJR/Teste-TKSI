using NUnit.Framework;

namespace ReajusteSalarial.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Deve_Retornar_Erro_Salario_Valor_Negativo()
        {
            var calculadora = new CalculadoraSalarial(-1000, 50);
            var (resultado, _) = calculadora.Calcular();

            Assert.Contains("Salario negativo", resultado);
        }

        [Test]
        public void Deve_Retornar_Salario_Com_Reajuste_De_Percentual_Positivo()
        {
            var calculadora = new CalculadoraSalarial(1000, 50);
            var (resultado, _) = calculadora.Calcular();

            Assert.Contains("O salario de R$ 1000 com reajuste de 50% é igual a R$ 1500", resultado);
        }

        [Test]
        public void Deve_Retornar_Salario_Com_Reajuste_De_Percentual_Negativo()
        {
            var calculadora = new CalculadoraSalarial(1000, -50);
            var (resultado, _) = calculadora.Calcular();

            Assert.Contains("O salario de R$ 1000 com reajuste de -50% é igual a R$ 500", resultado);
        }
    }
}