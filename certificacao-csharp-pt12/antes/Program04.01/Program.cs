using System;
using System.Text.RegularExpressions;

namespace Program04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tarefa 1: separar nomes das linguagens por vírgulas:
            var entrada1 = "CSharp Java Python Ruby Swift Scala ObjectiveC";

            //Tarefa 2: separar nomes das linguagens por vírgulas:
            var entrada2 = "CSharp     Java   Python  Ruby Swift Scala ObjectiveC";

            //Tarefa 3: validar o registro:
            //Formato do Registro
            //- campos devem ser separados por dois pontos: ":"
            //- Campo 1: Id do filme
            //- Campo 2: Título do filme
            //- Campo 3: Ano do filme
            //- Campo 4: Duração do filme em minutos
            //- Id, ano e duração são campos numéricos
            //- Título do filme são letras ou espaços
            var entrada3 = "123:O Exterminador do Futuro:1984:107";

            bool registroValido = true;
            if (registroValido)
            {
                Console.WriteLine("Registro de filme VÁLIDO");
            }
            else
            {
                Console.WriteLine("Registro de filme INVÁLIDO");
            }

            Console.ReadLine();
        }
    }
}