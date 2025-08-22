using System;

namespace ProjetoCalculadora.Calculadora
{
    public class Calculadora
    {
        public double numero1;
        public double numero2;

        public Calculadora(double n1, double n2)
        {
            numero1 = n1;
            numero2 = n2;
        }

        public double Somar()
        {
            return numero1 + numero2;
        }

        public double Subtrair()
        {
            return numero1 - numero2;
        }

        public double Multiplicar()
        {
            return numero1 * numero2;
        }

        public double Dividir()
        {
            if (numero2 == 0)
            {
                throw new DivideByZeroException("Divisão por zero não é permitida.");
            }
            return numero1 / numero2;
        }

        public double Potencia()
        {
            return Math.Pow(numero1, numero2);
        }

        public double RaizQuadrada()
        {
            if (numero1 < 0)
            {
                throw new ArgumentException("Não é possível calcular a raiz quadrada de um número negativo.");
            }
            return Math.Sqrt(numero1);
        }

        public double Modulo()
        {
            return numero1 % numero2;
        }
    }
}
