using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3.Servicios
{
    public  class Registro
    {
        public decimal Desde { get; set; }
        public decimal Hasta { get; set; }
        public decimal MarcaClase { get; set; }
        public decimal FrecuenciaObservada { get; set; }
        public decimal FrecuenciaEsperada { get; set; }
        public decimal FrecuenciaRelativa { get; set; }
        public decimal EstadisticoMuestra { get; set; }
        public decimal ProbabilidadEsperada { get; set; }
        public decimal EstadisticoMuestraAcumulado { get; set; }
        //Les puse este nombre pq son los que aparecen en el Excel xd
        public decimal ProbabilidadObservada { get; set; }
    }



}
