using System;

namespace Uri1113_CrescenteDecrescente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois valores separados por espaço. Para encerrar, digite dois valores iguais.");

            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            while (x != y)
            {
                if (x < y)
                {
                    Console.WriteLine("Crescente");

                }
                else
                {
                    Console.WriteLine("Decrescente");

                }

                valores = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);

            }
        }
    }
}
