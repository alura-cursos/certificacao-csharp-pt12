using System;
using System.Security.Cryptography;
using System.Text;

namespace Program07._02
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensagemOriginal = "Dados secretos que precisam ser protegidos";
            string mensagemDecodificada = "";

            //TAREFA: ALICE PRECISA ENVIAR UMA MENSAGEM SECRETA PARA BOB.
            //IMPLEMENTE O CÓDIGO NECESSÁRIO UTILIZANDO A CLASSE PESSOA ABAIXO.

            Pessoa alice = new Pessoa("Alice");
            Pessoa bob = new Pessoa("Bob");

            string chavePublicaDoBob = bob.ChavePublica;
            var bytesCodificados = alice.CodificarMensagem(mensagemOriginal, chavePublicaDoBob);

            mensagemDecodificada = bob.DecodificarMensagem(bytesCodificados);

            Console.WriteLine("string decifrada: {0}", mensagemDecodificada);

            Console.ReadLine();
        }

        public class Pessoa
        {
            private readonly string nome;
            private readonly string chavePrivada;

            public string ChavePublica { get; }

            public Pessoa(string nome)
            {
                this.nome = nome;

                // Cria um novo RSA para criptografar os dados

                CspParameters cspParameters = new CspParameters();
                cspParameters.KeyContainerName = "MeuContainer";

                //TAREFA: REINICIAR AS CHAVES ASSIMÉTRICAS
                RSACryptoServiceProvider encriptadorRSA = new RSACryptoServiceProvider(cspParameters);

                // pega as chaves do criptografador
                ChavePublica = encriptadorRSA.ToXmlString(includePrivateParameters: false);
                chavePrivada = encriptadorRSA.ToXmlString(includePrivateParameters: true);

                Console.WriteLine(new string('=', 100));
                Console.WriteLine("Dados do usuário: {0}", nome);
                Console.WriteLine(new string('=', 100));
                Console.WriteLine("Chave privada de {0}: {1}", nome, chavePrivada);
                Console.WriteLine("Chave pública de {0}: {1}", nome, ChavePublica);
                Console.WriteLine(new string('=', 100));
                Console.WriteLine();
            }


            public byte[] CodificarMensagem(string mensagemOriginal, string chavePublicaDestinatario)
            {
                byte[] bytesCifrados;

                //TAREFA : CRIPTOGRAFAR A MENSAGEM ABAIXO
                //USANDO O PADRÃO RSA (RIVEST-SHAMIR-ADLEMAN) ASSIMÉTRICO

                Console.WriteLine("Mensagem original: {0}", mensagemOriginal);
                Console.WriteLine();

                // RSA funciona em matrizes de bytes, não em cadeias de texto
                // Isso irá converter nossa string de entrada em bytes e de volta
                ASCIIEncoding conversor = new ASCIIEncoding();

                // Converte a mensagem original em uma array de bytes
                byte[] mensagemBytes = conversor.GetBytes(mensagemOriginal);

                ExibirBytes("Bytes da mensagem original: ", mensagemBytes);

                // Cria um novo RSA para criptografar os dados

                //TAREFA: ARMAZENAR A CHAVE PRIVADA COM SEGURANÇA
                CspParameters cspParameters = new CspParameters();
                cspParameters.KeyContainerName = "MeuContainer";
                RSACryptoServiceProvider encriptadorRSA = new RSACryptoServiceProvider(cspParameters);

                // Agora diga ao encriptador para usar a chave pública para criptografar os dados
                encriptadorRSA.FromXmlString(chavePublicaDestinatario);

                // Use o criptografador para criptografar os dados. O parâmetro fOAEP
                // especifica como a saída é "preenchida" com bytes extras
                // Para compatibilidade máxima com sistemas de recebimento, defina como
                // false
                bytesCifrados = encriptadorRSA.Encrypt(mensagemBytes, fOAEP: false);

                ExibirBytes("Bytes encriptados: ", bytesCifrados);
                return bytesCifrados;
            }

            public string DecodificarMensagem(byte[] bytesCifrados)
            {
                //TAREFA : DESCRIPTOGRAFAR A MENSAGEM ABAIXO
                //USANDO O PADRÃO RSA (RIVEST-SHAMIR-ADLEMAN) ASSIMÉTRICO
                byte[] bytesDecifrados;

                // Cria um novo RSA para descriptografar os dados
                RSACryptoServiceProvider decifradorRSA = new RSACryptoServiceProvider();

                // Configura o decodificador a partir do XML na chave privada
                decifradorRSA.FromXmlString(chavePrivada);

                // Configurar o decryptor do XML na chave privada decifradorRSA.FromXmlString(chavePrivada);
                bytesDecifrados = decifradorRSA.Decrypt(bytesCifrados, fOAEP: false);

                ExibirBytes("Bytes decifrados: ", bytesDecifrados);

                ASCIIEncoding conversor2 = new ASCIIEncoding();
                return conversor2.GetString(bytesDecifrados);
            }

            void ExibirBytes(string titulo, byte[] bytes)
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
}
