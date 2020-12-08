using System;

namespace Uri114_SenhaFixa_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a senha correta:");
            int senhaCorreta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a senha para teste:");
            int senhaTeste = int.Parse(Console.ReadLine());

            while (senhaCorreta != senhaTeste)
            {
                Console.WriteLine("Senha Inválida.Tente novamente");
                senhaTeste = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");

        }
    }
}
