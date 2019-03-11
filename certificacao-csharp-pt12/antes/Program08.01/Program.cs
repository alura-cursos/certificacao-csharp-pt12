using System;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Text;
using System.IO;

namespace Program08._01
{
    class Program
    {
        static void Main(string[] args)
        {
            //BOB PRECISA ENVIAR ESTA MENSAGEM A ALICE
            string textoOriginal = "Mensagem secreta do Bob";
            Console.WriteLine("Mensagem: {0}", textoOriginal);
            Console.WriteLine();

            Mensagem mensagem = GetMensagemAssinada(textoOriginal);

            //TAREFA: VALIDAR A ASSINATURA DA MENSAGEM
            //========================================


            Console.ReadKey();
        }

        public class Mensagem
        {
            public Mensagem(string texto)
            {
                Texto = texto;
            }

            public Mensagem(string texto, byte[] assinatura) : this(texto)
            {
                Assinatura = assinatura;
            }

            public string Texto { get; set; }
            public byte[] Assinatura { get; set; }

            public override string ToString()
            {
                return Texto;
            }
        }

        private static bool Validar(Mensagem mensagem)
        {
            bool assinaturaValida = false;

            var mensagemASerAssinadaBytes = GetMensagemBytes(mensagem.Texto);
            byte[] hash = GetHash(mensagemASerAssinadaBytes);

            var certificate = GetCertificado();
            //Obtém um decodificador a partir da chave privada
            RSA decriptadorRSA = certificate.GetRSAPublicKey();

            // Agora use a assinatura para executar uma validação bem-sucedida da mensagem
            assinaturaValida = decriptadorRSA.VerifyHash(hash, mensagem.Assinatura, HashAlgorithmName.SHA1, RSASignaturePadding.Pkcs1);
            return assinaturaValida;
        }

        private static Mensagem GetMensagemAssinada(string mensagemASerAssinada)
        {
            X509Certificate2 certificate = GetCertificado();

            byte[] assinatura = GetAssinatura(mensagemASerAssinada, certificate);

            return new Mensagem(mensagemASerAssinada, assinatura);
        }

        private static X509Certificate2 GetCertificado()
        {
            // Converte a string de entrada em bytes, e vice-versa
            ASCIIEncoding converter = new ASCIIEncoding();

            // Obtém um provider de criptografia a partir do store de certificados
            X509Store store = new X509Store("MeuStore", StoreLocation.CurrentUser);

            //Abre o store de certificado
            store.Open(OpenFlags.ReadOnly);

            //Obtém o primeiro certificado
            X509Certificate2 certificate = store.Certificates[0];
            return certificate;
        }

        private static byte[] GetAssinatura(string mensagemASerAssinada, X509Certificate2 certificate)
        {
            //Obtém um encriptador a partir da chave privada chave privada
            RSA encriptadorRSA = certificate.GetRSAPrivateKey();

            byte[] mensagemASerAssinadaBytes = GetMensagemBytes(mensagemASerAssinada);
            byte[] hash = GetHash(mensagemASerAssinadaBytes);

            // Assina o hash para criar a assinatura
            byte[] assinatura = encriptadorRSA.SignHash(hash, HashAlgorithmName.SHA1, RSASignaturePadding.Pkcs1);
            ExibirBytes("Assinatura: ", mensagemASerAssinadaBytes);
            return assinatura;
        }

        private static byte[] GetMensagemBytes(string mensagemASerAssinada)
        {
            ASCIIEncoding converter = new ASCIIEncoding();
            byte[] mensagemASerAssinadaBytes = converter.GetBytes(mensagemASerAssinada);
            ExibirBytes("Mensagem a ser assinada, em bytes: ", mensagemASerAssinadaBytes);
            return mensagemASerAssinadaBytes;
        }

        private static byte[] GetHash(byte[] mensagemASerAssinadaBytes)
        {
            //Você precisa calcular um hash para essa mensagem
            //- isso entrará na assinatura e será usado para verificar a mensagem

            //Crie uma implementação do agoritmo hashing que vamos usar
            HashAlgorithm hasher = new SHA1Managed();

            // Utiliza o hasher para "hashear" a mensagem
            byte[] hash = hasher.ComputeHash(mensagemASerAssinadaBytes);
            ExibirBytes("Hash para a mensagem: ", hash);
            return hash;
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
