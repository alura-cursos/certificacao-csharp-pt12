using System;
using System.IO;
using System.Xml.Serialization;

namespace Program01_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Filme filme = new Filme(diretor: "Tim Burton",
                titulo: "A Fantástica Fábrica de Chocolate",
                duracaoMinutos: 115);
            XmlSerializer serializador = new XmlSerializer(typeof(Filme));

            TextWriter writer = new StringWriter();
            serializador.Serialize(textWriter: writer, o: filme);
            writer.Close();

            string xml = writer.ToString();

            Console.WriteLine();
            Console.WriteLine("Versão XML:");
            Console.WriteLine(xml);

            TextReader reader = new StringReader(xml);

            Filme filme2 = serializador.Deserialize(reader) as Filme;

            Console.WriteLine();
            Console.WriteLine("Dados do objeto Filme: ");
            Console.WriteLine(filme2);

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