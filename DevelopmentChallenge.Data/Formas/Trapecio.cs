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

        public override decimal CalcularArea()
        {
            return ((BaseMayor + BaseMenor) / 2) * Altura;
        }

        /// <summary>
        /// Utilice la formula para calcular el perimetro de un trapecio isósceles
        /// </summary>
        /// <returns></returns>
        public override decimal CalcularPerimetro()
        {
            decimal ladoOblicuo = (decimal)Math.Sqrt(Math.Pow((double)((BaseMayor - BaseMenor) / 2), 2) + Math.Pow((double)Altura, 2));
            return BaseMayor + BaseMenor + 2 * ladoOblicuo;
        }
    }
}
