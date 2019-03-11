using System;

namespace Program03
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta =
                    new ContaCorrente("1235-7", "José da Silva", 100.0m);

                Console.WriteLine(conta);
                Console.WriteLine();

                conta.Sacar(20.0m);

                Console.WriteLine(conta);
                Console.WriteLine();

                conta.Sacar(200.0m);

                Console.WriteLine(conta);
                Console.WriteLine();
            }
            catch   (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }

    public class ContaCorrente
    {
        public string Numero { get; set; }
        public string Titular { get; set; }
        public decimal Saldo { get; private set; }

        public override string ToString()
        {
            return $"Número C/C: {Numero}\nTitular: {Titular}\nSaldo: {Saldo:C}";
        }

        public ContaCorrente(string numero, string titular, decimal saldoInicial)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldoInicial;
        }

        public void Sacar(decimal valor)
        {
            if (valor > Saldo)
            {
                throw new ArgumentException("Saldo insuficiente");
            }

            Saldo -= valor;
        }
    }
}