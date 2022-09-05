using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Desafio1051
{
    class Imposto
    {
        private double Salario { get; set; }

        public Imposto(double salario)
        {
            Salario = salario;
        }

       private double CalculoDoImposto()
        {
            double imposto;
            double[] salarioFaixa_1 = new double[] { 0, 2000 };
            double[] salarioFaixa_2 = new double[] { 2000.01, 3000 };
            double[] salarioFaixa_3 = new double[] { 3000.01, 4500 };

            if (Salario < salarioFaixa_1[1])
            {
                imposto = 0.0;
            }
            else if (Salario <= salarioFaixa_2[1])
            {
                imposto = (Salario - salarioFaixa_1[1]) * 0.08;
            }
            else if (Salario <= salarioFaixa_3[1])
            {
                imposto = (Salario - salarioFaixa_2[1]) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                imposto = (Salario - salarioFaixa_3[1]) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }
            return imposto;
        }
          public override string ToString()
        {
            var resultado = CalculoDoImposto();
            return resultado == 0.0 ? "Isento" : "R$ " + resultado.ToString("F2", CultureInfo.InvariantCulture);
        }
    } 
}








