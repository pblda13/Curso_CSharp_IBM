using System;
using Desafio1071.Entities;

namespace Desafio1071
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois números: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            SomaDeImpares resultado = new SomaDeImpares(x, y);

            resultado.CalculoDosNumerosImpares();
        }
    }  
}
