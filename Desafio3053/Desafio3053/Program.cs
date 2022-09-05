using System;

namespace Desafio3053
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de movimentos: ");
            int casos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a posicão da moeda (A,B ou C) : ");
            string copos = Console.ReadLine();

            CondicaoParaAJogada resultado = new CondicaoParaAJogada(casos, copos);

            resultado.Condicao();
        }
    }
}