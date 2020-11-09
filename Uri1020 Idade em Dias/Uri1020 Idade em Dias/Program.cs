using System;

namespace Uri1020_Idade_em_Dias
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, Meses, Anos, Resto, Dias;

            N = int.Parse(Console.ReadLine());

            Anos = N / 365;
            Resto = N % 365;
            Meses = Resto / 30;
        

            Dias = Resto % 30;

            Console.WriteLine(Anos + " ano(s)");
            Console.WriteLine(Meses + " mes(es)");
            Console.WriteLine(Dias + " dia(s)");

        }
    }
}
