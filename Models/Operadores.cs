using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Operadores.Models
{
    public class Operacao
    {
        public double Somar(double x, double y)
        {
            double resultado = x + y;
            Console.WriteLine($"{x} + {y} = {resultado}");
            return resultado;
        }

        public double Subtrair(double x, double y)
        {
            double resultado = x - y;
            Console.WriteLine($"{x} - {y} = {resultado}");
            return resultado;
        }

        public double Multiplicacao(double x, double y)
        {
            double resultado = x * y;
            Console.WriteLine($"{x} X {y} = {resultado}");
            return resultado;
        }

        public double Divisao(double x, double y)
        {
            double resultado = x / y;
            Console.WriteLine($"{x} / {y} = {resultado}");
            return resultado;
        }

        public double Potencia(double x, double y)
        {
            double resultado = Math.Pow(x, y);
            Console.WriteLine($"{x} elevado a {y} = {resultado}");
            return resultado;
        }

        public double RaizQuadrada(double x)
        {
            double resultado = Math.Sqrt(x);
            Console.WriteLine($"A raiz quadrada de {x} é {resultado}");
            return resultado;
        }
    }
}