using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio1115
{
    class Quadrante
    {
        private int X { get; set; }
        private int Y { get; set; }
       
        public Quadrante(int x, int y)
        {
            X = x;
            Y = y;
        }
        public string Condicao()
        {
            while (X != 0 || Y != 0)
            {
                if (X > 0 && Y > 0)
                {
                    return("primeiro");                 
                }
                else if (X < 0 && Y > 0)
                {
                    return("segundo");                   
                }
                else if (X < 0 && Y < 0)
                {
                    return("terceiro");                 
                }
                else
                {
                    return ("quarto");
                }
            }
            return "Não existente";
        }
    }
}
