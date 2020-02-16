using NUnit.Framework;

namespace VotosEleitores.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Deve_Retornar_Erro_Votos_Brancos_Maior_que_Eleitores_Quando_Receber_Mais_VotosBrancos_Que_Eleitores()
        {
            var calculadora = new CalculoEleitoral(10, 11, 0, 0);
            var (resultado, _) = calculadora.ObterEstatisticas();

            Assert.Contains("Votos brancos maiores que o total de eleitores do municipio", resultado);
        }


        [Test]
        public void Deve_Retornar_Erro_Votos_Nulos_Maior_que_Eleitores_Quando_Receber_Mais_VotosNulos_Que_Eleitores()
        {
            var calculadora = new CalculoEleitoral(10, 0, 11, 0);
            var (resultado, _) = calculadora.ObterEstatisticas();

            Assert.Contains("Votos nulos maiores que o total de eleitores do municipio", resultado);
        }

        [Test]
        public void Deve_Retornar_Erro_Votos_Validos_Maior_que_Eleitores_Quando_Receber_Mais_VotosValidos_Que_Eleitores()
        {
            var calculadora = new CalculoEleitoral(10, 0, 0, 11);
            var (resultado, _) = calculadora.ObterEstatisticas();

            Assert.Contains("Votos validos maiores que o total de eleitores do municipio", resultado);
        }

        [Test]
        public void Deve_Retornar_Erro_Soma_de_votos_Maior_que_Eleitores_Quando_Receber_Uma_Soma_De_Votos_Maior_Que_Eleitores()
        {
            var calculadora = new CalculoEleitoral(10, 3, 3, 5);
            var (resultado, _) = calculadora.ObterEstatisticas();

            Assert.Contains("A soma de todos os votos e maior que o total de eleitores", resultado);
        }

        [Test]
        public void Deve_Retornar_Cem_Porcento_Como_Votos_Brancos_Quando_Todos_Eleitores_Votarem_Em_Branco()
        {
            var calculadora = new CalculoEleitoral(10, 10, 0, 0);
            var (resultado, _) = calculadora.ObterEstatisticas();

            Assert.Contains("O total de votos Brancos representa 100% do total de 10 eleitores do municipio", resultado);
        }

        [Test]
        public void Deve_Retornar_Cem_Porcento_Como_Votos_Nulos_Quando_Todos_Eleitores_Votarem_Nulo()
        {
            var calculadora = new CalculoEleitoral(10, 0, 10, 0);
            var (resultado, _) = calculadora.ObterEstatisticas();

            Assert.Contains("O total de votos Nulos representa 100% do total de 10 eleitores do municipio", resultado);
        }

        [Test]
        public void Deve_Retornar_Cem_Porcento_Como_Votos_Validos_Quando_Todos_Eleitores_Emitirem_Votos_Validos()
        {
            var calculadora = new CalculoEleitoral(10, 0, 0, 10);
            var (resultado, _) = calculadora.ObterEstatisticas();

            Assert.Contains("O total de votos Validos representa 100% do total de 10 eleitores do municipio", resultado);
        }

        [Test]
        public void Deve_Retornar_A_Proporcao_20PorcentoBrancos_20Porcento_Nulos_20PorcentoValidos_Quando_Esta_Proporcao_For_Emitida()
        {
            var calculadora = new CalculoEleitoral(10, 2, 2, 2);
            var (resultado, _) = calculadora.ObterEstatisticas();

            Assert.Contains("O total de votos Brancos representa 20% do total de 10 eleitores do municipio", resultado);
            Assert.Contains("O total de votos Nulos representa 20% do total de 10 eleitores do municipio", resultado);
            Assert.Contains("O total de votos Validos representa 20% do total de 10 eleitores do municipio", resultado);
        }

        [Test]
        public void Deve_Validar_Calculo_Quando_Receber_Votos_Dentro_Do_Limite_De_Eleitores_Do_Municipio()
        {
            var calculadora = new CalculoEleitoral(10, 2, 2, 2);
            var (_, calculoValido) = calculadora.ObterEstatisticas();

            Assert.True(calculoValido);
        }


    }
}