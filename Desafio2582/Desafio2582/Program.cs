using System;

namespace Desafio2582
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Quantas repetições? ");
                var N = int.Parse(Console.ReadLine());
                Console.WriteLine("Escolha números de 0 a 9,para cada repetição: ");

                for (int i = 0; i < N; i++)
                {
                    string[] numeros = Console.ReadLine().Split(' ');
                    var n1 = int.Parse(numeros[0]);
                    var n2 = int.Parse(numeros[1]);

                    EscolhaDaMusica escolha = new EscolhaDaMusica(n1, n2);
                    Console.WriteLine(escolha.CalculoDaSomaParaEscolhaDaMusica());
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error! " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(" Erro! " + e.Message);
            }
        }
    }
}
