using System;

namespace Desafio1115
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as coordenadas X,Y: ");
            string[] vet = Console.ReadLine().Split(' ');
            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);

            Quadrante valor = new Quadrante(x, y);

            valor.Condicao();
        }
    }
}