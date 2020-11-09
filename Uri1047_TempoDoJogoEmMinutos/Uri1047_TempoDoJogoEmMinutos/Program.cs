using System;

namespace Uri1047_TempoDoJogoEmMinutos
{
    class Program
    {
        static void Main(string[] args)
        {
        //Enunciado: https://www.urionlinejudge.com.br/judge/pt/problems/view/1047 //
        //Leia a hora inicial, minuto inicial, hora final e minuto final de um jogo. A seguir calcule a duração do jogo.//
        //Obs: O jogo tem duração mínima de um(1) minuto e duração máxima de 24 horas.//

            Console.WriteLine("Digite quatro números inteiros representando a hora de início e fim do jogo: (fomato: w x y z)");
            string[] valores = Console.ReadLine().Split(' ');
            int HoraInicial = int.Parse(valores[0]);
            int MinutoInicial = int.Parse(valores[1]);
            int HoraFinal = int.Parse(valores[2]);
            int MinutoFinal = int.Parse(valores[3]);

            int InstanteInicial = HoraInicial * 60 + MinutoInicial;
            int InstanteFinal = HoraFinal * 60 + MinutoFinal;

            int Duracao;
            if ( InstanteInicial < InstanteFinal)
            {
                Duracao = InstanteFinal - InstanteInicial;
            }
            else
            {
                Duracao = (24 * 60 - InstanteInicial) + InstanteFinal;
            }
            int DuracaoHoras = Duracao / 60;
            int DuracaoMinutos = Duracao % 60;

            Console.WriteLine("O JOGO DUROU " + DuracaoHoras + " HORA(S) E " + DuracaoMinutos + " MINUTO(S)");

        }
    }
}
