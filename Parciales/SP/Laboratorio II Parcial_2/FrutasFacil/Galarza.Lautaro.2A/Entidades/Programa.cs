using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Programa
    {
        public void Main(string[] args)
        {

            Cajon<Fruta> cajon = new Cajon<Fruta>(10, 15);
            Cajon<Platano> cajonPlatano = new Cajon<Platano>(10, 15);



            Manzana m1 = new Manzana(2, ConsoleColor.Red, "Pozo");
            Manzana m2 = new Manzana(3, ConsoleColor.Red, "Pizi");
            Platano p1 = new Platano(4, ConsoleColor.Yellow, "Ecuador");
            Platano p2 = new Platano(5, ConsoleColor.Yellow, "Argentina");


            cajon += m1;
            cajon += p1;
            cajon += m2;
            cajon += p2;
            cajonPlatano += p1;
            cajonPlatano += p2;

            cajonPlatano.ImprimirTicket(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Cajon.txt");
            Console.WriteLine(cajon.ToString());
            this.Serializar(cajon);
            this.Deserializar(cajon);



        }

        private bool Deserializar(ISerializable obj)
        {
            return obj.DeserializarXML();
        }

        private bool Serializar(ISerializable obj)
        {
            return obj.SerializarXML();
        }
    }
}

