using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa
{
    internal class ClassPessoas
    {
        private string nome { get; set; }
        private string sexo { get; set; }
        private double peso { get; set; }
        private double altura { get; set; }

        public ClassPessoas(string nome, string sexo, double peso, double altura)
        {
            this.nome = nome;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
        }

        public ClassPessoas()
        {

        }

        public string getNome()
        {
            return this.nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getSexo()
        {
            return this.sexo;
        }

        public void setSexo(string sexo)
        {
            this.sexo = sexo;
        }

        public double getPeso()
        {
            return this.peso;
        }

        public void setPeso(double peso)
        {
            this.peso = peso;
        }
        public double getAltura()
        {
            return this.altura;
        }

        public void setAltura(double altura)
        {
            this.altura = altura;
        }

        public double IMC()
        {
            double IMCa = this.peso / Math.Pow(this.altura, 2) * 10000;
            double IMCd = Math.Round(IMCa, 2);
            return IMCa;
        }
    }
}
