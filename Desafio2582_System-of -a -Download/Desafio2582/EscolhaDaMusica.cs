using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio2582
{
    class EscolhaDaMusica
    {
        public int N1 { get; set; }
        public int N2 { get; set; }

        public EscolhaDaMusica(int n1, int n2)
        {
            N1 = n1;
            N2 = n2;
        }

        public String CalculoDaSomaParaEscolhaDaMusica()
        {
            int Soma = N1 + N2;

            switch (Soma)
            {
                case 0:
                    return "PROXYCITY";
                case 1:
                    return "P.Y.N.G.";
                case 2:
                    return "DNSUEY!";
                case 3:
                    return "SERVERS";
                case 4:
                    return "HOST!";
                case 5:
                    return "CRIPTONIZE";
                case 6:
                    return "OFFLINE DAY";
                case 7:
                    return "SALT";
                case 8:
                    return "ANSWER!";
                case 9:
                    return "RAR?";
                case 10:
                    return "WIFI ANTENNAS";
                default:
                    return "Inserir numeros de 0 a 9";
            }
        }
    }
}
