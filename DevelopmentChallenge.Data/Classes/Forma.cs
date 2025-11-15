using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public abstract class Forma: IForma
    {
        public decimal Lado { get; set; }
        public TipoGeometrico Tipo { get; set; }

        public Forma() { }

        public virtual decimal CalcularPerimetro()
        {
            throw new NotImplementedException();
        }

        public virtual decimal CalcularArea()
        {
            throw new NotImplementedException();
        }
    }
}
