using System;

namespace Desafio1180
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quatidade de elementos:  ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os elementos: ");
            MenorEPosicao valor = new MenorEPosicao(N);

            valor.Condicao();
        }
    }
}