using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void AgregarElemento_Ok()
        {
            Generica<Persona, int> generica = new Generica<Persona, int>();
            Persona persona = new Persona();

            //Act
            generica.Agregar(persona);


            //Assert
            Assert.AreEqual(generica.Lista.Count, 1);

        }

        [TestMethod]
        public void QuitarElemento_Ok()
        {
            //Arrange
            Generica<Persona, int> generica = new Generica<Persona, int>();
            Persona persona = new Persona();
            generica.Agregar(persona);

            //Act
            generica.Remover(persona);

            //Assert
            Assert.IsFalse(generica.Lista.Contains(persona));

        }


    }
}
