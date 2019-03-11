using System;
using System.Collections.Generic;

namespace Program01_01
{
    class Filme
    {
        public string Diretor { get; set; }
        public string Titulo { get; set; }
        public int DuracaoMinutos { get; set; }

        public override string ToString()
        {
            return Diretor + " - " + Titulo + " - " + DuracaoMinutos.ToString() + " minutos";
        }

        public Filme(string diretor, string titulo, int duracaoMinutos)
        {
            Diretor = diretor;
            Titulo = titulo;
            DuracaoMinutos = duracaoMinutos;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Filme filme =
            //    new Filme(diretor: "James Cameron",
            //    titulo: "Titanic",
            //    duracaoMinutos: 194);

            //string json = JsonConvert.SerializeObject(filme);
            //Console.WriteLine("JSON: ");
            //Console.WriteLine(json);

            //Filme filmeConvertido = JsonConvert.DeserializeObject<Filme>(json);
            //Console.WriteLine("Dados do objeto Filme: ");
            //Console.WriteLine(filmeConvertido);
            //Console.WriteLine();

            //List<Filme> coletaneaJamesCameron = new List<Filme>();

            //Filme filme1 = new Filme(diretor: "James Cameron", titulo: "Titanic", duracaoMinutos: 194);
            //Filme filme2 = new Filme(diretor: "James Cameron", titulo: "Avatar", duracaoMinutos: 162);
            //Filme filme3 = new Filme(diretor: "James Cameron", titulo: "O Exterminador do Futuro", duracaoMinutos: 107);
            //coletaneaJamesCameron.Add(filme1);
            //coletaneaJamesCameron.Add(filme2);
            //coletaneaJamesCameron.Add(filme3);

            //string arrayJson = JsonConvert.SerializeObject(coletaneaJamesCameron);
            //Console.WriteLine("string JSON: ");
            //Console.WriteLine(arrayJson);
            //Console.WriteLine();

            //List<FilmeSimples> filmesSimples = JsonConvert.DeserializeObject<List<FilmeSimples>>(arrayJson);

            //Console.WriteLine("Dados do objeto FilmeSimples: ");
            //foreach (FilmeSimples filmeSimples in filmesSimples)
            //{
            //    Console.WriteLine(filmeSimples);
            //}
            //Console.WriteLine();

            Console.ReadLine();
        }
    }


    class FilmeSimples
    {
        public string Diretor { get; set; }
        public string Titulo { get; set; }

        public override string ToString()
        {
            return Diretor + " - " + Titulo;
        }

        public FilmeSimples(string diretor, string titulo)
        {
            Diretor = diretor;
            Titulo = titulo;
        }
    }
}
