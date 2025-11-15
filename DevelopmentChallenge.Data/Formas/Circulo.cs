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

        public override decimal CalcularArea()
        {
            decimal radio = Lado / 2m;
            return (decimal)Math.PI * radio * radio;
        }

        public override decimal CalcularPerimetro()
        {
            return (decimal)(Math.PI * (double)Lado);
        }
    }
}
