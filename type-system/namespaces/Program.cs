using System; // Importa o namespace System, que contém classes básicas como Console.

namespace MyApplication // Declaração do namespace MyApplication.
{
    // A classe Program está dentro do namespace MyApplication.
    class Program
    {
        static void Main(string[] args)
        {
            // Chama o método WriteLine da classe Console para imprimir "Hello, World!".
            Console.WriteLine("Hello, World!");
        }
    }
}

namespace MyApplication.Utilities // Declaração do namespace MyApplication.Utilities.
{
    // A classe Utility está dentro do namespace MyApplication.Utilities.
    class Utility
    {
        // Método estático que imprime uma mensagem no console.
        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}