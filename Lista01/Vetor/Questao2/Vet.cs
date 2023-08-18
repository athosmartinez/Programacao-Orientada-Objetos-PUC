using System;

namespace Questao2
{
    internal class Vet
    {
        public static void PreencherVetor(int[] vetor, int tam_vetor)
        {
            // Preenche um vetor com valores fornecidos pelo usuário.
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite a posição desejada (0 a {0}) ou -1 para encerrar: ", (tam_vetor - 1));
                string input_posicao = Console.ReadLine();
                if (int.TryParse(input_posicao, out int posicao))
                {
                    if (posicao < 0 || posicao >= vetor.Length)
                    {
                        Console.WriteLine("Posição inválida. Digite uma posição entre 0 e {0} ou -1 para encerrar.", (tam_vetor - 1));
                        i--;
                    }
                    else if (posicao == -1)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Digite o valor para a posição {0}: ", posicao);
                        string input_valor = Console.ReadLine();

                        if (int.TryParse(input_valor, out int valor))
                        {
                            vetor[posicao] = valor;
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido. Por favor, digite um número inteiro válido.");
                            i--;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Digite uma posição entre 0 e {0} ou -1 para encerrar.", (tam_vetor - 1));
                    i--;
                }
            }
        }

        public static void TemNoVetor(int[] vetor)
        {
            // Procura por um valor no vetor e informa a posição, se encontrado.
            bool encontrado = false;
            int posicao = 0;
            Console.WriteLine("Digite o valor que você deseja encontrar no vetor: ");
            string input_valor = Console.ReadLine();
            if (int.TryParse(input_valor, out int valor))
            {
                foreach (int valores in vetor)
                {
                    if (valores == valor)
                    {
                        Console.WriteLine("Valor {0} encontrado na posição {1}.", valor, posicao);
                        encontrado = true;
                    }
                    posicao++;
                }
            }
            else
            {
                Console.WriteLine("Valor inválido. Por favor, digite um número inteiro válido.");
            }
            if (!encontrado)
            {
                Console.WriteLine("Valor {0} não encontrado no vetor.", valor);
            }
        }

        public static void FindVetor(int[] vetor)
        {
            // Exibe o valor presente em uma determinada posição do vetor.
            Console.WriteLine("Digite a posição que você quer saber o valor, entre (0 e {0}) ", (vetor.Length - 1));
            string input_find = Console.ReadLine();
            if (int.TryParse(input_find, out int find))
            {
                if (find >= 0 && find < vetor.Length)
                {
                    Console.WriteLine($"O valor da posição {find} é " + vetor[find]);
                }
                else
                {
                    Console.WriteLine("Posição inválida. Digite uma posição entre 0 e {0}.", (vetor.Length - 1));
                }
            }
            else
            {
                Console.WriteLine("Valor inválido. Por favor, digite um número inteiro válido.");
            }
        }

        public static void ImprimirVetor(int[] vetor)
        {
            // Imprime os elementos presentes no vetor.
            Console.WriteLine("Vetor preenchido: ");

            foreach (int i in vetor)
            {
                Console.Write($" {i} ");
            }
            Console.WriteLine();
        }

        public static void SomaPares(int[] vetor)
        {
            // Calcula a soma dos elementos pares do vetor.
            int soma = 0;
            foreach (int elemento in vetor)
            {
                if (elemento % 2 == 0)
                {
                    soma += elemento;
                }
            }
            Console.WriteLine("Soma total dos elementos pares é: " + soma);
        }

        public static void SomaImpares(int[] vetor)
        {
            // Calcula a soma dos elementos ímpares do vetor.
            int soma = 0;
            foreach (int elemento in vetor)
            {
                if (elemento % 2 != 0)
                {
                    soma += elemento;
                }
            }
            Console.WriteLine("Soma total dos elementos ímpares é: " + soma);
        }

        public static void SomaElementos(int[] vetor)
        {
            // Calcula a soma de todos os elementos do vetor.
            int soma = 0;
            foreach (int elemento in vetor)
            {
                soma += elemento;
            }
            Console.WriteLine("Soma total dos elementos é: " + soma);
        }
    }
}
