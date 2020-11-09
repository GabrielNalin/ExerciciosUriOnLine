using System;

namespace Uri1049_Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 03 característica do animal: vertebrado/vamifero/onivoro/carnivoro/ave/invertebrado ou anelideo?");

            string palavra1 = Console.ReadLine();
            string palavra2 = Console.ReadLine();
            string palavra3 = Console.ReadLine();

            if (palavra1 == "vertebrado")
            {
                if (palavra2 == "ave")
                {
                    if (palavra3 == "carnivoro")
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
                    if (palavra3 == "onivoro")
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
                if (palavra2 == "inseto")
                {
                    if (palavra3 == "hematofago")
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
                    if (palavra3 == "hematofago")
                    {
                        Console.WriteLine("lagarta");
                    }

                    else
                    {
                        if (palavra3 == "hematofago")
                        {
                            Console.WriteLine("sangussuga");
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
}
        
    

