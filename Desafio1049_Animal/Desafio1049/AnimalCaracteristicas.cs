using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio1049
{
    class AnimalCaracteristicas
    {
        public string Caracteristica1 { get; set; }
        public string Caracteristica2 { get; set; }
        public string Caracteristica3 { get; set; }

        public AnimalCaracteristicas()
        {
            
        }
        public AnimalCaracteristicas(string caracteristica1, string caracteristica2, string caracteristica3)
        {
            Caracteristica1 = caracteristica1;
            Caracteristica2 = caracteristica2;
            Caracteristica3 = caracteristica3;
        }

        public void IndentificacaoDoAnimal()
        {
            if (Caracteristica1 == "vertebrado")
            {
                if (Caracteristica2 == "ave")
                {
                    if (Caracteristica3 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else
                {
                    if (Caracteristica3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else
            {
                if (Caracteristica2 == "inseto")
                {
                    if (Caracteristica3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else
                {
                    if (Caracteristica3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else
                    {
                        Console.WriteLine("minhoca");
                    }
                }

            }






        }

    }

}