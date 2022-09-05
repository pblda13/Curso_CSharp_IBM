using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio1019
{
    class Conversao
    {

        private int N { get; set; }
        

        public Conversao(int n)
        {
            N = n;
          
        }

        public void CalculoDeConversaoDeTempo()
        {
            int  horas, resto, minutos, segundos;

            horas = N / 3600;
            resto = N % 3600;

            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(horas + " : " + minutos + " : " + segundos);


        }
        
    }
}
