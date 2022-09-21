using System;

namespace Desafio2031
{
    class CondicaoDoJogo
    {
        private string Jogador1 { get; set; }
        private string Jogador2 { get; set; }
        private int N { get; set; }

        public CondicaoDoJogo( int n)
        {     
            N = n;
        }

        public void Resultado()
        {
            for (int i = 0; i < N; i++)
            {
                Jogador1 = Console.ReadLine();
                Jogador2 = Console.ReadLine();

                if (Jogador1 == "ataque" && Jogador2 == "ataque")
                {
                    Console.WriteLine("Aniquilacao mutua");
                }
                else if (Jogador1 == "papel" && Jogador2 == "papel")
                {
                    Console.WriteLine("Ambos venceram");
                }
                else if (Jogador1 == "ataque")
                {
                    Console.WriteLine("Jogador 1 venceu");
                }
                else if (Jogador2 == "ataque")
                {
                    Console.WriteLine("Jogador 2 venceu");
                }
                else if (Jogador2 == "papel")
                {
                    Console.WriteLine("Jogador 1 venceu");
                }
                else if (Jogador1 == "papel")
                {
                    Console.WriteLine("Jogador 2 venceu");
                }
                else
                {
                    Console.WriteLine("Sem ganhador");
                }
            }
        }
    }
}
