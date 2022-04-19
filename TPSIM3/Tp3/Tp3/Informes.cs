using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tp3.Servicios;

namespace Tp3
{
    public partial class Informes : Form
    {
        public static decimal AcumuladorMedia;
        public static decimal Acumulado;
        public Informes()
        {
            InitializeComponent();
        }

        private int getCantIntervalos(string selected)
        {
            if (selected.Equals("5 intervalos"))
            {
                return 5;
            }
            else if (selected.Equals("8 intervalos"))
            {
                return 8;
            }
            else if (selected.Equals("10 intervalos"))
            {
                return 10;
            }
            else if (selected.Equals("12 intervalos"))
            {
                return 12;
            }
            else
            {
                return -1;
            }
        }

        private List<decimal> generarListaLimitesSup(decimal men, decimal valorAcumuladoIntervalo, decimal valorEntreInterv,int cantidadInt, List<int> frecuenciaObservada)
        {
            var limitesSup = new List<decimal>();
            for (int i = 0; i < cantidadInt; i++)
            {
                frecuenciaObservada.Add(0);
                //decimal aux = (decimal)menor;
                //creamos aux2 para modificar el limite superior del intervalo
                //ver esto del aux 2 
                //var aux2 = (decimal)0.0000001;
                var limiteSuperior = men + valorAcumuladoIntervalo;
                valorAcumuladoIntervalo += valorEntreInterv;
                limitesSup.Add(limiteSuperior);
            }
            return limitesSup;
        }

        private List<int> calcularFrecObservada(int leng, int cantidadInt, List<decimal> limitesSup, List<decimal> serieNumeros , List<int> frecObservada )
        {

            for (int iteracion = 0; iteracion < leng; iteracion++)
            {
                for (int j = 0; j < cantidadInt; j++)
                {
                    if (serieNumeros[iteracion] <= limitesSup[j])
                    {
                        AcumuladorMedia += (decimal)serieNumeros[iteracion];
                        frecObservada[j]++;
                        break;
                    }
                }
            }
            return frecObservada;
        }

