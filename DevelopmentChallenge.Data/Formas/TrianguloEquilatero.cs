using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Resources;

namespace DevelopmentChallenge.Data.Formas
{
    public class TrianguloEquilatero: Forma
    {
        public TrianguloEquilatero(decimal lado)
        {
            Lado = lado;
            Tipo = TipoGeometrico.TrianguloEquilatero;
        }

        /// <summary>
        /// Calcula el área de un triángulo equilátero.
        /// Utiliza la fórmula: Área = (Raiz de 3 / 4) * Lado * Lado
        /// </summary>
        public override decimal CalcularArea()
        {
            return (decimal)(Math.Sqrt(3) / 4) * Lado * Lado;
        }

        /// <summary>
        /// Calcula el perímetro de un triángulo equilátero.
        /// Utiliza la formula: Perímetro = 3 * Lado
        /// </summary>
        public override decimal CalcularPerimetro()
        {
            return 3 * Lado;
        }
    }
}
