using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio1021.Entities
{
    class Notas
    {
        public double N { get; set; }

        public Notas(double n)
        {
            N = n;
        }
        public void RealizacaoDosCalculos()
        {
            if (0 <= N && N <= 1000000.00)
            {
                Console.WriteLine();
                Console.WriteLine("NOTAS:");

                double n100 = N % 100;
                Console.WriteLine(Math.Truncate(N / 100) + " nota(s) de R$ 100.00");
                double n50 = n100 % 50;
                Console.WriteLine(Math.Truncate(n100 / 50) + " nota(s) de R$ 50.00");
                double n20 = n50 % 20;
                Console.WriteLine(Math.Truncate(n50 / 20) + " nota(s) de R$ 20.00");
                double n10 = n20 % 10;
                Console.WriteLine(Math.Truncate(n20 / 10) + " nota(s) de R$ 10.00");
                double n5 = n10 % 5;
                Console.WriteLine(Math.Truncate(n10 / 5) + " nota(s) de R$ 05.00");
                double n2 = n5 % 2;
                Console.WriteLine(Math.Truncate(n5 / 2) + " nota(s) de R$ 02.00");
                Console.WriteLine();

                Console.WriteLine("MOEDAS:");

                double m100 = n2 % 1;
                Console.WriteLine(Math.Truncate(n2 / 1) + " moeda(s) R$ 01.00");
                double m50 = m100 % 0.50;
                Console.WriteLine(Math.Truncate(m100 / 0.50) + " moeda(s) R$ 0.50");
                double m25 = m50 % 0.25;
                Console.WriteLine(Math.Truncate(m50 / 0.25) + " moeda(s) R$ 0.25");
                double m10 = m25 % 0.10;
                Console.WriteLine(Math.Truncate(m25 / 0.10) + " moeda(s) R$ 0.10");
                double m5 = m10 % 0.05;
                Console.WriteLine(Math.Truncate(m10 / 0.05) + " moeda(s) R$ 0.05");
                double m01 = m5 % 0.01;
                Console.WriteLine(Math.Truncate(m5 / 0.01) + " moeda(s) R$ 0.01");
            }
            else
            {
                Console.WriteLine("Invalid value!");
            }
            Console.WriteLine();
        }
    }
}