using System;

namespace MostrarIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            int anos, meses, dias;
            Console.WriteLine("Digite a quantidade de anos: ");
            while (!int.TryParse(Console.ReadLine(), out anos))
            {
                Console.WriteLine("Numero invalido");
            }

            Console.WriteLine("Digite a quantidade de meses: ");
            while (!int.TryParse(Console.ReadLine(), out meses))
            {
                Console.WriteLine("Numero invalido");
            }

            Console.WriteLine("Digite a quantidade de dias: ");
            while (!int.TryParse(Console.ReadLine(), out dias))
            {
                Console.WriteLine("Numero invalido");
            }

            dias += 365 * anos + 30 * meses;

            Console.WriteLine("Idade em dias: " + dias);
        }
    }
}
