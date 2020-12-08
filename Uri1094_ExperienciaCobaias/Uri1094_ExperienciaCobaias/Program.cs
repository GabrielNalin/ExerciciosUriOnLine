using System;

namespace Uri1094_ExperienciaCobaias
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maria acabou de iniciar seu curso de graduação na faculdade de medicina e precisa de sua ajuda para organizar" +
                "os experimentos de um laboratório o qual ela é responsável. Ela quer saber no final do ano, quantas cobaias foram utilizadas" +
                "no laboratório e o percentual de cada tipo de cobaia utilizada.Este laboratório em especial utiliza três tipos de cobaias: " +
                "sapos, ratos e coelhos.Para obter estas informações, ela sabe exatamente o número de experimentos que foram realizados, " +
                "o tipo de cobaia utilizada e a quantidade de cobaias utilizadas em cada experimento. A primeira linha de entrada contém" +
                "um valor inteiro N que indica os vários casos de teste que vem a seguir. Cada caso de teste contém um " +
                "inteiro Quantia (1 ≤ Quantia ≤ 15) que representa a quantidade de cobaias utilizadas e um caractere" +
                "Tipo ('C', 'R' ou 'S'), indicando o tipo de cobaia (R:Rato S:Sapo C:Coelho).");

            int n = int.Parse(Console.ReadLine());

            int coelhos = 0;
            int ratos = 0;
            int sapos = 0;

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                int quantia = int.Parse(valores[0]);
                char tipo = char.Parse(valores[1]);

                if (tipo == 'c')
                {
                    coelhos = coelhos + quantia;
                }
                else if (tipo == 'r')
                {
                    ratos = ratos + quantia;
                }
                else
                {
                    sapos = sapos + quantia;
                }
            }
            int total = coelhos + ratos + sapos;
            double porcentagemCoelhos = (double)coelhos / total * 100.0;
            double porcentagemRatos = (double)ratos / total * 100;
            double porcentagemSapos = (double)sapos / total * 100;

            Console.WriteLine("Total: " + total + " cobaias");
            Console.WriteLine("Total de coelhos: " + coelhos);
            Console.WriteLine("Total de ratos: " + ratos);
            Console.WriteLine("Total de sapos: " + sapos);
            Console.WriteLine("Percentual de coelhos: " + porcentagemCoelhos.ToString("F2") + " %");
            Console.WriteLine("Percentual de ratos: " + porcentagemRatos.ToString("F2") + " %");
            Console.WriteLine("Percentual de sapos: " + porcentagemSapos.ToString("F2") + " %");

        }
    }
}
