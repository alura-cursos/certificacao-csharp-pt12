using Newtonsoft.Json;
using System;

namespace Program01._03
{
    class Program
    {
        static void Main(string[] args)
        {
            string json 
                = "{" +
                        "\"Diretor\":\"James Cameron\"," +
                        "\"Titulo\":\"Titanic\"," +
                        "\"DuracaoMinutos\":abc" +
                    "}";

            try
            {
                Filme filme = JsonConvert.DeserializeObject<Filme>(json);
                Console.WriteLine("Dados do objeto Filme: ");
                Console.WriteLine(filme);
            }
            catch(JsonReaderException e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadLine();
        }
    }

    public class Filme
    {
        public string Diretor { get; set; }
        public string Titulo { get; set; }
        public int DuracaoMinutos { get; set; }

        public override string ToString()
        {
            return Diretor + " - " + Titulo + " - " + DuracaoMinutos.ToString() + " minutos";
        }

        public Filme()
        {

        }

        public Filme(string diretor, string titulo, int duracaoMinutos)
        {
            Diretor = diretor;
            Titulo = titulo;
            DuracaoMinutos = duracaoMinutos;
        }
    }
}
