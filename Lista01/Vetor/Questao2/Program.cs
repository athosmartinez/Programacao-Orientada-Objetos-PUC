using System;
using System.Threading.Channels;
using Questao2; // Importa o namespace Questao2, que contém a classe Vet.

namespace MyApp // Namespace do aplicativo (pode variar de acordo com o nome do projeto).
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho do vetor: ");
            string tam_vetor_string = Console.ReadLine();
            int.TryParse(tam_vetor_string, out int tam_vetor);
            int[] vetor = new int[tam_vetor];

            // Solicita que o usuário preencha o vetor.
            Console.WriteLine("Preencha o vetor nas posições desejadas de 0 a {0}", (tam_vetor - 1));
            Vet.PreencherVetor(vetor, tam_vetor);
            Vet.ImprimirVetor(vetor);

            while (true)
            {
                // Menu de opções para manipular o vetor.
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1. Encontrar valor no vetor");
                Console.WriteLine("2. Verificar se valor está no vetor");
                Console.WriteLine("3. Somar todos elementos do vetor");
                Console.WriteLine("4. Somar elementos pares do vetor");
                Console.WriteLine("5. Somar elementos ímpares do vetor");
                Console.WriteLine("0. Sair");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Vet.FindVetor(vetor);
                        break;
                    case "2":
                        Vet.TemNoVetor(vetor);
                        break;
                    case "3":
                        Vet.SomaElementos(vetor);
                        break;
                    case "4":
                        Vet.SomaPares(vetor);
                        break;
                    case "5":
                        Vet.SomaImpares(vetor);
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