using System; // Importa o namespace "System".

namespace Banco // Define o namespace "Banco" para a classe "Clientes".
{
    internal class Clientes // Declara uma classe chamada "Clientes".
    {
        public string Nome { get; set; } // Propriedade que representa o nome do cliente.
        public int codigoCliente { get; set; } // Propriedade que representa o código do cliente.

        public Clientes() { } // Construtor padrão da classe "Clientes".

        public Clientes(string nome, int codigoCliente) // Construtor que aceita nome e código do cliente como parâmetros.
        {
            Nome = nome; // Inicializa a propriedade "Nome" com o valor passado como parâmetro.
            this.codigoCliente = codigoCliente; // Inicializa a propriedade "codigoCliente" com o valor passado como parâmetro.
        }

        public static void AdicionarCliente(Clientes[] clientes, int n) // Método estático para adicionar um cliente ao array.
        {
            Console.WriteLine("Digite o nome do cliente: "); // Exibe uma mensagem no console.
            string nome = Console.ReadLine(); // Lê o nome do cliente a partir da entrada do usuário.
            Console.WriteLine("Digte o código do cliente: "); // Exibe uma mensagem no console.
            int codigoCliente = int.Parse(Console.ReadLine()); // Lê e converte o código do cliente a partir da entrada do usuário.

            clientes[n] = new Clientes(nome, codigoCliente); // Cria um novo objeto "Clientes" e o adiciona ao array.
        }

        public static void ImprimirClientes(Clientes[] clientes) // Método estático para imprimir informações sobre os clientes.
        {
            foreach (var cliente in clientes)
            { // Inicia um loop para cada cliente no array.
                Console.WriteLine($"Cliente - Nome: {cliente.Nome} - Código cliente: {cliente.codigoCliente}"); // Exibe informações sobre o cliente no console.
            }
        }
    }
}