using System;

namespace Desafio_1050
{
    class Program
    {
        static string SelecionandoEstados(int ddd)
        {
            var estado = string.Empty;
            switch (ddd)
            {
                case 11:
                    estado = "São Paulo";
                    break;
                case 19:
                    estado = "Campinas";
                    break;
                case 21:
                    estado = "Rio de Janeiro";
                    break;
                case 27:
                    estado = "Vitoria";
                    break;
                case 31:
                    estado = "Belo Horizonte";
                    break;
                case 32:
                    estado = "Juiz de Fora";
                    break;
                case 61:
                    estado = "Brasilia";
                    break;
                case 71:
                    estado = "Salvador";
                    break;
                default:
                    estado = "DDD não cadastrado";
                    break;
            }
            return estado;
        }


        static void Main(string[] args)
        {

            Console.WriteLine("Digite o DDD: ");
            Console.WriteLine();
            int DDD = int.Parse(Console.ReadLine());
            Console.WriteLine("Estado selecionado: " + SelecionandoEstados(DDD));

            Console.ReadKey();
        }

    }
}