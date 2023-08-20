using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Pessoa
{
    // Propriedades da classe Pessoa
    string Nome { get; set; }
    float Altura { get; set; }
    DateOnly Nascimento { get; set; }

    // Construtor da classe Pessoa
    public Pessoa(string nome, float altura, DateOnly nascimento)
    {
        Nome = nome;
        Altura = altura;
        Nascimento = nascimento;
    }

    // Método estático para adicionar uma pessoa a um array de pessoas
    public static void AdicionarPessoa(Pessoa[] pessoas, int n)
    {
        Console.WriteLine("Digite o nome da pessoa: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite a altura da pessoa: ");
        float altura = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite sua data de nascimento (DD/MM/YYYY): ");
        DateOnly nascimento = DateOnly.Parse(Console.ReadLine());
        pessoas[n] = new Pessoa(nome, altura, nascimento);
    }

    // Método estático para imprimir informações sobre as pessoas no array
    public static void ImprimirPessoas(Pessoa[] pessoas)
    {
        foreach (var pessoa in pessoas)
        {
            Console.WriteLine($"Pessoas - Nome: {pessoa.Nome}, idade: {pessoa.CalcularIdade()}, altura: {pessoa.Altura}. É de maior? ({pessoa.EMaiorIdade()})");
        }
    }

    // Método para calcular a idade da pessoa
    public int CalcularIdade()
    {
        DateTime hoje = DateTime.Now;
        int idade = hoje.Year - Nascimento.Year;
        return idade;
    }

    // Método para verificar se a pessoa é maior de idade
    public bool EMaiorIdade()
    {
        int idade = CalcularIdade();
        if (idade >= 18)
        {
            Console.WriteLine("É maior de idade");
            return true;
        }
        else
        {
            Console.WriteLine("É menor de idade");
            return false;
        }
    }
}
