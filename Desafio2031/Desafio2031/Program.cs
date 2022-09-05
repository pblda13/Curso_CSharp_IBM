using System;

namespace Desafio2031
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de jogadas: ");
            int n = int.Parse(Console.ReadLine());
           
            CondicaoDoJogo resultado = new CondicaoDoJogo(n);

            resultado.Resultado();
        }
    }
}