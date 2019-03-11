using System;
using System.Collections.Generic;

namespace Program02._01
{
    class Program
    {
        static void Main(string[] args)
        {
            //TAREFA 1: PRIMEIRO QUE ENTRA, PRIMEIRO QUE SAI (FIFO)

            var veiculo1 = "van";
            var veiculo2 = "kombi";
            var veiculo3 = "guincho";
            var veiculo4 = "pickup";

            Queue<string> pedagio = new Queue<string>();
            pedagio.Enqueue(veiculo1);
            pedagio.Enqueue(veiculo2);
            pedagio.Enqueue(veiculo3);
            pedagio.Enqueue(veiculo4);

            Console.WriteLine(pedagio.Dequeue());
            Console.WriteLine(pedagio.Dequeue());
            Console.WriteLine(pedagio.Dequeue());
            Console.WriteLine(pedagio.Dequeue());
            Console.WriteLine();

            //TAREFA 2: PRIMEIRO QUE ENTRA, ÚLTIMO QUE SAI (LIFO)

            string site0 = "<<vazio>>";
            string site1 = "google.com";
            string site2 = "caelum.com.br";
            string site3 = "alura.com.br";

            Stack<string> historicoNavegador = new Stack<string>();

            historicoNavegador.Push(site0);
            Console.WriteLine("Navegando para: {0}", site1);
            historicoNavegador.Push(site1);
            Console.WriteLine("Navegando para: {0}", site2);
            historicoNavegador.Push(site2);
            Console.WriteLine("Navegando para: {0}", site3);
            historicoNavegador.Push(site3);

            Console.WriteLine("Voltando para: {0}", historicoNavegador.Pop());
            Console.WriteLine("Voltando para: {0}", historicoNavegador.Pop());
            Console.WriteLine("Voltando para: {0}", historicoNavegador.Pop());
            Console.WriteLine("Voltando para: {0}", historicoNavegador.Pop());
            Console.WriteLine();

            //TAREFA 3: UMA COLEÇÃO PODEROSA

            List<string> meses = new List<string>
            {
                "janeiro","fevereiro","março","abril",
                "abril","maio","junho",
                "julho","agosto"
            };

            meses.Add("setembro");
            meses.AddRange(new string[] { "novembro", "dezembro", "onzembro" });

            meses.RemoveAt(4);
            meses.RemoveAt(meses.Count - 1);
            meses.Insert(9, "outubro");

            for (int i = 0; i < meses.Count; i++)
            {
                Console.WriteLine("mês {0}: {1}", i + 1, meses[i]);
            }
            Console.WriteLine();

            meses.Sort((m1, m2) => m1.CompareTo(m2));

            for (int i = 0; i < meses.Count; i++)
            {
                Console.WriteLine("{0}", meses[i]);
            }
            Console.WriteLine();

            //TAREFA 4: MATRIZ DE DADOS DE TAMANHO FIXO

            int[] imagem = new int[65535];

            int x = 31;
            int y = 14;

            const int rgb = 0x9EA3A7;
            imagem[27] = rgb;

            //TAREFA 5: LIGANDO OS NÓS

            LinkedList<string> dias = new LinkedList<string>();
            var d4 = dias.AddFirst("quarta");
            var d2 = dias.AddBefore(d4, "segunda");
            var d3 = dias.AddAfter(d2, "terça");
            var d6 = dias.AddAfter(d4, "sexta");
            var d7 = dias.AddAfter(d6, "sábado");
            var d5 = dias.AddBefore(d6, "quinta");
            var d1 = dias.AddBefore(d2, "domingo");
            foreach (var dia in dias)
            {
                Console.WriteLine(dia);
            }
            Console.WriteLine();

            //TAREFA 6: UNINDO COLEÇÕES SEM DUPLICAÇÃO

            var pares = new List<int> { 0, 2, 4, 6, 8, 10 };
            var impares = new List<int> { 1, 3, 5, 7, 9 };
            var primos = new List<int> { 1, 2, 3, 5, 7 };

            ISet<int> zeroAdez = new HashSet<int>();
            pares.ForEach(n => zeroAdez.Add(n));
            impares.ForEach(n => zeroAdez.Add(n));
            primos.ForEach(n => zeroAdez.Add(n));

            foreach (var n in zeroAdez)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();

            //TAREFA 7: ASSOCIANDO CHAVES E VALORES

            Dictionary<string, string> weekDays = new Dictionary<string, string>
            {
                { "SEG", "Monday" },
                { "TER", "Tuesday" },
                { "QUA", "Wednesday" },
                { "QUI", "Thursday" },
                { "SEX", "Friday" }
            };
            weekDays.Add("SAB", "Saturday");
            weekDays.Add("DOM", "Sunday");

            foreach (var chaveValor in weekDays)
            {
                Console.WriteLine("{0} - {1}", chaveValor.Key, chaveValor.Value);
            }

            Console.ReadLine();
        }
    }
}
