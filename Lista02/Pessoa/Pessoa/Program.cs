using System;

namespace MyApp // Observe que o namespace real pode depender do nome do projeto.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero de pessoas que você deseja adicionar: ");
            int numeroPessoas = int.Parse(Console.ReadLine());
            Pessoa[] pessoas = new Pessoa[numeroPessoas];

            // Loop para adicionar pessoas ao array
            for (int i = 0; i < numeroPessoas; i++)
            {
                Pessoa.AdicionarPessoa(pessoas, i);
            }

            // Imprime informações sobre as pessoas no array
            Pessoa.ImprimirPessoas(pessoas);
        }
    }
}
