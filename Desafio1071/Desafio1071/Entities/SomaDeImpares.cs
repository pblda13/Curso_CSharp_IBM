using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio1071.Entities
{
    class SomaDeImpares
    {
        public int X { get; set; }
        public int Y { get; set; }

        public SomaDeImpares()
        {
        }
        public SomaDeImpares(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void CalculoDosNumerosImpares()
        {
            int min, max;
            if (X < Y)
            {
                min = X;
                max = Y;
            }
            else
            {
                min = Y;
                max = X;
            }

            int soma = 0;
            for (int i = min + 1; i < max; i++)
            {
                if (i % 2 != 0)
                {
                    soma = soma + i;
                }
            }

            Console.WriteLine(soma);
        }
    }
}
