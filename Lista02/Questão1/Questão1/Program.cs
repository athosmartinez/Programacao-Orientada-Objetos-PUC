using Questão1;  // Esta linha importa o namespace Questão1, permitindo o uso das classes desse namespace no código.

using System;
using System.Security.Cryptography;

namespace MyApp // Define o namespace da aplicação.
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            Retangulo retangulo1 = new Retangulo(); // Cria uma instância da classe Retangulo chamada retangulo1.
            Retangulo retangulo2 = new Retangulo(); // Cria uma instância da classe Retangulo chamada retangulo2.
            Retangulo retangulo3 = new Retangulo(); // Cria uma instância da classe Retangulo chamada retangulo3.

            // Solicita ao usuário a entrada da altura e da base do primeiro retângulo.
            Console.WriteLine("Digite a altura do primeiro retangulo: ");
            float a1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a base do premeiro retanugulo: ");
            float b1 = float.Parse(Console.ReadLine());
            retangulo1.altura = a1; // Define a altura do retângulo1 com o valor inserido pelo usuário.
            retangulo1.baseRetangulo = b1; // Define a base do retângulo1 com o valor inserido pelo usuário.

            // Solicita ao usuário a entrada da altura e da base do segundo retângulo.
            Console.WriteLine("Digite a altura do segundo retangulo: ");
            float a2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a base do segundo retanugulo: ");
            float b2 = float.Parse(Console.ReadLine());
            retangulo2.altura = a2; // Define a altura do retângulo2 com o valor inserido pelo usuário.
            retangulo2.baseRetangulo = b2; // Define a base do retângulo2 com o valor inserido pelo usuário.

            // Solicita ao usuário a entrada da altura e da base do terceiro retângulo.
            Console.WriteLine("Digite a altura do terceiro retangulo: ");
            float a3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a base do terceiro retanugulo: ");
            float b3 = float.Parse(Console.ReadLine());
            retangulo3.altura = a3; // Define a altura do retângulo3 com o valor inserido pelo usuário.
            retangulo3.baseRetangulo = b3; // Define a base do retângulo3 com o valor inserido pelo usuário.

            // Imprime informações sobre o Retângulo 1
            Console.WriteLine("Retangulo 1:");
            Console.WriteLine($"Perímetro: {retangulo1.CalcularPerimetro()}"); // Calcula e imprime o perímetro do retângulo1.
            Console.WriteLine($"Área: {retangulo1.CalcularArea()}"); // Calcula e imprime a área do retângulo1.
            Console.WriteLine($"Diagonal: {retangulo1.CalcularDiagonal()}"); // Calcula e imprime a diagonal do retângulo1.
            Console.WriteLine();

            // Imprime informações sobre o Retângulo 2
            Console.WriteLine("Retangulo 2:");
            Console.WriteLine($"Perímetro: {retangulo2.CalcularPerimetro()}"); // Calcula e imprime o perímetro do retângulo2.
            Console.WriteLine($"Área: {retangulo2.CalcularArea()}"); // Calcula e imprime a área do retângulo2.
            Console.WriteLine($"Diagonal: {retangulo2.CalcularDiagonal()}"); // Calcula e imprime a diagonal do retângulo2.
            Console.WriteLine();

            // Imprime informações sobre o Retângulo 3
            Console.WriteLine("Retangulo 3:");
            Console.WriteLine($"Perímetro: {retangulo3.CalcularPerimetro()}"); // Calcula e imprime o perímetro do retângulo3.
            Console.WriteLine($"Área: {retangulo3.CalcularArea()}"); // Calcula e imprime a área do retângulo3.
            Console.WriteLine($"Diagonal: {retangulo3.CalcularDiagonal()}"); // Calcula e imprime a diagonal do retângulo3.
        }
    }
}
