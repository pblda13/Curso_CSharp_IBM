using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio3342
{
    class CasasDoTabuleiro
    {
        private int X { get; set; }

        public CasasDoTabuleiro(int x)
        {
            X = x;
        }
        public void ContagemdeCasas()
        {
            int a, b, i = 0;
            int cont = 0;

            a = b = 0;
            for (; i < (X * X); i++)
            {
                if (cont == 0)
                {
                    a++;
                    cont = 1;
                }
                else
                {
                    b++;
                    cont = 0;
                }
            }
            Console.WriteLine(a + " casas brancas e " + b + " casas pretas");
        }
    }
}
