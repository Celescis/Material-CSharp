using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        #region ATRIBUTOS
        private double numero;
        #endregion ATRIBUTOS

        #region CONSTRUCTORES
        /// <summary>
        /// Constructor por defecto, inicializa en cero
        /// </summary>
        public Operando() : this(0)
        { }
        /// <summary>
        /// Constructor que recibe un double
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero) : this(numero.ToString())
        { }
        /// <summary>
        /// Constructor que recibe un string
        /// </summary>
        /// <param name="strNumero"></param> string
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }
        #endregion CONSTRUCTORES

        #region SOBRECARGA
        /// <summary>
        /// Calculo entre dos numeros de tipo suma
        /// </summary>
        /// <param name="num1"></param> recibe un numero de tipo Operando
        /// <param name="num2"></param> recibe un numero de tipo Operando
        /// <returns></returns> retorna el calculo entre los dos numeros
        public static double operator + (Operando num1, Operando num2)
        {
            return num1.numero + num2.numero;
        }
        /// <summary>
        /// Calculo entre dos numeros de tipo resta
        /// </summary>
        /// <param name="num1"></param> recibe un numero de tipo Operando
        /// <param name="num2"></param> recibe un numero de tipo Operando
        /// <returns></returns> retorna el calculo entre los dos numeros
        public static double operator - (Operando num1, Operando num2)
        {
            return num1.numero - num2.numero;
        }
        /// <summary>
        /// Calculo entre dos numeros de tipo division
        /// </summary>
        /// <param name="num1"></param> recibe un numero de tipo Operando
        /// <param name="num2"></param> recibe un numero de tipo Operando
        /// <returns></returns> retorna el calculo entre los dos numeros
        public static double operator / (Operando num1, Operando num2)
        {
            double result;

            if (num2.numero==0)
            {
                result = double.MinValue;
            }
            else
            {
                result = num1.numero / num2.numero;
            }

            return result;
        }
        /// <summary>
        /// Calculo entre dos numeros de tipo multiplicacion
        /// </summary>
        /// <param name="num1"></param> recibe un numero de tipo Operando
        /// <param name="num2"></param> recibe un numero de tipo Operando
        /// <returns></returns> retorna el calculo entre los dos numeros
        public static double operator * (Operando num1, Operando num2)
        {
            return num1.numero * num2.numero;
        }
        #endregion SOBRECARGA

        #region METODOS
        /// <summary>
        /// Comprobará que el valor recibido sea numérico
        /// </summary>
        /// <param name="strNumero"></param> string
        /// <returns></returns> retorna el valor recibido en formato double o en caso contrario retorna cero
        private double ValidarOperando(string strNumero)
        {
            double num;

            if (!double.TryParse(strNumero, out num))
            {
                num = 0;
            }

            return num;
        }
        /// <summary>
        /// Validará que la cadena de caracteres esté compuesta solamente por caracteres '0' o '1'.
        /// </summary>
        /// <param name="binario"></param> string
        /// <returns></returns> retorna verdadero o falso si es binario.
        private static bool EsBinario(string binario)
        {
            bool result = true;

            foreach (char c in binario)
            {
                if (c != '0' && c != '1')
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
        /// <summary>
        /// Convertira un numero binario a decimal, primero validará que se trate de un binario y luego lo convertirá
        /// </summary>
        /// <param name="binario"></param>string
        /// <returns></returns> Retornara un string que contiene el valor decimal en caso de ser posible. Caso contrario retornará "Valor inválido
        public static string BinarioDecimal(string binario)
        {
            string result = "Valor inválido";
            int num;

            if (Operando.EsBinario(binario))
            {
                num = Convert.ToInt32(binario, 2);
                if (num > 0)
                {
                    result = num.ToString();
                }
            }

            return result;
        }
        /// <summary>
        /// Método que convertira un número decimal a binario 
        /// </summary>
        /// <param name="numero"></param> double
        /// <returns></returns> retornará un string que contiene el valor binario en caso de ser posible. Caso contrario retornará "Valor inválido".
        public static string DecimalBinario(double numero)
        {
            return DecimalBinario(numero.ToString());
        }
        /// <summary>
        /// Método que convertira un número decimal a binario 
        /// </summary>
        /// <param name="numero"></param> string
        /// <returns></returns> retornará un string que contiene el valor binario en caso de ser posible. Caso contrario retornará "Valor inválido".
        public static string DecimalBinario(string numero)
        {
            int num;
            string result = "Valor inválido";

            if(int.TryParse(numero,out num))
            {
                if(num>0)
                {
                    result = Convert.ToString(num, 2);
                }
            }

            return result;
        }
        #endregion METODOS

        #region PROPIEDAD
        /// <summary>
        /// Propiedad que asignará un valor al atributo número con previa validación
        /// </summary>
        private string Numero
        {
            set
            {
                this.numero = this.ValidarOperando(value);
            }
        }
        #endregion PROPIEDAD

    }
}
