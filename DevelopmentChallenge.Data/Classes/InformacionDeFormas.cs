using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class InformacionDeFormas
    {
        public TipoGeometrico Tipo { get; set; }
        public int Cantidad { get; set; }
        public decimal AreaTotal { get; set; }
        public decimal PerimetroTotal { get; set; }
    }
}
