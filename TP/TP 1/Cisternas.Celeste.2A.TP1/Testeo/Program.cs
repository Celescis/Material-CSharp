using System;
using Entidades;

namespace Testeo
{
    class Program
    {
        static void Main(string[] args)
        {
            Operando num1 = new Operando(5);
            Operando num2 = new Operando(5);
            //double resultado = Calculadora.Operar(num1, num2, '*');


            Console.WriteLine("rta: {0}", Operando.BinarioDecimal("1010"));
            Console.WriteLine("rta: {0}", Operando.DecimalBinario(5));
        }
    }
}
