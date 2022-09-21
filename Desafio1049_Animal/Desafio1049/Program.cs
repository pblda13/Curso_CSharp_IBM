using System;

namespace Desafio1049
{
    class Program
    {
        static void Main(string[] args)

        {
            AnimalCaracteristicas palavra = new AnimalCaracteristicas();

            Console.WriteLine("Digite 3 caracteristicas do animal: ");
            palavra.Caracteristica1 = Console.ReadLine();
            palavra.Caracteristica2 = Console.ReadLine();
            palavra.Caracteristica3 = Console.ReadLine();
            Console.WriteLine();

            palavra.IndentificacaoDoAnimal();
        }
    }
}
