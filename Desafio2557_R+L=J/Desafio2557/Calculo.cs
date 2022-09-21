using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio2557
{
    class Calculo
    {

        public int Valores { get; set; }

        public void Condicao()
        {

            while (true)
            {
                String[] valores = Console.ReadLine().Replace("=", "+").Split("+");
                int resultado;

                if (valores[0] == "R")
                {
                    resultado = int.Parse(valores[2]) - int.Parse(valores[1]);
                }
                else if (valores[1] == "L")
                {
                    resultado = int.Parse(valores[0]) - int.Parse(valores[2]);
                }
                else
                {
                    resultado = int.Parse(valores[0]) + int.Parse(valores[1]);
                }

                Console.WriteLine(resultado);
            }
        }
    }
}
