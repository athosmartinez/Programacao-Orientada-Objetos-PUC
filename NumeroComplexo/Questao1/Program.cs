using Questao1; // Importa o namespace Questao1, que contém a classe NumeroComplexo.
using System; // Importa o namespace System, necessário para usar a classe Console.

namespace MyApp // Namespace do aplicativo (pode variar de acordo com o nome do projeto).
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita e lê os valores do primeiro número complexo.
            Console.WriteLine("Digite os valores do primeiro número complexo: ");
            Console.Write("Parte real: ");
            double real1 = double.Parse(Console.ReadLine());
            Console.Write("Parte imaginária: ");
            double imaginario1 = double.Parse(Console.ReadLine());

            // Solicita e lê os valores do segundo número complexo.
            Console.WriteLine("Digite os valores do segundo número complexo: ");
            Console.Write("Parte real: ");
            double real2 = double.Parse(Console.ReadLine());
            Console.Write("Parte imaginária: ");
            double imaginario2 = double.Parse(Console.ReadLine());

            // Cria instâncias de NumeroComplexo usando os valores lidos.
            NumeroComplexo n1 = new NumeroComplexo(real1, imaginario1);
            NumeroComplexo n2 = new NumeroComplexo(real2, imaginario2);

            // Realiza a soma e a diferença dos números complexos.
            NumeroComplexo soma = n1.Somar(n2);
            NumeroComplexo diferenca = n1.Subtrair(n2);

            // Imprime os números complexos e os resultados da operações.
            Console.WriteLine($"1: {n1}");
            Console.WriteLine($"2: {n2}");
            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Diferença: {diferenca}");
        }
    }
}
