using System;
using System.Collections.Generic;
using System.Text;

namespace VotosEleitores
{
    public class CalculoEleitoral
    {
        public int TotalEleitores { get; protected set; }
        public int VotosBrancos { get; protected set; }
        public int VotosNulos { get; protected set; }
        public int VotosValidos { get; protected set; }
        private List<string>MensagensErro { get; set; }

        public bool IsConsistente => MensagensErro.Count == 0;
        public CalculoEleitoral(int totalEleitores, int votosBrancos, int votosNulos, int votosValidos)
        {
            MensagensErro = new List<string>();

            TotalEleitores = totalEleitores;
            VotosBrancos = votosBrancos;
            VotosNulos = votosNulos;
            VotosValidos = votosValidos;

            ValidarDados();
        }

        private void ValidarDados()
        {
            if (VotosBrancos > TotalEleitores) MensagensErro.Add("Votos brancos maiores que o total de eleitores do municipio"); 
            if (VotosNulos > TotalEleitores) MensagensErro.Add("Votos nulos maiores que o total de eleitores do municipio"); 
            if (VotosValidos > TotalEleitores) MensagensErro.Add("Votos validos maiores que o total de eleitores do municipio");
            if ((VotosBrancos + VotosNulos + VotosValidos) > TotalEleitores) MensagensErro.Add("A soma de todos os votos e maior que o total de eleitores");
        }

        public List<string> ObterEstatisticas()
        {
            if (!IsConsistente) return MensagensErro;

            var estatisticas = new List<string>();
            estatisticas.Add($"O total de votos Brancos representa {(TotalEleitores * ((double)VotosBrancos/100))*100}% do total de {TotalEleitores} eleitores do municipio");
            estatisticas.Add($"O total de votos Nulos representa {(TotalEleitores * ((double)VotosNulos /100))*100}% do total de {TotalEleitores} eleitores do municipio");
            estatisticas.Add($"O total de votos Validos representa {(TotalEleitores * ((double)VotosValidos /100))*100}% do total de {TotalEleitores} eleitores do municipio");

            return estatisticas;
        }
        
    }
}
