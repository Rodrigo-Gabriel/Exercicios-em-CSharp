using System;

namespace PessoaApp.Models
{
    class Pessoa
    {
        public string Nome;
        public int Idade;
        public double Altura;
    }

    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}   