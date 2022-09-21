using System;

namespace Desafio1078
{


    class Program
    {
        public static void CalcTabuada( )
        {
            double n, t;
            n = int.Parse(Console.ReadLine());

            for (int a = 0; a <= 10; a++)
            {
                t = n * a;
                Console.WriteLine(n + " X " + a + " = " + t);
            }
            return ;
        }
        
       
        public static void Main(string[] args)
        {


            CalcTabuada();

        }

       
    }
}
  


