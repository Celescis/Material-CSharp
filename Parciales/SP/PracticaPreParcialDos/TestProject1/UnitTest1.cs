using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1<T,U>
    {
        [TestMethod]
        public void AgregarElemento_Fail()
        {
            Generica<T, U> generica = new Generica<T, U>();

            //Act
            T item = default(T);
            generica.Agregar(item);


            //Assert
            Assert.AreEqual(generica.Lista.Count,1);

        }
    }
}
