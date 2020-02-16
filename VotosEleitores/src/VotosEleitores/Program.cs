using System;
using System.Linq;

namespace VotosEleitores
{
    class Program
    {
        static void Main(string[] args)
        {
            int eleitores, votosBrancos, votosNulos, votosValidos;

            Console.WriteLine("Insira a quantidade de eleitores do municipio");
            while(!int.TryParse(Console.ReadLine(), out eleitores))
            {
                Console.WriteLine("Numero invalido");
            }

            Console.WriteLine("Insira a quantidade de votos brancos");
            while (!int.TryParse(Console.ReadLine(), out votosBrancos))
            {
                Console.WriteLine("Numero invalido");
            }

            Console.WriteLine("Insira a quantidade de votos nulos");
            while (!int.TryParse(Console.ReadLine(), out votosNulos))
            {
                Console.WriteLine("Numero invalido");
            }

            Console.WriteLine("Insira a quantidade de votos validos");
            while (!int.TryParse(Console.ReadLine(), out votosValidos))
            {
                Console.WriteLine("Numero invalido");
            }


            var calculador = new CalculoEleitoral(eleitores, votosBrancos, votosNulos, votosValidos);

            var(mensagens, isCalculoValido) = calculador.ObterEstatisticas();

            if (!isCalculoValido)
            {
                Console.WriteLine("Dados invalidos para calculo. Motivos:");
            }

            mensagens.ForEach(x => Console.WriteLine(x));
            Console.ReadKey();


        }
    }
}
