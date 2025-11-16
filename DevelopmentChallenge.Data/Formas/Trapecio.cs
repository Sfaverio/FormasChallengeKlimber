using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevelopmentChallenge.Data.Resources;

namespace DevelopmentChallenge.Data.Classes
{
    public class Trapecio: Forma
    {
        public decimal BaseMayor { get; set; }
        public decimal BaseMenor { get; set; }
        public decimal Altura { get; set; }

        public Trapecio(decimal baseMayor, decimal baseMenor, decimal altura)
        {
            BaseMayor = baseMayor;
            BaseMenor = baseMenor;
            Altura = altura;
            Tipo = TipoGeometrico.Trapecio;
        }

        /// <summary>
        /// Calcula el área de un trapecio isósceles.
        /// Utiliza la fórmula: Área = ((BaseMayor + BaseMenor) / 2) * Altura
        /// </summary>
        public override decimal CalcularArea()
        {
            return ((BaseMayor + BaseMenor) / 2) * Altura;
        }

        /// <summary>
        /// Calcula el perímetro de un trapecio isósceles.
        /// Utiliza la fórmula: Perímetro = BaseMayor + BaseMenor + 2 * LadoOblicuo
        /// </summary>
        public override decimal CalcularPerimetro()
        {
            decimal ladoOblicuo = (decimal)Math.Sqrt(Math.Pow((double)((BaseMayor - BaseMenor) / 2), 2) + Math.Pow((double)Altura, 2));
            return BaseMayor + BaseMenor + 2 * ladoOblicuo;
        }
    }
}
