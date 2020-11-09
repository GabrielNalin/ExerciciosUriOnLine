using System;
using System.Globalization;

namespace Uri1014_Consumo_de_Combustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            double y, ConsumoMedio;

            x = int.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ConsumoMedio = (double)x / y;

            Console.WriteLine(ConsumoMedio.ToString("F3", CultureInfo.InvariantCulture) + " Km/l");

        }
    }
}
