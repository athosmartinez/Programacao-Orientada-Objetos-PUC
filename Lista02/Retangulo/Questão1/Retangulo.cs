using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Questão1
{
    internal class Retangulo
    {
        public double baseRetangulo { get; set; }
        public double altura { get; set; }

        // Construtor padrão da classe Retangulo.
        public Retangulo()
        {
            // Este construtor não realiza nenhuma ação específica ao ser chamado.
        }

        // Construtor sobrecarregado da classe Retangulo que permite definir base e altura ao criar uma instância.
        public Retangulo(double baseRetangulo, double altura)
        {
            this.baseRetangulo = baseRetangulo;
            this.altura = altura;
        }

        // Método para calcular o perímetro do retângulo.
        public double CalcularPerimetro()
        {
            return 2 * (baseRetangulo + altura);
        }

        // Método para calcular a área do retângulo.
        public double CalcularArea()
        {
            return baseRetangulo * altura;
        }

        // Método para calcular a diagonal do retângulo usando o teorema de Pitágoras.
        public double CalcularDiagonal()
        {
            return Math.Sqrt(baseRetangulo * baseRetangulo + altura * altura);
        }
    }
}
