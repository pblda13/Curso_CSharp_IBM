using System;
using System.Globalization;

namespace Desafio1051
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Digite seu salário com duas casas decimais: ");
            var salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Imposto valor = new Imposto(salario);

            Console.WriteLine(valor);
        }
    }
   
}
