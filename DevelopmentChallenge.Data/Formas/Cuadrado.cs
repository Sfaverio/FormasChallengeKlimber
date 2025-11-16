using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevelopmentChallenge.Data.Resources;

namespace DevelopmentChallenge.Data.Classes
{
    public class Cuadrado: Forma
    {
        public Cuadrado(decimal lado)
        {
            Lado = lado;
            Tipo = TipoGeometrico.Cuadrado;
        }

        /// <summary>
        /// Calcula el área del cuadrado.
        /// Utiliza la formula: Área = lado * lado.
        /// </summary>
        public override decimal CalcularArea()
        {
            return Lado * Lado;
        }

        /// <summary>
        /// Calcula el perimetro del cuadrado.
        /// Utiliza la fórmula: Perímetro = 4 * lado.
        /// </summary>
        public override decimal CalcularPerimetro()
        {
            return 4 * Lado;
        }
    }
}
