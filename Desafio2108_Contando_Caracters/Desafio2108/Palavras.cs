using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio2108
{
    class Palavras
    {
        public void ContagemDePalavras()
        {
            int count = 0;
            int wordSize = 0;
            string[] word;

            while (true)
            {
                
                word = Console.ReadLine().Split(' ');
                wordSize = word[count].Length;
                for (int i = 0; i < word.Length; i++)
                {
                    Console.Write($"{wordSize = word[count].Length}- ");
                    count++;
                }

                count++;
                Console.WriteLine("");

                if (wordSize == 0)
                {
                    break;
                }
            }
        }
    }
}