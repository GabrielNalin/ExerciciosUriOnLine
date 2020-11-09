using System;
using System.Globalization;

namespace URI_1009_Salario_com_Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nome;
            double SalarioFixo, TotalDasVendas, SalarioTotal;

            Nome = Console.ReadLine();
            SalarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            TotalDasVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            SalarioTotal = SalarioFixo + TotalDasVendas * 0.15;

            Console.WriteLine("TOTAL = R$" + SalarioTotal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
