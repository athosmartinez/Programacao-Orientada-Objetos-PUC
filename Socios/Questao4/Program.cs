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
            Console.WriteLine("Deseja remover algum socio (S/N) ");
            if (Console.ReadLine().ToUpper() == "S")
            {
                Console.WriteLine("Digite o numero da cota do socio que voce deseja excluir");
                int numeroCota = int.Parse(Console.ReadLine());
                Socios.RemoverSocio(numeroCota, socios);
            }
            else if (Console.ReadLine().ToUpper() == "N")
            {
                Console.WriteLine("Ok, vamos continuar");
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }
            Console.WriteLine("Abaixo estão todos os socios e seus dependetes: ");
            Socios.ImprimirSociosEDependentes(socios);
        }
    }
}