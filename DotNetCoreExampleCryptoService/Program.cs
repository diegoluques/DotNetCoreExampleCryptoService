using System;

namespace DotNetCoreExampleCryptoService
{
    static class Program
    {
        static void Main(string[] _)
        {
            while (true)
            {
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("Informe o dado para criptografar: ");

                var original = Console.ReadLine();
                var dadoCriptogrado = AesCripto.Encript(original);
                var dadoDescriptografado = AesCripto.Decript(dadoCriptogrado);

                Console.WriteLine("Original: {0}", original);
                Console.WriteLine("");
                Console.WriteLine($"Criptografado: {dadoCriptogrado}");
                Console.WriteLine($"Descriptografado: {dadoDescriptografado}");
                Console.WriteLine("");

                Console.WriteLine("-----------------------------------------------------------");
                var sair = Console.ReadLine();
                if (sair == "x")
                    break;
            }
        }
    }
}