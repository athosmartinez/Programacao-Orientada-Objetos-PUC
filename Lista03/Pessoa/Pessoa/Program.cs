using System;
using Pessoa;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pessoa.ClassPessoas[] pessoas = new Pessoa.ClassPessoas[2];
            Console.WriteLine("Digite o nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o sexo: ");
            string sexo = Console.ReadLine();
            Console.WriteLine("Digite o peso: ");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura: ");
            double altura = double.Parse(Console.ReadLine());
            pessoas[0] = new ClassPessoas(nome, sexo, peso, altura);
            double IMC = pessoas[0].IMC();
            Console.WriteLine($"{IMC}");


            Console.WriteLine("Digite o nome: ");
            string nome2 = Console.ReadLine();
            Console.WriteLine("Digite o sexo: ");
            string sexo2 = Console.ReadLine();
            Console.WriteLine("Digite o peso: ");
            double peso2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura: ");
            double altura2 = double.Parse(Console.ReadLine());
            pessoas[1] = new ClassPessoas();
            pessoas[1].setNome(nome2);
            pessoas[1].setSexo(sexo2);
            pessoas[1].setPeso(peso2);
            pessoas[1].setPeso(altura2);

            double IMC2 = pessoas[1].IMC();
            
            Console.WriteLine("");

        }
        }
    }
