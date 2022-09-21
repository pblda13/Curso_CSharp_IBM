using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio3053
{
    class CondicaoParaAJogada
    {
        public int Casos { get; set; }
        public string Copos { get; set; }

        public CondicaoParaAJogada(int casos, string copos)
        {
            Casos = casos;
            Copos = copos;
        }

        public void Condicao()
        {
            int numero, Copo;
            int cont = 0;

            if (Copos[0] == 'A')
            {
                Copo = 1;
            }
            else
            {
                if (Copos[0] == 'B')
                {
                    Copo = 2;
                }
                else
                {
                    Copo = 3;
                }
            }
            while (cont < Casos)
            {
                numero = int.Parse(Console.ReadLine());
                if (numero == 1)
                {
                    if (Copo != 3)
                    {
                        if (Copo == 1)
                        {
                            Copo = 2;
                        }
                        else
                        {
                            Copo = 1;
                        }
                    }
                }
                else
                {
                    if (numero == 2)
                    {
                        if (Copo != 1)
                        {
                            if (Copo == 2)
                            {
                                Copo = 3;
                            }
                            else
                            {
                                Copo = 2;
                            }
                        }
                    }
                    else
                    {
                        if (Copo != 2)
                        {
                            if (Copo == 1)
                            {
                                Copo = 3;
                            }
                            else
                            {
                                Copo = 1;
                            }
                        }
                    }
                }
                cont++;
            }
            if (Copo == 1)
            {
                Console.Write("A");
                Console.Write("\n");
            }
            else
            {
                if (Copo == 2)
                {
                    Console.Write("B");
                    Console.Write("\n");
                }
                else
                {
                    Console.Write("C");
                    Console.Write("\n");
                }
            }

        }

    }
}




