using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio2003
{
    class HoradaFeira
    {
        private int Hora { get; set; }
        private int Min { get; set; }

        public HoradaFeira(int hora, int min)
        {
            Hora = hora;
            Min = min;
        }

        public String CalculoAtraso()
        {
            if (Hora < 7)
            {
               return "Atraso maximo: 0";
            }
            else if (Hora == 7)
            {
                return "Atraso maximo: " + Min;
            }
            else
            {
               return "Já está atrasado: " + (Hora - 7 + 1) + ":" + Min;
            }
        }
        public override string ToString()
        {
            string atraso = CalculoAtraso();
            return atraso;
        }
    }
}



