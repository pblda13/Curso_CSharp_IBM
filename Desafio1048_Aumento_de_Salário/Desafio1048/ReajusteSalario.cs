using System;
using System.Globalization;

namespace Desafio1048
{
    class ReajusteSalario
    {
        public double Salario { get; set; }
        public double Reajuste { get; set; }
        public double Percentual { get; set; }

        public ReajusteSalario(double salario)
        {
            Salario = salario;
        }

        public double CalculoSalario()
        {
            double percentual;
            if (Salario <= 400.0)
            {
                percentual = 15.0;
            }
            else if (Salario <= 800.0)
            {
                percentual = 12.0;
            }
            else if (Salario <= 1200.0)
            {
                percentual = 10.0;
            }
            else if (Salario <= 2000.0)
            {
                percentual = 7.0;
            }
            else
            {
                percentual = 4.0;
            }

            return percentual;
        }

        public double CalculoReajuste()
        {
            double reajuste;

            return reajuste = Salario * CalculoSalario() / 100.0;
        }

        public double CalculoNovoSalario()
        {
            double novoSalario;
            return novoSalario = Salario + CalculoReajuste();
        }


        public string SalarioExibir()
        {
            return "Novo salario: " + CalculoNovoSalario().ToString("F2", CultureInfo.InvariantCulture); ;
        }

        public string ReajusteExibir()
        {
            return "Reajuste ganho: " + CalculoReajuste().ToString("F2", CultureInfo.InvariantCulture);
        }

        public string PercentualExibir()
        {
            return "Em percentual: " + CalculoSalario() + " %";

        }

    }
}