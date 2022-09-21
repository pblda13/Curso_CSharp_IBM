using System;
using System.Globalization;

namespace Desafio1048
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o seu salário: ");
            var salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ReajusteSalario calculo = new ReajusteSalario(salario);

            Console.WriteLine();
            Console.WriteLine(calculo.SalarioExibir());
            Console.WriteLine();
            Console.WriteLine(calculo.ReajusteExibir());
            Console.WriteLine();
            Console.WriteLine(calculo.PercentualExibir());
        }
    }
}
