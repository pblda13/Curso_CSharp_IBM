using System;

namespace Desafio2764
{
    class Program
    {
        static void Main(string[] args)
        {
            TextoArquivo transcricaodetxt = new TextoArquivo();
            transcricaodetxt.LeituraDeArquivo();

            transcricaodetxt.EscreverNosArquivos();

            Console.WriteLine("Transcrição concluida");
            Console.WriteLine();

            Console.WriteLine(transcricaodetxt.D1);
            Console.WriteLine(transcricaodetxt.D2);
            Console.WriteLine(transcricaodetxt.D3);
        }
    }
}
