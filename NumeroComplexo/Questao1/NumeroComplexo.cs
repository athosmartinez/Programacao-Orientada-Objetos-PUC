using System; // Importa o namespace System, necessário para usar a classe Math.

namespace Questao1 // Namespace para a classe NumeroComplexo.
{
    internal class NumeroComplexo
    {
        public double Real { get; set; } // Propriedade para a parte real do número complexo.
        public double Imaginario { get; set; } // Propriedade para a parte imaginária do número complexo.

        // Construtor da classe NumeroComplexo.
        public NumeroComplexo(double real, double imaginario)
        {
            Real = real;
            Imaginario = imaginario;
        }

        // Método para realizar a soma de dois números complexos.
        public NumeroComplexo Somar(NumeroComplexo other)
        {
            double soma_real = Real + other.Real;
            double soma_imaginario = Imaginario + other.Imaginario;
            return new NumeroComplexo(soma_real, soma_imaginario);
        }

        // Método para realizar a subtração de dois números complexos.
        public NumeroComplexo Subtrair(NumeroComplexo other)
        {
            double diferenca_real = Real - other.Real;
            double diferenca_imaginario = Imaginario - other.Imaginario;
            return new NumeroComplexo(diferenca_real, diferenca_imaginario);
        }

        // Sobrescreve o método ToString para formatar a representação do número complexo.
        public override string ToString()
        {
            string sinal = "";
            if (Imaginario < 0)
            {
                sinal = "-";
            }
            else if (Imaginario > 0)
            {
                sinal = "+";
            }
            return $"{Real} {sinal} {Math.Abs(Imaginario)}i"; // Formatação da representação.
        }

    }
}