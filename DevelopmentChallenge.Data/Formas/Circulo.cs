using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevelopmentChallenge.Data.Resources;

namespace DevelopmentChallenge.Data.Classes
{
    public class Circulo: Forma
    {
        public Circulo(decimal lado)
        {
            Lado = lado;
            Tipo = TipoGeometrico.Circulo;
        }

        /// <summary>
        /// Calcula el area del círculo.
        /// Utiliza la formula : Area = PI * r^2, donde r es el radio (lado / 2).
        /// </summary>
        public override decimal CalcularArea()
        {
            decimal radio = Lado / 2m;
            return (decimal)Math.PI * radio * radio;
        }

        /// <summary>
        /// Calcula el perímetro del círculo.
        /// Utiliza la fórmula: Perímetro = PI * diámetro (lado).
        /// </summary>
        public override decimal CalcularPerimetro()
        {
            return (decimal)(Math.PI * (double)Lado);
        }
    }
}
