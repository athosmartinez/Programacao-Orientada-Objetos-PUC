using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao2
{
    internal class Vet
    {
        public static void PreencherVetor(int[] vetor, int tam_vetor)
        {
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
            if (encontrado == false)
            {
                Console.WriteLine("Valor {0} não encontrado no vetor.", valor);
            }
        }
        public static void FindVetor(int[] vetor)

        {
            Console.WriteLine("Digite de qual posição você quer saber o valor, entre (0 e {0}) ", (vetor.Length - 1));
            string input_find = Console.ReadLine();
            if (int.TryParse(input_find, out int find))
            {
                Console.WriteLine($"O valor da posição {find} é " + vetor[find]);
            }
            else
            {
                Console.WriteLine("Valor inválido. Por favor, digite um número inteiro válido.");
            }
        }

        public static void ImprimirVetor(int[] vetor)
        {
            Console.WriteLine("Vetor preenchido: ");

            foreach (int i in vetor)
            {
                Console.Write($" {i} ");
            }
            Console.WriteLine();
        }


        public static void SomaPares(int[] vetor)
        {
            int soma = 0;
            foreach (int elemento in vetor)
            {
                if (elemento % 2 == 0)
                {
                    soma += elemento;
                }
            }
            Console.WriteLine("Soma total do elementos é: " + soma);
        }

        public static void SomaImpares(int[] vetor)
        {
            int soma = 0;
            foreach (int elemento in vetor)
            {
                if (elemento % 2 != 0)
                {
                    soma += elemento;
                }
            }
            Console.WriteLine("Soma total do elementos é: " + soma);
        }

        public static void SomaElementos(int[] vetor)
        {
            int soma = 0;

            foreach (int elemento in vetor)
            {
                soma += elemento;
            }
            Console.WriteLine("Soma total do elementos é: " + soma);
        }
    }

}

