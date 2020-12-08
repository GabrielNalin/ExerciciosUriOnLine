using System;

namespace Uri1080_Maior_Posicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 5 valores inteiros para saber o maior valor digitado e a posição dele");

            int maior = int.Parse(Console.ReadLine());
            int posicao = 1;

            for (int i = 2; i <= 5; i++) {

                int x = int.Parse(Console.ReadLine());
                if( x > maior)
                {
                    maior = x;
                    posicao = i;
                }
            }
            Console.WriteLine("O Maior valor é o : " + maior);
            Console.WriteLine("A posição dele é: " + posicao);
        }
    }
}
