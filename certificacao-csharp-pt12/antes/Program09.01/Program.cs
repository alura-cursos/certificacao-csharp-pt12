using System;

namespace Program09._01
{
    class Program
    {
        static void Main(string[] args)
        {
            //TAREFA: CALCULAR O "CHECK SUM" PARA AS MENSAGENS

            ExibirChecksum("olá, mundo!");
            ExibirChecksum("mundo, olá!");

            ExibirChecksum("alura cursos online");
            ExibirChecksum("cursos online alura");

            Console.ReadLine();
        }

        static void ExibirChecksum(string origem)
        {
            Console.WriteLine("Checksum para {0} é {1}",
                origem, CalcularChecksum(origem));
        }

        static int CalcularChecksum(string mensagem)
        {
            //TAREFA: CALCULAR O "CHECK SUM" PARA A MENSAGEM
            int soma = 0;

            foreach (var ch in mensagem)
            {
                soma += ch;
            }

            return soma;
        }
    }
}
