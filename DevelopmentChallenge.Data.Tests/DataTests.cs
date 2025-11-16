using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Formas;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase("es", "<h1>Lista vacía de formas!</h1>")]
        [TestCase("en", "<h1>Empty list of shapes!</h1>")]
        [TestCase("it", "<h1>Elenco vuoto di moduli!</h1>")]
        public void TestResumenListaVacia(string idioma, string resultadoEsperado)
        {
            var generadorReporteFormas = new GeneradorReporteFormas(new List<Forma>(), new System.Globalization.CultureInfo(idioma));
            var reporte = generadorReporteFormas.Imprimir();

            Assert.AreEqual(resultadoEsperado, reporte);
        }

        [TestCase("es", "<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 forma Perimetro 20 Area 25")]
        [TestCase("en", "<h1>Shapes Report</h1>1 Square | Area 25 | Perimeter 20 <br/>TOTAL:<br/>1 shape Perimeter 20 Area 25")]
        [TestCase("it", "<h1>Rapporto sulle forme</h1>1 Quadrato | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 forma Perimetro 20 Area 25")]
        public void TestResumenListaConUnCuadrado(string idioma, string resultadoEsperado)
        {
            var cuadrados = new List<Forma> {new Cuadrado(5)};
            var generadorReporteFormas = new GeneradorReporteFormas(cuadrados, new System.Globalization.CultureInfo(idioma));
            var resumen = generadorReporteFormas.Imprimir();

            Assert.AreEqual(resultadoEsperado, resumen);
        }

        [TestCase("es", "<h1>Reporte de Formas</h1>3 Cuadrados | Area 35 | Perimetro 36 <br/>TOTAL:<br/>3 formas Perimetro 36 Area 35")]
        [TestCase("en", "<h1>Shapes Report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35")]
        [TestCase("it", "<h1>Rapporto sulle forme</h1>3 Quadrati | Area 35 | Perimetro 36 <br/>TOTAL:<br/>3 forme Perimetro 36 Area 35")]
        public void TestResumenListaConMasCuadrados(string idioma, string resultadoEsperado)
        {
            var cuadrados = new List<Forma>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var generadorReporteFormas = new GeneradorReporteFormas(cuadrados, new System.Globalization.CultureInfo(idioma));
            var resumen = generadorReporteFormas.Imprimir();

            Assert.AreEqual(resultadoEsperado, resumen);
        }

        [TestCase("es", "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Circulos | Area 13,01 | Perimetro 18,06 <br/>3 Triangulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65")]
        [TestCase("en", "<h1>Shapes Report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65")]
        [TestCase("it", "<h1>Rapporto sulle forme</h1>2 Quadrati | Area 29 | Perimetro 28 <br/>2 Cerchi | Area 13,01 | Perimetro 18,06 <br/>3 Triangoli | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 forme Perimetro 97,66 Area 91,65")]
        public void TestResumenListaConMasTipos(string idioma, string resultadoEsperado)
        {
            var formas = new List<Forma>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var generadorReporteFormas = new GeneradorReporteFormas(formas, new System.Globalization.CultureInfo(idioma));

            var resumen = generadorReporteFormas.Imprimir();

            Assert.AreEqual(resultadoEsperado, resumen);
        }
    
        
        [TestCase("es", "<h1>Reporte de Formas</h1>1 Rectangulo | Area 20 | Perimetro 18 <br/>TOTAL:<br/>1 forma Perimetro 18 Area 20")]
        [TestCase("en", "<h1>Shapes Report</h1>1 Rectangle | Area 20 | Perimeter 18 <br/>TOTAL:<br/>1 shape Perimeter 18 Area 20")]
        [TestCase("it", "<h1>Rapporto sulle forme</h1>1 Rettangolo | Area 20 | Perimetro 18 <br/>TOTAL:<br/>1 forma Perimetro 18 Area 20")]
        public void TestResumenListaConUnRectangulo(string idioma, string resultadoEsperado)
        {
            var rectangulos = new List<Forma> { new Rectangulo(5, 4) };
            var generadorReporteFormas = new GeneradorReporteFormas(rectangulos, new System.Globalization.CultureInfo(idioma));
            var resumen = generadorReporteFormas.Imprimir();
            Assert.AreEqual(resultadoEsperado, resumen);
        }

        // Tests para Trapecio
        [TestCase("es", "<h1>Reporte de Formas</h1>1 Trapecio | Area 16 | Perimetro 16,25 <br/>TOTAL:<br/>1 forma Perimetro 16,25 Area 16")]
        [TestCase("en", "<h1>Shapes Report</h1>1 Trapeze | Area 16 | Perimeter 16,25 <br/>TOTAL:<br/>1 shape Perimeter 16,25 Area 16")]
        [TestCase("it", "<h1>Rapporto sulle forme</h1>1 Trapezio | Area 16 | Perimetro 16,25 <br/>TOTAL:<br/>1 forma Perimetro 16,25 Area 16")]
        public void TestResumenListaConUnTrapecio(string idioma, string resultadoEsperado)
        {
            var trapecios = new List<Forma> { new Trapecio(5, 3, 4) };
            var generadorReporteFormas = new GeneradorReporteFormas(trapecios, new System.Globalization.CultureInfo(idioma));
            var resumen = generadorReporteFormas.Imprimir();
            Assert.AreEqual(resultadoEsperado, resumen);
        }

        // Tests unitarios para cálculos
        [Test]
        public void TestCuadradoCalcularArea()
        {
            var cuadrado = new Cuadrado(5);
            Assert.AreEqual(25m, cuadrado.CalcularArea());
        }

        [Test]
        public void TestCuadradoCalcularPerimetro()
        {
            var cuadrado = new Cuadrado(5);
            Assert.AreEqual(20m, cuadrado.CalcularPerimetro());
        }

        [Test]
        public void TestRectanguloCalcularArea()
        {
            var rectangulo = new Rectangulo(5, 4);
            Assert.AreEqual(20m, rectangulo.CalcularArea());
        }

        [Test]
        public void TestRectanguloCalcularPerimetro()
        {
            var rectangulo = new Rectangulo(5, 4);
            Assert.AreEqual(18m, rectangulo.CalcularPerimetro());
        }

        [Test]
        public void TestTrapecioCalcularArea()
        {
            var trapecio = new Trapecio(5, 3, 4);
            Assert.AreEqual(16m, trapecio.CalcularArea()); // ((5+3)/2)*4 = 16
        }

        [Test]
        public void TestResumenListaConTodasLasFormas()
        {
            var formas = new List<Forma> 
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Rectangulo(5, 4),
                new Trapecio(5, 3, 4)
            };

            var generadorReporteFormas = new GeneradorReporteFormas(formas, new System.Globalization.CultureInfo("es"));
            var resumen = generadorReporteFormas.Imprimir();
            Assert.IsTrue(resumen.Contains("Cuadrado"));
            Assert.IsTrue(resumen.Contains("Circulo"));
            Assert.IsTrue(resumen.Contains("Triangulo"));
            Assert.IsTrue(resumen.Contains("Rectangulo"));
            Assert.IsTrue(resumen.Contains("Trapecio"));
        }

        [Test]
        public void TestResumenConCulturaNull()
        {
            var formas = new List<Forma> { new Cuadrado(5) };
            var generadorReporteFormas = new GeneradorReporteFormas(formas, null);
            var resumen = generadorReporteFormas.Imprimir();
            Assert.IsNotNull(resumen);
        }
    }
}
