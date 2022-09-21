using System;

namespace Desafio3342
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro");
            int x = int.Parse(Console.ReadLine());
            CasasDoTabuleiro casas = new CasasDoTabuleiro(x);

            casas.ContagemdeCasas();
        }
    }
}
