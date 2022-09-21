using System;

namespace Desafio1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            Console.WriteLine("Digte os segundos: ");

            N = int.Parse(Console.ReadLine());

            Conversao valor = new Conversao(N);

            valor.CalculoDeConversaoDeTempo();
        }
    }
}
