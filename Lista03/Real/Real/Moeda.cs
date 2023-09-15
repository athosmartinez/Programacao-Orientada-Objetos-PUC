using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real
{
    internal class Moeda
    {
        public static double ConverteDol(double dinheiro)
        {
            double valorConvertido = dinheiro / 4.87;
            double valorConvertidoArredondado = Math.Round(valorConvertido, 2);
            return valorConvertidoArredondado;
        }

        public static double ConverteReal(double dinheiro)
        {
            double valorConvertido = dinheiro * 4.87;
            double valorConvertidoArredondado = Math.Round(valorConvertido, 2);
            return valorConvertidoArredondado;
        }
    }
}
