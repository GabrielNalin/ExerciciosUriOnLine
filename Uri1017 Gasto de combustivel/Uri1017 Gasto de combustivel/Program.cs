using System;
using System.Globalization;

namespace Uri1017_Gasto_de_combustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo, VelocidadeMedia, DistanciaPercorrida;
            Double LitrosNecessários;

            tempo = int.Parse(Console.ReadLine());
            VelocidadeMedia = int.Parse(Console.ReadLine());

            DistanciaPercorrida = tempo * VelocidadeMedia;
            LitrosNecessários = DistanciaPercorrida / 12.0;

            Console.WriteLine(LitrosNecessários.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
