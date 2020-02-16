using System;

namespace ReajusteSalarial
{
    class Program
    {
        static void Main(string[] args)
        {
            double salarioAtual, percentualReajuste;

            Console.WriteLine("Digite o Salário atual do funcionario");
            while (!double.TryParse(Console.ReadLine(), out salarioAtual))
            {
                Console.WriteLine("Numero invalido");
            }

            Console.WriteLine("Digite o percentual de reajuste");
            while (!double.TryParse(Console.ReadLine(), out percentualReajuste))
            {
                Console.WriteLine("Numero invalido");
            }

            var calculadora = new CalculadoraSalarial(salarioAtual, percentualReajuste);

            var (mensagens, isCalculoValido) = calculadora.Calcular();

            if (!isCalculoValido)
            {
                Console.WriteLine("Dados Invalidos para o calculo, motivos:");
            }

            mensagens.ForEach(mensagem => Console.WriteLine(mensagem));
            Console.ReadKey();
        }
    }
}
