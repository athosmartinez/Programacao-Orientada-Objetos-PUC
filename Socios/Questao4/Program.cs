using Questao4;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero de socios que você iria adicionar: ");
            int numerosSocios = int.Parse(Console.ReadLine());

            Socios[] socios = new Socios[numerosSocios];

            for (int i = 0; i < numerosSocios; i++)
            {
                Socios.AdicionarSocio(socios, i);
            }

        }
    }
}