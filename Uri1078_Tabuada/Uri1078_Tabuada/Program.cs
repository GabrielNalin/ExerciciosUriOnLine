using System;

namespace Uri1078_Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para saber a tabuada: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int result = i * n;

                Console.WriteLine(n + " x " + i + " = " + result);
            }
        }
    }
}
