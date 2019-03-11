using System;
using System.IO;
using System.Security.Cryptography;

namespace Program06._01
{
    class Program
    {
        static void Main(string[] args)
        {
            //TAREFA : CRIPTOGRAFAR A MENSAGEM ABAIXO

            string mensagemSecreta = "Dados secretos que precisam ser protegidos";

            // 1. array de bytes para manter a mensagem criptografada

            // 2. matriz de bytes para manter a chave usada para criptografia

            // 3. Cria uma instância de Aes
            // Isso cria uma chave aleatória e um vetor de inicialização

            // 3.1. copia a chave

            // 3.2 cria um criptografador para criptografar alguns dados

            // 3.3 Cria um novo fluxo de memória para receber os
            // dados criptografados.

            // 3.4. crie um CryptoStream, diga ao stream para gravar
            // e o encriptador para usar. Também defina o modo

            // 3.5 cria um gravador de fluxo a partir do cryptostream

            // 3.6 Escreva a mensagem secreta para o fluxo.

            // 3.7 obtém a mensagem criptografada do fluxo

            // 4. Exibir o texto, a chave e o texto encriptado


            Console.ReadLine();
        }

        static void ExibirBytes(string titulo, byte[] bytes)
        {
            Console.Write(titulo);
            foreach (byte b in bytes)
            {
                Console.Write("{0:X} ", b);
            }
            Console.WriteLine();
        }
    }
}
