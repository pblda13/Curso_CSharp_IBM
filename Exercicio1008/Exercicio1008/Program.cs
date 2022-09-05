using System;
using System.Globalization;

namespace Exercicio1008
{
    class Program
    {
        static void Main(string[] args)
        {


            double total;

            int num = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            total = horas * salario;


            Console.WriteLine("NUMBER =  " + num);
            Console.WriteLine("SALARY = U$ " + total.ToString("F2", CultureInfo.InvariantCulture));


            Console.ReadKey();
        }
    }
}
