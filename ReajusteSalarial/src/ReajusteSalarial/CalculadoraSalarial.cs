using System;
using System.Collections.Generic;
using System.Text;

namespace ReajusteSalarial
{
    public class CalculadoraSalarial
    {
        public double SalarioAtual { get; protected set; }
        public double PercentualReajuste { get; protected set; }

        private string MensagemErro { get; set; }
        public bool IsConsistente => MensagemErro == null;

        public CalculadoraSalarial(double salarioAtual, double percentualReajuste)
        {
            SalarioAtual = salarioAtual;
            PercentualReajuste = percentualReajuste;

            ValidarSalario();
        }

        private void ValidarSalario()
        {
            if (SalarioAtual < 0) MensagemErro = "Salario negativo";
        }

        public string Calcular()
        {
            if (!IsConsistente) return MensagemErro;

            return $"O salario de R$ {SalarioAtual} com reajuste de {PercentualReajuste}% e igual a R$ {(SalarioAtual + (SalarioAtual * PercentualReajuste / 100))}";
        }
    }
}