        private void botonInforme_Click(object sender, EventArgs e)
        {
            DgvInforme.Rows.Clear();
            dgvChiCuadrado.Rows.Clear();
            string selected = this.cbIntervalos.GetItemText(this.cbIntervalos.SelectedItem);
            var cantidadInt = getCantIntervalos(selected);
            if (cantidadInt < 0)
            {
                MessageBox.Show("Seleccione una cantidad valida de intervalos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                var serieNumeros = Formulario1.listaDist;
                var leng = Formulario1.listaDist.Count;
                var distribucion = Formulario1.tipoDistribucion;
                List<int> frecObservada = new List<int>();
                List<decimal> limitesSup = new List<decimal>();

                var mayor = serieNumeros[0];
                var menor = serieNumeros[0];
                
                //busco el mayor
                for (int i = 0; i < leng; i++)
                {
                    if (serieNumeros[i] > mayor)
                    {
                        mayor = serieNumeros[i];
                    }
                    if (serieNumeros[i] < menor)
                    {
                        menor = serieNumeros[i];
                    }
                }

                decimal valorEntreIntervalo = (decimal)(mayor - menor) / (decimal)(cantidadInt);

                decimal AcumuladovalorEntreIntervalo = valorEntreIntervalo;

               
                
                if(distribucion.Equals( "POISSON"))
                {
                    limitesSup.Clear();
                    frecObservada.Clear();
                    var auxiliar = mayor - menor + 1;
                    var menorAux = menor;
                    for (int i = 0; i < auxiliar; i++)
                    {
                        frecObservada.Add(0);

                        var limiteSuperior = menorAux;

                        menorAux++;

                        limitesSup.Add(limiteSuperior);
                    }


                    for (int iteracion = 0; iteracion < leng; iteracion++)
                    {
                        Acumulado = 0;
                        for (int j = 0; j < auxiliar; j++)
                        {
                            if (serieNumeros[iteracion] == limitesSup[j])
                            {
                                Acumulado += serieNumeros[iteracion];
                                frecObservada[j]++;
                                break;
                            }
                        }
                    }
                    var lambda = Formulario1.valorMediaExponencial;
                    label2.Text = lambda.ToString();
                    var items = calcularTablaFrecPoisson(lambda,(int)auxiliar,frecObservada ,(int)menor, leng);
                    mostrarEnTabla(items);
                    mostrarTablaChi(items);
                    relizarHistograma(items);



                }


                if (distribucion == "UNIFORME"){
                    limitesSup = generarListaLimitesSup(menor, AcumuladovalorEntreIntervalo, valorEntreIntervalo, cantidadInt, frecObservada);

                    frecObservada = calcularFrecObservada(leng, cantidadInt, limitesSup, serieNumeros, frecObservada);
                    var items = calcularTablaFrecUniforme(cantidadInt, menor, frecObservada, limitesSup, leng);
                    mostrarEnTabla(items);
                    mostrarTablaChi(items);
                    relizarHistograma(items);
                    
                }

                if(distribucion == "NORMAL")
                {
                    limitesSup = generarListaLimitesSup(menor, AcumuladovalorEntreIntervalo, valorEntreIntervalo, cantidadInt, frecObservada);

                    frecObservada = calcularFrecObservada(leng, cantidadInt, limitesSup, serieNumeros, frecObservada);

                    
                    var itemss = calcularTablaFrecNormal(cantidadInt, menor, frecObservada, limitesSup, leng,Formulario1.mediaNormal,Formulario1.desviacionNormal);

                    label2.Text = Formulario1.mediaNormal.ToString();
                    label3.Text = Formulario1.desviacionNormal.ToString();
                    mostrarEnTabla(itemss);
                    mostrarTablaChi(itemss);

                    relizarHistograma(itemss);
                }
                if (distribucion == "EXPONENCIAL")
                {
                    limitesSup = generarListaLimitesSup(menor, AcumuladovalorEntreIntervalo, valorEntreIntervalo, cantidadInt, frecObservada);

                    frecObservada = calcularFrecObservada(leng, cantidadInt, limitesSup, serieNumeros, frecObservada);

                    var items = calcularTablaFrecExponencial(cantidadInt, menor, frecObservada, limitesSup, leng, Formulario1.valorMediaExponencial);
                   
                    mostrarEnTabla(items);
                    mostrarTablaChi(items);
                    relizarHistograma(items);

                    //HACER LA COMPARACION CON CHI TABU
                }

                
            }
        }
        public decimal Factorial(int valor)
        {
            if(valor == 0)
            {
                return 1;
            }
            else
            {
                return (valor * Factorial(valor - 1));
            }
        }
        public List<Registro> calcularTablaFrecPoisson(decimal lambda , int cantIntervalo , List<int> frecObservada , int menor , int leng  )
        {
            var items = new List<Registro>();
            for (int a = 0; a < cantIntervalo; a++)
            {
                var registro = new Registro();

                registro.Hasta = menor;
                registro.FrecuenciaObservada = frecObservada[a];

                var aux1 = Math.Pow((double)lambda, menor);

                var aux2 = Math.Exp(-(double)lambda);

                var factorial = Factorial(menor);
                var probabilidadEsperda = (aux1 * aux2)/(double)factorial;


                var frecEsperda = probabilidadEsperda * leng;
                double frecEsperadaTruncada = (Math.Truncate(1 * frecEsperda) / 1 ) + 1;
                registro.FrecuenciaEsperada = (decimal)frecEsperadaTruncada;

                double probabilidadTruncada = Math.Truncate(10000 * probabilidadEsperda) / 10000;
                registro.ProbabilidadEsperada = (decimal)probabilidadTruncada;
                //USAR LABDA PARA EL CALCULO 
                menor++;
                items.Add(registro);

            }
            return items;

        }
        public List<Registro> calcularTablaFrecUniforme(int cantidadInt,decimal menor, List<int> frecObservada ,List<decimal> limitesSup,int leng)
        {
            var primero = true;
            var items = new List<Registro>();
            decimal fE = (leng / cantidadInt);
            decimal frecEsperada = Math.Truncate(10000 * fE) / 10000;
            for (int a = 0; a < cantidadInt; a++)
            {
                //creamos la variable registro y le asignamos sus atributos
                var registro = new Registro();
                //el primer registro el valor desde del primer intervalo debe ser 0.
                if (primero)
                {
                    registro.Desde = menor;
                    primero = false;
                }
                else
                {
                    //limite sup del a-1
                    decimal desde = Math.Truncate(10000 * limitesSup[a - 1]) / 10000;
                    registro.Desde = desde;

                }
                // aca guardamos los valores de cada registro que seran los datos que mostraremos 
                // en la tabla de frecuencias
                decimal has = Math.Truncate(10000 * limitesSup[a]) / 10000;
                registro.Hasta = (decimal)(has);
                decimal marcaClase = Math.Truncate(10000 * ((decimal)((registro.Hasta + registro.Desde) / 2))) / 10000;
                registro.MarcaClase = marcaClase;
                decimal frecRel = frecObservada[a] / (decimal)leng;
                decimal frecRelativa = Math.Truncate(10000 * frecRel) / 10000;
                registro.FrecuenciaRelativa = frecRel;
                registro.FrecuenciaObservada = frecObservada[a];
                registro.FrecuenciaEsperada = frecEsperada;
                registro.ProbabilidadEsperada = (frecEsperada / leng);
                items.Add(registro);
            }

            return items;
        }

        public List<Registro> calcularTablaFrecExponencial(int cantidadInt, decimal menor, List<int> frecObservada, List<decimal> limitesSup, int leng, decimal mediaExpo)
        {
            var primero = true;
            var items = new List<Registro>();
            
            for (int a = 0; a < cantidadInt; a++)
            {
                //creamos la variable registro y le asignamos sus atributos
                var registro = new Registro();
                //el primer registro el valor desde del primer intervalo debe ser 0.
                if (primero)
                {
                    registro.Desde = menor;
                    primero = false;
                }
                else
                {
                    //limite sup del a-1
                    decimal desde = Math.Truncate(10000 * limitesSup[a - 1]) / 10000;
                    registro.Desde = desde;

                }
                // aca guardamos los valores de cada registro que seran los datos que mostraremos 
                // en la tabla de frecuencias
                decimal has = Math.Truncate(10000 * limitesSup[a]) / 10000;
                registro.Hasta = (decimal)(has);
                decimal marcaClase = Math.Truncate(10000 * ((decimal)((registro.Hasta + registro.Desde) / 2))) / 10000;
                registro.MarcaClase = marcaClase;
                decimal frecRel = frecObservada[a] / (decimal)leng;
                decimal frecRelativa = Math.Truncate(10000 * frecRel) / 10000;
                registro.FrecuenciaRelativa = frecRelativa;
                registro.FrecuenciaObservada = frecObservada[a];

                double aux = (-1 / (double)mediaExpo) * (double)has;

                double aux2 = (-1 / (double)mediaExpo) * (double)registro.Desde;

                var probabilidadAcu = (1 - Math.Exp(aux)) - ((1 - Math.Exp(aux2))) ;

                var frecEsperada = probabilidadAcu * leng;

                double frecEsperadaTruncada = Math.Truncate(10000 * frecEsperada) / 10000;

                registro.FrecuenciaEsperada = (decimal)frecEsperadaTruncada;

                // se muestra la relativa pero es la p()

                double probabilidadTruncada = Math.Truncate(10000 * probabilidadAcu) / 10000;
                registro.ProbabilidadEsperada = (decimal)probabilidadTruncada;

                items.Add(registro);
            }

            return items;
        }
        public List<Registro> calcularTablaFrecNormal(int cantidadInt, decimal menor, List<int> frecObservada, List<decimal> limitesSup, int leng,decimal mediaNormal , decimal desviacion)
        {
            var primero = true;
            var items = new List<Registro>();

            for (int a = 0; a < cantidadInt; a++)
            {
                //creamos la variable registro y le asignamos sus atributos
                var registro = new Registro();
                //el primer registro el valor desde del primer intervalo debe ser 0.
                if (primero)
                {
                    registro.Desde = menor;
                    primero = false;
                }
                else
                {
                    //limite sup del a-1
                    decimal desde = Math.Truncate(10000 * limitesSup[a - 1]) / 10000;
                    registro.Desde = desde;

                }
                // aca guardamos los valores de cada registro que seran los datos que mostraremos 
                // en la tabla de frecuencias
                decimal has = Math.Truncate(10000 * limitesSup[a]) / 10000;
                registro.Hasta = (decimal)(has);
                decimal marcaClase = Math.Truncate(10000 * ((decimal)((registro.Hasta + registro.Desde) / 2))) / 10000;
                registro.MarcaClase = marcaClase;
                decimal frecRel = frecObservada[a] / (decimal)leng;
                decimal frecRelativa = Math.Truncate(10000 * frecRel) / 10000;
                registro.FrecuenciaRelativa = frecRelativa;
                registro.FrecuenciaObservada = frecObservada[a];

                var aux = ((double)marcaClase - (double)mediaNormal) / (double)(desviacion);

                var aux1 = 2 * 3.141592653589793;

                var aux3 = registro.Hasta - registro.Desde;

                var aux4 = (double)(-0.5 * Math.Pow(aux, 2));

                double aux5 = Math.Sqrt((double)aux1);

                var aux6 = (double)(Math.Exp(aux4));

                var probabilidad = (aux6 ) / ((double)desviacion * aux5)  * (double)aux3;

                var frecuenciaEsperada = leng * probabilidad;

                double frecEsperadaTruncada = Math.Truncate(10000 * frecuenciaEsperada) / 10000;

                registro.FrecuenciaEsperada = (decimal)frecEsperadaTruncada;

                double probabilidadTruncada = Math.Truncate(10000 * probabilidad) / 10000;
                registro.ProbabilidadEsperada = (decimal)probabilidadTruncada;

                //registro.FrecuenciaEsperada = frecEsperada;
                // FRECUEENCIA ESPERADA SE CALCULA DE OTRA FORMA :(
                //Agregamos los registros a una lista de objetos registros
                items.Add(registro);
            }

            return items;
        }

        public void mostrarTablaChi(List<Registro> items)
        {
            decimal acumulado = 0;
            for (int i = 0; i < items.Count(); i++)
            {
                //PRUEBA DE BONDAD DE AJUSTE CON CHI
                // calculamos el estadistico llamando a la funcion calcularEstadistico 
                //Luego lo acumulamos en acumulado para obtener el valor de chi cuadrado
                var estaditicoM = CalcularEstadistico(items[i].FrecuenciaObservada, items[i].FrecuenciaEsperada);
                acumulado += estaditicoM;
                Acumulado = (decimal)(Math.Truncate(acumulado * 10000) / 10000);
                //LOLO AGRUPAAA SI ES FE < 5
                var fila = new string[]
               {
                            //items[i].Desde.ToString(),
                            items[i].Desde.ToString(),
                            items[i].Hasta.ToString(),
                            estaditicoM.ToString(),
                            Acumulado.ToString()
               };
                dgvChiCuadrado.Rows.Add(fila);
            }
        }
        public void mostrarEnTabla(List<Registro> items)
        {
            decimal acumulado = 0;
            for (int i = 0; i < items.Count(); i++)
            {
                //PRUEBA DE BONDAD DE AJUSTE CON CHI
                // calculamos el estadistico llamando a la funcion calcularEstadistico 
                //Luego lo acumulamos en acumulado para obtener el valor de chi cuadrado
                var estaditicoM = CalcularEstadistico(items[i].FrecuenciaObservada, items[i].FrecuenciaEsperada);
                acumulado += estaditicoM;
                Acumulado = (decimal)(Math.Truncate(acumulado * 10000) / 10000);
                //Armamos el string que mostraremos en la tabla grafica(dataGrid)
                //DgvInforme += items[i].FrecuenciaRelativa;
                string uwu = "--";
                var fila = new string[]
                {

                            //items[i].Desde.ToString(),
                            items[i].Desde.ToString(),
                            items[i].Hasta.ToString(),
                            items[i].MarcaClase.ToString(),
                            items[i].FrecuenciaObservada.ToString(),
                            items[i].FrecuenciaRelativa.ToString(),
                            items[i].ProbabilidadEsperada.ToString(),
                            items[i].FrecuenciaEsperada.ToString(),

                };
                DgvInforme.Rows.Add(fila);
            }
        }

        private decimal CalcularEstadistico(decimal frecuenciaO, decimal frecuenciaE)
        {
            decimal result = (frecuenciaO - frecuenciaE) * (frecuenciaO - frecuenciaE) / (frecuenciaE);
            var Resultado = Math.Truncate(result * 10000) / 10000;
            return Resultado;
        }

        private void relizarHistograma(List<Registro> items)
        {
            graficoHistrograma.Series.Clear();
            graficoHistrograma.Titles.Clear();
            graficoHistrograma.Titles.Add("HISTOGRAMA FREC OBSERVADA");
            graficoHistrograma.Palette = ChartColorPalette.Berry;
            foreach (var item in items)
            {
                var serie = item.Desde.ToString();
                // creamos el objeto serie para trabajar con el grafico
                Series ser = graficoHistrograma.Series.Add(serie);
                // creamos el string con los datos de cada intervalo
                var label = "[" + item.Desde.ToString() + " - " + item.Hasta.ToString() + "]";
                // con la propiedad label muestro el valor de la frec observada a intervalos del histograma
                ser.Label = item.FrecuenciaObservada.ToString();
                //asignamos el label
                ser.Name = label;
                //con este metodo se visualiza en la tabla el histograma con cada valor de frec observada en su respectivo intervalo
                ser.Points.Add((double)item.FrecuenciaObservada);
            }
        }

        private void Informes_Load(object sender, EventArgs e)
        {

        }
    }
}

