using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosFundamentos.models
{
    public class Calculadora
    {
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Potencia(int num1, int num2)
        {
            return (int)Math.Pow(num1, num2);
        }

        public int Raiz(int num1)
        {
            return (int)Math.Sqrt(num1);
        }

        public double Cosseno(double graus)
        {
            double radianos = graus * (Math.PI / 180);
            return Math.Cos(radianos);
        }

        public double Seno(double graus)
        {
            double radianos = graus * (Math.PI / 180);
            return Math.Sin(radianos);
        }
    }
}