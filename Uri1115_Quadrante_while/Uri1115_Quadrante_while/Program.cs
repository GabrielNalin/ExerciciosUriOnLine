using System;

namespace Uri1115_Quadrante_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois valores separados por espaço para saber a qual quadrante a coordenada pertence:");

            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro quadrante");
                }
                else if (x < 0 && y > 0){
                        Console.WriteLine("segundo quadrante");
                    }
                    else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro quadrante");
                }
                else 
                {
                    Console.WriteLine("quarto quadrante");
                }
                valores = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);

                }
            }
        }
    }

