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

        public override decimal CalcularArea()
        {
            return (decimal)(Math.Sqrt(3) / 4) * Lado * Lado;
        }
        public override decimal CalcularPerimetro()
        {
            return 3 * Lado;
        }
    }
}
