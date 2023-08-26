using Banco; // Importa o namespace "Banco".
using System; // Importa o namespace "System", que contém classes e métodos fundamentais.

namespace MyApp // Define o namespace "MyApp" para o programa.
{
    internal class Program // Declara uma classe chamada "Program".
    {
        static void Main(string[] args) // O método principal do programa.
        {

            Console.WriteLine("Digite o número de clientes que irá ser adicionados: "); // Exibe uma mensagem no console.

            int nClientes = int.Parse(Console.ReadLine()); // Lê e converte a entrada do usuário em um número inteiro.
            Clientes[] clientes = new Clientes[nClientes]; // Cria um array de objetos da classe "Clientes".
            for (int i = 0; i < nClientes; i++) // Inicia um loop para adicionar clientes ao array.
            {
                Clientes.AdicionarCliente(clientes, i); // Chama o método "AdicionarCliente" da classe "Clientes".
            }

            Clientes.ImprimirClientes(clientes); // Chama o método "ImprimirClientes" da classe "Clientes" para exibir os clientes.

        }
    }
}