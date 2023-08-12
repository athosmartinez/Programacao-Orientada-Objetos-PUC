using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao1
{
    internal class NumeroComplexo
    {
        public double Real { get; set; }
        public double Imaginario { get; set; }

        public NumeroComplexo(double real, double imaginario)
        {
            Real = real;
            Imaginario = imaginario;
        }

        public NumeroComplexo Somar(NumeroComplexo other)
        {
            double soma_real = Real + other.Real;
            double soma_imaginario = Imaginario + other.Imaginario;
            return new NumeroComplexo(soma_real, soma_imaginario);
        }

        public NumeroComplexo Subtrair(NumeroComplexo other)
        {
            double diferenca_real = Real - other.Real;
            double diferenca_imaginario = Imaginario - other.Imaginario;
            return new NumeroComplexo(diferenca_real, diferenca_imaginario);
        }

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
            return $"{Real} {sinal} {Math.Abs(Imaginario)}i";
        }

    }



}
