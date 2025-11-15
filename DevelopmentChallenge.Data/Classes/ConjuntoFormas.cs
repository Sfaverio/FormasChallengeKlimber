using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class ConjuntoFormas
    {
        private List<Forma> _formas;
        private TipoGeometrico _tipo;

        public ConjuntoFormas(List<Forma> formas, TipoGeometrico tipo)
        {
            _formas = formas;
            _tipo = tipo;
        }

        public InformacionDeFormas ProcesarInformacion()
        {
            decimal areaTotal = 0m;
            decimal perimetroTotal = 0m;
            var formasDelTipo = _formas;

            foreach (var forma in formasDelTipo)
            {
                areaTotal += forma.CalcularArea();
                perimetroTotal += forma.CalcularPerimetro();
            }

            return new InformacionDeFormas
            {
                Tipo = _tipo,
                AreaTotal = areaTotal,
                PerimetroTotal = perimetroTotal,
                Cantidad = formasDelTipo.Count
            };
        }
    
    }
}
