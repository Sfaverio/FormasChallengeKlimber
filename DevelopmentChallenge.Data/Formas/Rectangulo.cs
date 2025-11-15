using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevelopmentChallenge.Data.Classes;

namespace DevelopmentChallenge.Data.Formas
{
    public class Rectangulo : Forma
    {
        public decimal Alto { get; set; }

        public Rectangulo(decimal lado, decimal alto)
        {
            Lado = lado;
            Tipo = TipoGeometrico.Rectangulo;
            Alto = alto;
        }

        public override decimal CalcularArea()
        {
            return Lado * Alto;
        }

        public override decimal CalcularPerimetro()
        {
            return 2 * (Lado + Alto);
        }

    }
}
