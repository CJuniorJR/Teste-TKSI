using System;
using System.Collections.Generic;
using System.Text;

namespace MostrarIdade
{
    public class IdadeDias
    {
        public int Anos { get; protected set; }
        public int Meses { get; protected set; }
        public int Dias { get; protected set; }

        public IdadeDias(int anos, int meses, int dias)
        {
            Anos = anos;
            Meses = meses;
            Dias = dias;

            ValidarNumeros();
        }

        private void ValidarNumeros()
        {
            if (Anos < 0) Anos = Math.Abs(Anos);
            if (Meses < 0) Meses = Math.Abs(Meses);
            if (Dias < 0) Dias = Math.Abs(Dias);
        }

        public string Calcular()
        {
            var somenteDias = 365 * Anos + 30 * Meses + Dias;
            return $"{Anos} ano(s), {Meses} mes(es) e {Dias} dia(s) expressa apenas em dias e igual a {somenteDias} dias.";
        }
    }
}
