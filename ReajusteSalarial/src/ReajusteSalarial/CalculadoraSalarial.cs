using System;
using System.Collections.Generic;
using System.Text;

namespace ReajusteSalarial
{
    public class CalculadoraSalarial
    {
        public double SalarioAtual { get; protected set; }
        public double PercentualReajuste { get; protected set; }

        private List<string> MensagensErro { get; set; }
        private bool IsConsistente => MensagensErro.Count == 0;

        public CalculadoraSalarial(double salarioAtual, double percentualReajuste)
        {
            MensagensErro = new List<string>();
            SalarioAtual = salarioAtual;
            PercentualReajuste = percentualReajuste;

            ValidarSalario();
        }

        private void ValidarSalario()
        {
            if (SalarioAtual < 0) MensagensErro.Add("Salario negativo");
        }

        public (List<string> mensagens, bool isValid) Calcular()
        {
            if (!IsConsistente) return (MensagensErro, false);

            var novoSalario = new List<string>();
            novoSalario.Add($"O salario de R$ {SalarioAtual} com reajuste de {PercentualReajuste}% é igual a R$ {(SalarioAtual + (SalarioAtual * PercentualReajuste / 100))}");

            return (novoSalario, true);
        }
    }
}
