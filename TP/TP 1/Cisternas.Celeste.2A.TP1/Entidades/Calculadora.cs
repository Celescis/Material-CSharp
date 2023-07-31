using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        private static char ValidarOperador(char operador)
        {
            char result = '+';
            if (operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                result = operador;
            }
            return result;
        }

        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double result = 0;
            char op = ValidarOperador(operador);
            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                default:
                    result = num1 + num2;
                    break;
            }
            return result;
        }
    }
}
