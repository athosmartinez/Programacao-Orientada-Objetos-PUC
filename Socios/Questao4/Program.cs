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

            while (true)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1. Apagar algum socio");
                Console.WriteLine("2. Listar socios e dependentes");
                Console.WriteLine("0. Sair");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Digite o numero da cota do socio que voce deseja excluir");
                        int numeroCota = int.Parse(Console.ReadLine());
                        Socios.RemoverSocio(numeroCota, socios);

                        break;
                    case "2":
                        Console.WriteLine("Abaixo estão todos os socios e seus dependetes: ");
                        Socios.ImprimirSociosEDependentes(socios);
                        break;
                    case "0":
                        Console.WriteLine("Encerrando o programa...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Escolha uma opção válida.");
                        break;
                }
            }
        }
    }
}