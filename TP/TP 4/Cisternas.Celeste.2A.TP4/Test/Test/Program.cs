using Entidades;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Wiki wiki = new Wiki();
            //LECTURA ARCHIVO TXT
            Wiki wikiTXT = new Wiki();
            //LECTURA BASE DE DATOS
            //wiki = JugadorAccesoDatos.Leer();
            Inventario inventario1 = new Inventario();
            Inventario inventario2 = new Inventario();
            //CAPACIDAD = 20

            Cubo cubo1 = new Cubo(ETipoMaterial.Diamante, 2);
            Cubo cubo2 = new Cubo(ETipoMaterial.Diamante, 2);
            Cubo cubo3 = new Cubo(ETipoMaterial.Madera, 3);
            Cubo cubo4 = new Cubo(ETipoMaterial.Piedra, 2);
            Cubo cubo5 = new Cubo(ETipoMaterial.Madera, 2);
            Cubo cubo6 = new Cubo(ETipoMaterial.Diamante, 6);

            Herramienta tool1 = new Herramienta(ETipoHerramienta.Espada, ETipoMaterial.Diamante, 6);
            Herramienta tool2 = new Herramienta(ETipoHerramienta.Hacha, ETipoMaterial.Diamante, 2);
            Herramienta tool3 = new Herramienta(ETipoHerramienta.Espada, ETipoMaterial.Piedra, 4);
            Herramienta tool4 = new Herramienta(ETipoHerramienta.Espada, ETipoMaterial.Madera, 1);
            Herramienta tool5 = new Herramienta(ETipoHerramienta.Pico, ETipoMaterial.Diamante, 1);
            Herramienta tool6 = new Herramienta(ETipoHerramienta.Pico, ETipoMaterial.Madera, 3);

            //INVENTARIO1
            inventario1.AgregarElemento(cubo4);//I 18 2 piedra
            inventario1.AgregarElemento(cubo5);//I 16 2 madera
            inventario1.AgregarElemento(cubo6);//I 10 6 diamante

            inventario1.AgregarElemento(tool1);//I 10 -> espada 6 diamante Y BAJAR A 0 DIAMANTE
            inventario1.AgregarElemento(tool2);//I 10 -> hacha 2 diamante NO DEBERIA AGREGARSE
            inventario1.AgregarElemento(tool3);//I 10 -> espada 4 piedra DEBERIAN AGREGARSE 2 Y BAJAR A 0 PIEDRA
            inventario1.AgregarElemento(tool4);//I 10 -> espada 1 madera DEBERIAN AGREGARSE 1 Y BAJAR A 1 MADERA

            Console.WriteLine("INVENTARIO 1");
            Console.WriteLine(inventario1.ToString());

            //INVENTARIO2
            inventario2.AgregarElemento(cubo1);//I 18 2 diamante
            inventario2.AgregarElemento(cubo2);//I 16 2 diamante
            inventario2.AgregarElemento(cubo3);//I 13 3 madera

            inventario2.AgregarElemento(tool5);//I 13 -> pico 1 diamante DEBERIA BAJAR A 3 DIAMANTE
            inventario2.AgregarElemento(tool6);//I 13 -> pico 3 madera DEBERIA BAJAR A 0 MADERA

            Console.WriteLine("INVENTARIO 2");
            Console.WriteLine(inventario2.ToString());

            Jugador j1 = new Jugador(1,"Celeste", inventario1);
            Jugador j2 = new Jugador(2,"Gerito", inventario1);
            Jugador j3 = new Jugador(3,"Kira", inventario2);
            Jugador j4 = new Jugador(4,"P1p0", inventario2);
            bool isNew;

            wiki += j1;
            wiki += j2;
            wiki += j3;
            wiki += j4;

            if (wiki.GetJugador(j1.Usuario, out isNew) is not null)
            {
                Console.WriteLine($"{j1.Usuario} se encuentra en la lista, es nuevo?: {isNew}");
            }
            if (wiki.GetJugador(j2.Usuario, out isNew) is not null)
            {
                Console.WriteLine($"{j2.Usuario} se encuentra en la lista, es nuevo?: {isNew}");
            }

            if (inventario1.Capacidad == 20)
            {
                Console.WriteLine("No se agrego nada");
            }
            else
            {
                Console.WriteLine($"Se agregaron, nueva capacidad inventario de {j1.Usuario} es: {j1.Inventario.Capacidad}");
                //Console.WriteLine($"Cantidad cubos: {inventario.CantidadCubos}");
                //Console.WriteLine($"Cantidad herramientas: {inventario.CantidadHerramientas}");
                Console.WriteLine($"Se agregaron, nueva capacidad inventario de {j3.Usuario} es: {j3.Inventario.Capacidad}");
                //Console.WriteLine($"Cantidad cubos: {inventarioUno.CantidadCubos}");
                //Console.WriteLine($"Cantidad herramientas: {inventarioUno.CantidadHerramientas}");
            }

            //MUESTRA LOS JUGADORES CON SUS INVENTARIOS
            Console.WriteLine(wiki.Mostrar());

            //ARCHIVOS TXT
            Archivos.GuardarTxt(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\TXT.txt", wiki);
            Archivos.LeerTxt(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\TXT.txt", out wikiTXT);

            Console.WriteLine("LECTURA ARCHIVO TXT:\n");
            Console.WriteLine(wikiTXT.Mostrar());

            //ARCHIVOS XML
            Archivos.SerializarXml(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\XML.xml", wiki);
            wiki = Archivos.DeserializarXml(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\XML.xml");
        }
    }
}
