using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Operadores.Models
{
    public class Operacao
    {
        public void Somar(double x, double y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

         public void Subtrair(double x, double y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
         public void Multiplicacao(double x, double y)
        {
            Console.WriteLine($"{x} X {y} = {x * y}");
        }
         public void Divisao(double x, double y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }
    }
}