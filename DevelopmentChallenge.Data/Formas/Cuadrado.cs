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

        public override decimal CalcularArea()
        {
            return Lado * Lado;
        }

        public override decimal CalcularPerimetro()
        {
            return 4 * Lado;
        }
    }
}
