using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValidationCredictCard;

namespace UnitTestPrueba
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TarjetaValida()
        {
            var validacion = new Validacion();
            var resultado = validacion.validar("4012888888881881");
            Assert.AreEqual(true, resultado);
        }


        [TestMethod]
        public void TarjetaNoValida()
        {
            var validacion = new Validacion();
            var resultado = validacion.validar("4012888888881882");
            Assert.AreEqual(false, resultado);
        }
    }
}
