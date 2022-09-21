using System;
using System.Globalization;
using Desafio1021.Entities;
namespace Desafio1021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor: ");
            double n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Notas valor = new Notas(n);

            valor.RealizacaoDosCalculos();
        }
    }
}

