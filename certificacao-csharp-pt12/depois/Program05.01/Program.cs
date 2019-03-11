using System;

namespace Program05._01
{
    class Program
    {
        static void Main(string[] args)
        {
            //TAREFA: EXIBIR O DOBRO DE UM NÚMERO DIGITADO, 
            //VALIDANDO CONTRA STRING VAZIA, ESPAÇOS EM BRANCO E NÚMERO INVÁLIDO

            bool valido = true;
            int numero = 0;
            string entrada;

            do
            {
                Console.WriteLine("Digite um número:");
                entrada = Console.ReadLine();

                valido = !string.IsNullOrWhiteSpace(entrada);

                valido = valido &&
                    int.TryParse(entrada, out numero);

                if (!valido)
                {
                    Console.WriteLine("Entrada inválida!");
                }
            } while (!valido);

            //numero = int.Parse(entrada);

            Console.WriteLine("O dobro de {0} é {1}", numero, numero * 2);

            Console.ReadLine();

        }
    }
}
