/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using DevelopmentChallenge.Data.Resources;

namespace DevelopmentChallenge.Data.Classes
{
    /// <summary>
    /// Genera un reporte de formas geométricas.
    /// </summary>
    public class GeneradorReporteFormas
    {
        private List<Forma> _formas;

        public GeneradorReporteFormas(List<Forma> formas, CultureInfo culture = null)
        {
            Message.Culture = culture ?? CultureInfo.InvariantCulture;
            _formas = formas;
        }

        public string Imprimir()
        {
            var sb = new StringBuilder();

            if (!_formas.Any())
            {
                sb.Append(Message.ListaVacia);
                return sb.ToString();
            }

            sb.Append(Message.ReporteFormasTitulo);

            List<ConjuntoFormas> formasPorTipo = _formas
                .GroupBy(f => f.Tipo)
                .Select(f =>
                {
                    return new ConjuntoFormas(f.ToList(), f.Key);
                })
                .ToList();

            var informacionDeFormas = formasPorTipo
                .Select(c => c.ProcesarInformacion())
                .ToList();

            var totalDeFormas = informacionDeFormas.Sum(i => i.Cantidad);
            var perimetroTotal = informacionDeFormas.Sum(i => i.PerimetroTotal).ToString("#.##");
            var areaTotal = informacionDeFormas.Sum(i => i.AreaTotal).ToString("#.##");

            foreach (var informacion in informacionDeFormas)
            {
                sb.Append(ObtenerLinea(informacion));
            }

            var textoForma = totalDeFormas == 1 ? Message.Forma : Message.Formas;

            // FOOTER
            sb.Append("TOTAL:<br/>");
            sb.Append($"{totalDeFormas} {textoForma} ");
            sb.Append($"{Message.Perimetro} {perimetroTotal} ");
            sb.Append($"{Message.Area} {areaTotal}");

            return sb.ToString();
        }

        private static string ObtenerLinea(InformacionDeFormas informacion)
        {
            if (informacion.Cantidad > 0)
            {
                var tipo = informacion.Tipo.ToString();
                var tipoTraducido = informacion.Cantidad == 1 ? Message.ResourceManager.GetString(tipo, Message.Culture) : Message.ResourceManager.GetString(tipo + "s", Message.Culture);
                return $"{informacion.Cantidad} {tipoTraducido} | {Message.Area} {informacion.AreaTotal:#.##} | {Message.Perimetro} {informacion.PerimetroTotal:#.##} <br/>";
            }

            return string.Empty;
        }
    }
}
