using NUnit.Framework;
using DesafioSofrecom;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMensaje()
        {
            //Variables de prueba
            string mensaje = "hello world";
            string codigoEsperado = "4433555 555666096667775553";

            string mensaje2 = "foo bar";
            string codigoEsperado2 = "333666 666022 2777";

            MensajeCore mensajeCore = new MensajeCore();

            //Metodo
            var resultado = mensajeCore.SecuenciaByMensaje(mensaje);
            var resultado2 = mensajeCore.SecuenciaByMensaje(mensaje2);

            //Resultado
            Assert.AreEqual(codigoEsperado, resultado);
            Assert.AreEqual(codigoEsperado2, resultado2);
        }
    }
}