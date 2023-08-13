using Questao1;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite os valores do primeiro número complexo: ");
            Console.Write("Parte real: ");
            double real1 = double.Parse(Console.ReadLine());
            Console.Write("Parte imaginária: ");
            double imaginario1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite os valores do segundo número complexo: ");
            Console.Write("Parte real: ");
            double real2 = double.Parse(Console.ReadLine());
            Console.Write("Parte imaginária: ");
            double imaginario2 = double.Parse(Console.ReadLine());

            NumeroComplexo n1 = new NumeroComplexo(real1, imaginario1);
            NumeroComplexo n2 = new NumeroComplexo(real2, imaginario2);

            NumeroComplexo soma = n1.Somar(n2);
            NumeroComplexo diferenca = n1.Subtrair(n2);

            Console.WriteLine($"1: {n1}");
            Console.WriteLine($"2: {n2}");
            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Diferença: {diferenca}");
        }
    }
}