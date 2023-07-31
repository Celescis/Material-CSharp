using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 8";
            //8.Por teclado se ingresa el valor hora, el nombre, la antigüedad(en años) y la cantidad de horas
            //trabajadas en el mes de N empleados de una fábrica.
            //Se pide calcular el importe a cobrar teniendo en cuenta que el total(que resulta de multiplicar el
            //valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados
            //multiplicados por $ 150, y al total de todas esas operaciones restarle el 13 % en concepto de
            //descuentos.
            //Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en
            //bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados.
            //Nota: Utilizar estructuras repetitivas y selectivas.

            float valorHora;
            string nombre;
            int antiguedad;
            int horas;
            float totalBruto;
            float totalDescuentos;
            float totalNeto;
            string seguir;
            do
            {
                Console.WriteLine("Nombre de empleado: ");//como validar que sean letras
                nombre = Console.ReadLine();

                Console.WriteLine("Horas trabajadas: ");
                while (!int.TryParse(Console.ReadLine(), out horas) || horas < 0)
                {
                    Console.WriteLine("Error, ingrese las horas trabajadas: ");
                }

                Console.WriteLine("Antiguedad en años: ");
                while (!int.TryParse(Console.ReadLine(), out antiguedad) || antiguedad < 0)
                {
                    Console.WriteLine("Error, ingrese la antiguedad en años: ");
                }

                Console.WriteLine("Valor por hora: ");
                while (!float.TryParse(Console.ReadLine(), out valorHora) || valorHora < 0)
                {
                    Console.WriteLine("Error, ingrese el valor por hora: ");
                }

                totalBruto = (float)((valorHora * horas) + (antiguedad * 150));
                totalDescuentos = (float)(totalBruto * 13 / 100);
                totalNeto = totalBruto - totalDescuentos;

                Console.WriteLine("Nombre: {0} \nAntiguedad: {1} \nValor por hora: {2} \nTotal bruto: {3:C2} \nTotal descuentos: {4:C2} \nTotal neto: {5:C2}", nombre, antiguedad, valorHora, totalBruto, totalDescuentos, totalNeto);
                Console.WriteLine("Desea ingresar otro empleado? s/n");
                seguir = Console.ReadLine();
            } while (seguir=="s");


            Console.ReadKey();
        }
    }
}
