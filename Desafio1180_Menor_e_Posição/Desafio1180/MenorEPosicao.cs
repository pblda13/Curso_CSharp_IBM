using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio1180
{
    class MenorEPosicao
    {

        private int N { get; set; }

        public MenorEPosicao(int n)
        {
            N = n;
        }
        public void Condicao()
        {
            int[] X = new int[N];
            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                X[i] = int.Parse(s[i]);
            }

            int menor = X[0];
            int posicao = 0;

            for (int i = 0; i < N; i++)
            {
                if (menor > X[i])
                {
                    menor = X[i];
                    posicao = i;
                }
            }

            Console.WriteLine("Menor valor: " + menor);
            Console.WriteLine("Posicao: " + posicao);
        }


    }



}
