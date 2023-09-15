using Real;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de R$ que você possui para saber quantos dolares valem: ");
            double real = double.Parse(Console.ReadLine());
            double dinheiroConvertidoDol = Moeda.ConverteDol(real);

            Console.WriteLine($"Seus R${real} valem ${dinheiroConvertidoDol} de acordo com a cotação de 14/09/2023.");
                
            Console.WriteLine("Digite o valor de $ que você possui para saber quantos reais valem: ");
            double dol = double.Parse(Console.ReadLine());
            double dinheiroConvertidoReal = Moeda.ConverteReal(dol);

            Console.WriteLine($"Seus ${dol} valem R${dinheiroConvertidoReal} de acordo com a cotação de 14/09/2023.");
        }
    }
}