using Desafio1047;
using System;


namespace uri1047
{
    class Program
    {
        static void Main(string[] args)
        {
            TempoDeJogo duracao = new TempoDeJogo();

            Console.WriteLine("Informe o horário inicial e final..");

            String[] valores = Console.ReadLine().Split(' ');
            duracao.HoraInicial = int.Parse(valores[0]);
            duracao.MinutoInicial = int.Parse(valores[1]);
            duracao.HoraFinal = int.Parse(valores[2]);
            duracao.MinutoFinal = int.Parse(valores[3]);

            duracao.TempoTotalDeJogo();

        }



    }
}