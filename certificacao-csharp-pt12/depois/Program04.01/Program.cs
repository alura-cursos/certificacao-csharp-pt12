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

            var saida1 = entrada1.Replace(" ", ",");
            Console.WriteLine(saida1);



            //Tarefa 2: separar nomes das linguagens por vírgulas:
            var entrada2 = "CSharp     Java   Python  Ruby Swift Scala ObjectiveC";

            //var saida2 = entrada2.Replace(" ", ",");

            var saida2 = Regex.Replace(entrada2, " +", ",");

            Console.WriteLine(saida2);


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

            var padrao = "^[0-9]+:([a-z]|[A-Z]| )+:[0-9][0-9][0-9][0-9]:[0-9]+$";

            bool registroValido = Regex.IsMatch(entrada3, padrao);
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