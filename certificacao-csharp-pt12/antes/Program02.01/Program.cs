using System;
using System.Collections.Generic;

namespace Program02._01
{
    class Program
    {
        static void Main(string[] args)
        {
            //TAREFA 1: PRIMEIRO QUE ENTRA, PRIMEIRO QUE SAI (FIFO)

            //var veiculo1 = "van";
            //var veiculo2 = "kombi";
            //var veiculo3 = "guincho";
            //var veiculo4 = "pickup";

            //TIPO_COLECAO<string> pedagio = new TIPO_COLECAO<string>();
            //pedagio.ADICIONAR(veiculo1);
            //pedagio.ADICIONAR(veiculo2);
            //pedagio.ADICIONAR(veiculo3);
            //pedagio.ADICIONAR(veiculo4);

            //Console.WriteLine(pedagio.REMOVER());
            //Console.WriteLine(pedagio.REMOVER());
            //Console.WriteLine(pedagio.REMOVER());
            //Console.WriteLine(pedagio.REMOVER());
            //Console.WriteLine();

            //TAREFA 2: PRIMEIRO QUE ENTRA, ÚLTIMO QUE SAI (LIFO)

            //string site0 = "<<vazio>>";
            //string site1 = "google.com";
            //string site2 = "caelum.com.br";
            //string site3 = "alura.com.br";

            //TIPO_COLECAO<string> historicoNavegador = new TIPO_COLECAO<string>();

            //historicoNavegador.INCLUIR(site0);
            //Console.WriteLine("Navegando para: {0}", site1);
            //historicoNavegador.INCLUIR(site1);
            //Console.WriteLine("Navegando para: {0}", site2);
            //historicoNavegador.INCLUIR(site2);
            //Console.WriteLine("Navegando para: {0}", site3);
            //historicoNavegador.INCLUIR(site3);

            //Console.WriteLine("Voltando para: {0}", historicoNavegador.REMOVER());
            //Console.WriteLine("Voltando para: {0}", historicoNavegador.REMOVER());
            //Console.WriteLine("Voltando para: {0}", historicoNavegador.REMOVER());
            //Console.WriteLine("Voltando para: {0}", historicoNavegador.REMOVER());
            //Console.WriteLine();

            //TAREFA 3: UMA COLEÇÃO PODEROSA

            //TIPO_COLECAO<string> meses = new TIPO_COLECAO<string>
            //{
            //    "janeiro","fevereiro","março","abril",
            //    "abril","maio","junho",
            //    "julho","agosto"             
            //};

            //meses.INCLUIR("setembro");
            //meses.INCLUIR_FAIXA(new string[] { "novembro", "dezembro", "onzembro" });

            //meses.REMOVER_NO_INDICE(4);
            //meses.REMOVER_NO_INDICE(meses.Count - 1);
            //meses.INCLUIR(9, "outubro");

            //for (int i = 0; i < meses.Count; i++)
            //{
            //    Console.WriteLine("mês {0}: {1}", i + 1, meses[i]);
            //}
            //Console.WriteLine();

            //meses.Sort((m1, m2) => m1.CompareTo(m2));

            //for (int i = 0; i < meses.Count; i++)
            //{
            //    Console.WriteLine("{0}", meses[i]);
            //}
            //Console.WriteLine();

            //TAREFA 4: MATRIZ DE DADOS DE TAMANHO FIXO

            //TIPO_COLECAO imagem = new TIPO_COLECAO[65535];

            //int x = 31;
            //int y = 14;

            //const int rgb = 0x9EA3A7;
            //imagem.ITEM_NA_POSICAO(27) = rgb;

            //TAREFA 5: LIGANDO OS NÓS

            //TIPO_COLECAO<string> dias = new TIPO_COLECAO<string>();
            //var d4 = dias.ADICIONAR_PRIMEIRO("quarta");
            //var d2 = dias.ADICIONAR_ANTES_DE(d4, "segunda");
            //var d3 = dias.ADICIONAR_DEPOIS_DE(d2, "terça");
            //var d6 = dias.ADICIONAR_DEPOIS_DE(d4, "sexta");
            //var d7 = dias.ADICIONAR_DEPOIS_DE(d6, "sábado");
            //var d5 = dias.ADICIONAR_ANTES_DE(d6, "quinta");
            //var d1 = dias.ADICIONAR_ANTES_DE(d2, "domingo");
            //foreach (var dia in dias)
            //{
            //    Console.WriteLine(dia);
            //}
            //Console.WriteLine();

            //TAREFA 6: UNINDO COLEÇÕES SEM DUPLICAÇÃO

            //var pares = new List<int> { 0, 2, 4, 6, 8, 10 };
            //var impares = new List<int> { 1, 3, 5, 7, 9 };
            //var primos = new List<int> { 1, 3, 5, 7, 9 };

            //TIPO_COLECAO<int> zeroAdez = new TIPO_COLECAO<int>();
            //pares.ForEach(n => zeroAdez.INCLUIR(n));
            //impares.ForEach(n => zeroAdez.INCLUIR(n));
            //primos.ForEach(n => zeroAdez.INCLUIR(n));

            //foreach (var n in zeroAdez)
            //{
            //    Console.WriteLine(n);
            //}
            //Console.WriteLine();

            //TAREFA 6: ASSOCIANDO CHAVES E VALORES

            //TIPO_COLECAO<string, string> weekDays = new TIPO_COLECAO<string, string>
            //{
            //    { "SEG", "Monday" },
            //    { "TER", "Tuesday" },
            //    { "QUA", "Wednesday" },
            //    { "QUI", "Thursday" },
            //    { "SEX", "Friday" }
            //};
            //weekDays.Add("SAB", "Saturday");
            //weekDays.Add("DOM", "Sunday");

            //foreach (var chaveValor in weekDays)
            //{
            //    Console.WriteLine("{0} - {1}", chaveValor.Key, chaveValor.Value);
            //}

            Console.ReadLine();
        }
    }
}
