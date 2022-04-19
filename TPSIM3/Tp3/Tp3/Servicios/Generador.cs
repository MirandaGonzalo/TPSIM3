using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3.Servicios
{
    public class Generador
    {
        public Int64 valorA { set; get; }

        public Int64 valorB { set; get; }

        public decimal valorMedia { set; get; }

        public Int64 mediaNormal { set; get; }

        public Int64 desviacionNormal { set; get; }


        public decimal generarSerieDistribucionUniformeAB(Generador generador,double numeroRND)
        {
            decimal resta = ((decimal)generador.valorB - (decimal)generador.valorA);

            decimal randomUniformeAbX = valorA + ((decimal)numeroRND * resta);

            var UniformeTrunca = (decimal)(Math.Truncate(randomUniformeAbX * 10000) / 10000);
            
            return UniformeTrunca;

            
        }

        public double generarSerieExponencuialNegativa(Generador generador, double numeroRND)
        {

            //usamos media U(valor promedio de ocurrencia de un evento) en ves de lambda 
            double log = (1 - numeroRND);

            double calculoLog = (Math.Log(log));

            var X = (double)(-generador.valorMedia) * calculoLog;

            var XTrunca = (double)(Math.Truncate(X * 10000) / 10000);
            
            return XTrunca;

            
        }

        public decimal generarNormalN1(Generador gen, double numeroRnd,double numeroRnd2)
        {
            double aux1 = -2 * Math.Log(numeroRnd);

            double aux2 = 2 * 3.1415926535897931 * numeroRnd2;


            var normal = (((decimal)Math.Sqrt(aux1) * (decimal)(Math.Cos(aux2))) * gen.desviacionNormal + gen.mediaNormal);

            var normalTrunca = (decimal)(Math.Truncate(normal * 10000) / 10000);
            return normalTrunca;
        }
        public decimal generarNormalN2(Generador gen, double numeroRnd , double numeroRnd2)
        {
            double aux1 = -2 * Math.Log(numeroRnd);

            double aux2 = 2 * 3.141 * numeroRnd2;


            decimal normal = (((decimal)Math.Sqrt(aux1) * (decimal)(Math.Sin(aux2))) * (decimal)gen.desviacionNormal + (decimal)gen.mediaNormal);

            var normalTrunca = (decimal)(Math.Truncate(normal * 10000) / 10000);
           
            return normalTrunca;
        }

    }
}
