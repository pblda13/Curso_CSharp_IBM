using System;

namespace Desafio1961
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Digite o n° de pulos e de canos: ");
			string[] inicio = Console.ReadLine().Split(' ');
			int P = int.Parse(inicio[0]);
			int N = int.Parse(inicio[1]);
			Console.WriteLine("Digite a altura dos canos: ");
			string[] pulo = Console.ReadLine().Split(' ');
			int[] pulos = Array.ConvertAll(pulo, int.Parse);
			bool WIN = true;

			for (int i = 0; i < (N - 1); i++)
			{
				if ((pulos[i] - pulos[i + 1]) < (-P))
				{
					WIN = false;
				}
				else if ((pulos[i] - pulos[i + 1]) > P)
				{
					WIN = false;
				}
			}
			if (WIN)
			{
				Console.WriteLine("YOU WIN");
			}
			else
			{
				Console.WriteLine("GAME OVER");
			}
		}
	}
}