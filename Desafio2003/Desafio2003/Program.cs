using System;

namespace Desafio2003
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora, min;
            do
            {
                Console.WriteLine("Digite a hora que Bino acordou: ");
                string[] relogio = Console.ReadLine().Split(':');
                hora = int.Parse(relogio[0]);
                min = int.Parse(relogio[1]);

                HoradaFeira atraso = new HoradaFeira(hora, min);

                atraso.CalculoAtraso();

                Console.WriteLine(atraso);
                Console.WriteLine();

            } while (hora > 0);
        }
    }
}