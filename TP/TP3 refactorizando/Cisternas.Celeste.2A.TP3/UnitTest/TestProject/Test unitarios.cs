using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestClass]
    public class Test_unitarios
    {
        /// <summary>
        /// Prueba de pasarle un nombre de usuario y que busque si se encuentra en la lista de jugadores, de no estar, crea uno nuevo con ese usuario
        /// </summary>
        [TestMethod]
        public void GetJugador_CuandoEncuentraElNombreONo_DeberiaRetornarElJugadorOUnoNuevo()
        {
            //Arrange
            Wiki lista = new Wiki();
            string usuario = "celeste22";
            Jugador player = new Jugador(1, usuario);
            lista.Jugadores.Add(player);
            Jugador jugadorRecibido;
            bool isNew;


            //Act
            jugadorRecibido = lista.GetJugador(usuario, out isNew);

            //Assert
            Assert.AreEqual(usuario, jugadorRecibido.Usuario);//compara el nombre entregado al metodo con el nombre del jugador que devuelve el metodo
            Assert.IsTrue(isNew);//si es true si el jugador es nuevo
        }

        /// <summary>
        /// Prueba que se agregue un cubo o herramienta al inventario
        /// </summary>
        [TestMethod]
        public void AgregarElemento_RecibeUnElemento_DeberiaAgregarseAlInventario()
        {
            //Arrange
            Inventario inv = new Inventario();
            Cubo cubo = new Cubo(ETipoMaterial.Madera, 1);
            Herramienta tool = new Herramienta(ETipoHerramienta.Espada, ETipoMaterial.Madera, 1);

            //Assert
            Assert.IsTrue(inv.AgregarElemento(cubo));
            Assert.IsTrue(inv.AgregarElemento(tool));
        }
    }
}
