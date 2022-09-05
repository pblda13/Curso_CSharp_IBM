using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio1047
{
    public class TempoDeJogo
    {
        public int HoraInicial;
        public int MinutoInicial;
        public int HoraFinal;
        public int MinutoFinal;


        public void TempoTotalDeJogo()

        {
            int hora = (24 - HoraInicial) + HoraFinal;
            int minutos = (60 - MinutoInicial) + MinutoFinal;
            if (hora > 24)
                hora = HoraFinal - HoraInicial;


            if (hora < 0)
            {
                hora += 24;
            }

            minutos = MinutoFinal - MinutoInicial;

            if (minutos < 0)
            {
                minutos += 60;
                hora -= 1;
            }

            if (minutos == 0 && hora == 0)
            {
                hora = hora - 24;
                minutos = minutos - 60;
                Console.WriteLine("O JOGO DUROU " + hora + " HORA(S) E " + minutos + " MINUTOS");
                Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
            }
            else
            {
                Console.WriteLine("O JOGO DUROU " + hora + " HORA(S) E " + minutos + " MINUTOS");
            }



        }


    }
}



