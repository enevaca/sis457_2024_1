using DemoBiblioteca;

namespace DemoPrueba
{
    [TestClass]
    public class UnitTestCalculadora
    {
        [TestMethod]
        public void TestSuma()
        {
            // Definimos las variables -> Arrange
            int numero1 = 5;
            int numero2 = 7;

            // Ejecutamos la prueba -> Act
            int resultado = Calculadora.sumar(numero1, numero2);

            // Comprobamos los resultados -> Assert
            int resultadoEsperado = 12;
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void TestResta() 
        { 
            int numero1 = 10, numero2 = 7;
            int resultado = Calculadora.restar(numero1, numero2);
            Assert.AreEqual(3, resultado);
        }

        [TestMethod]
        public void TestMultiplicacion() 
        {
            int numero1 = 4, numero2 = 5;
            int resultado = Calculadora.multiplicar(numero1, numero2);
            Assert.AreEqual(20, resultado);
        }

        [TestMethod]
        public void TestDivision()
        {
            int numero1 = 40, numero2 = 8;
            decimal resultado = Calculadora.dividir(numero1, numero2);
            Assert.AreEqual(5, resultado);
        }
    }
}