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
            dgvKs.AllowUserToAddRows = false;
            dgvChiCuadrado.AllowUserToAddRows = false;
            DgvInforme.AllowUserToAddRows = false;
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
            label2.Visible = true;
            label3.Visible = true;
            Acumulado = 0;
            var tablaChi = llenarTablaChiTabulado();
            var tablaKS = llenarTablaKS();
            //tablaTabulado = llenarTablaChiTabulado():
            DgvInforme.Rows.Clear();
            dgvChiCuadrado.Rows.Clear();
            dgvKs.Rows.Clear();
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
                    label3.Text = "No se calcula KS";
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
                        
                        for (int j = 0; j < auxiliar; j++)
                        {
                            if (serieNumeros[iteracion] == limitesSup[j])
                            { 
                                frecObservada[j]++;
                                break;
                            }
                        }
                    }
                    var lambda = Formulario1.valorMediaExponencial;
                    
                    var items = calcularTablaFrecPoisson(lambda,(int)auxiliar,frecObservada ,(int)menor, leng);
                    mostrarEnTabla(items);
                    var cantIntervalo = mostrarTablaChi(items);
                    //relizarHistograma(items);
                    var gradosLibertad = cantIntervalo - 1 - 1;

                    var valorTabulado = devolverTabulado(tablaChi, gradosLibertad);
                    if(Acumulado > valorTabulado)
                    {
                        string hipo = "HIPOTESIS -> LA SERIE TIENDE A UNA DISTRIBUCION UNIFORME ->SE RECHAZA LA HIPOTESIS PARA LA PRUEBA DE CHI CUADRADO (" + Acumulado.ToString() + ">" + valorTabulado.ToString() + ")";
                        label2.Text = hipo;
                    }
                    else
                    {
                        string hipo = "HIPOTESIS -> LA SERIE TIENDE A UNA DISTRIBUCION UNIFORME ->NO SE RECHAZA LA HIPOTESIS PARA LA PRUEBA DE CHI CUADRADO  (" + Acumulado.ToString() + "<" + valorTabulado.ToString() + ")";
                        label2.Text = hipo;
                    }
                    
                    relizarHistograma(items);

                }
                else
                {
                    decimal mayorKS;
                    List<Registro> items;
                    if (distribucion.Equals("UNIFORME"))
                    {
                        limitesSup = generarListaLimitesSup(menor, AcumuladovalorEntreIntervalo, valorEntreIntervalo, cantidadInt, frecObservada);

                        frecObservada = calcularFrecObservada(leng, cantidadInt, limitesSup, serieNumeros, frecObservada);
                        items = calcularTablaFrecUniforme(cantidadInt, menor, frecObservada, limitesSup, leng);

                        mostrarEnTabla(items);
                        var cantIntervalo = mostrarTablaChi(items);
                        //relizarHistograma(items);
                        var gradosLibertad = cantIntervalo - 1;

                        var valorTabulado = devolverTabulado(tablaChi, gradosLibertad);
                        if (Acumulado > valorTabulado)
                        {
                            string hipo = "HIPOTESIS -> LA SERIE TIENDE A UNA DISTRIBUCION UNIFORME ->SE RECHAZA LA HIPOTESIS PARA LA PRUEBA DE CHI CUADRADO (" + Acumulado.ToString() + ">" + valorTabulado.ToString() + ")";
                            label2.Text = hipo;
                        }
                        else
                        {
                            string hipo = "HIPOTESIS -> LA SERIE TIENDE A UNA DISTRIBUCION UNIFORME ->NO SE RECHAZA LA HIPOTESIS PARA LA PRUEBA DE CHI CUADRADO  (" + Acumulado.ToString() + "<" + valorTabulado.ToString() + ")";
                            label2.Text = hipo;
                        }

                        mayorKS = mostrarTablaKs(items);
                        var tabuladoKS = devolverTabuladoKS(tablaKS, leng);
                        if (mayorKS > tabuladoKS)
                        {
                            string hipo = "HIPOTESIS -> LA SERIE TIENDE A UNA DISTRIBUCION UNIFORME ->SE RECHAZA LA HIPOTESIS PARA LA PRUEBA DE KS (" + mayorKS.ToString() + ">" + tabuladoKS.ToString() + ")";
                            label3.Text = hipo;
                        }
                        else
                        {
                            string hipo = "HIPOTESIS -> LA SERIE TIENDE A UNA DISTRIBUCION UNIFORME ->NO SE RECHAZA LA HIPOTESIS PARA LA PRUEBA DE KS  (" + mayorKS.ToString() + "<" + tabuladoKS.ToString() + ")";
                            label3.Text = hipo;
                        }

                        relizarHistograma(items);

                    }

                    else if (distribucion == "NORMAL")
                    {
                        limitesSup = generarListaLimitesSup(menor, AcumuladovalorEntreIntervalo, valorEntreIntervalo, cantidadInt, frecObservada);

                        frecObservada = calcularFrecObservada(leng, cantidadInt, limitesSup, serieNumeros, frecObservada);


                        items = calcularTablaFrecNormal(cantidadInt, menor, frecObservada, limitesSup, leng, Formulario1.mediaNormal, Formulario1.desviacionNormal);

                        mostrarEnTabla(items);

                        var cantIntervalo = mostrarTablaChi(items);


                        //prueba de chi cuadrado
                        var gradosLibertad = cantIntervalo - 1 - 2;

                        var valorTabulado = devolverTabulado(tablaChi, gradosLibertad);
                        if (Acumulado > valorTabulado)
                        {
                            string hipo = "HIPOTESIS -> LA SERIE TIENDE A UNA DISTRIBUCION UNIFORME ->SE RECHAZA LA HIPOTESIS PARA LA PRUEBA DE CHI CUADRADO (" + Acumulado.ToString() + ">" + valorTabulado.ToString() + ")";
                            label2.Text = hipo;
                        }
                        else
                        {
                            string hipo = "HIPOTESIS -> LA SERIE TIENDE A UNA DISTRIBUCION UNIFORME ->NO SE RECHAZA LA HIPOTESIS PARA LA PRUEBA DE CHI CUADRADO  (" + Acumulado.ToString() + "<" + valorTabulado.ToString() + ")";
                            label2.Text = hipo;
                        }
                        

                        // PRUEBA DE KS
                        mayorKS = mostrarTablaKs(items);
                        var tabuladoKS = devolverTabuladoKS(tablaKS, leng);

                        if (mayorKS > tabuladoKS)
                        {
                            string hipo = "HIPOTESIS -> LA SERIE TIENDE A UNA DISTRIBUCION UNIFORME ->SE RECHAZA LA HIPOTESIS PARA LA PRUEBA DE KS (" + mayorKS.ToString() + ">" + tabuladoKS.ToString() + ")";
                            label3.Text = hipo;
                        }
                        else
                        {
                            string hipo = "HIPOTESIS -> LA SERIE TIENDE A UNA DISTRIBUCION UNIFORME ->NO SE RECHAZA LA HIPOTESIS PARA LA PRUEBA DE KS  (" + mayorKS.ToString() + "<" + tabuladoKS.ToString() + ")";
                            label3.Text = hipo;
                        }

                        relizarHistograma(items);

                    }
                    else
                    {
                        //Exponencial
                        limitesSup = generarListaLimitesSup(menor, AcumuladovalorEntreIntervalo, valorEntreIntervalo, cantidadInt, frecObservada);

                        frecObservada = calcularFrecObservada(leng, cantidadInt, limitesSup, serieNumeros, frecObservada);

                        items = calcularTablaFrecExponencial(cantidadInt, menor, frecObservada, limitesSup, leng, Formulario1.valorMediaExponencial);
                        //HACER LA COMPARACION CON CHI TABU
                        mostrarEnTabla(items);

                        var cantIntervalo = mostrarTablaChi(items);
                        //relizarHistograma(items);
                        var gradosLibertad = cantIntervalo - 1 - 1;

                        var valorTabulado = devolverTabulado(tablaChi, gradosLibertad);
                        if (Acumulado > valorTabulado)
                        {
                            string hipo = "HIPOTESIS -> LA SERIE TIENDE A UNA DISTRIBUCION UNIFORME ->SE RECHAZA LA HIPOTESIS PARA LA PRUEBA DE CHI CUADRADO (" + Acumulado.ToString() + ">" + valorTabulado.ToString() + ")";
                            label2.Text = hipo;
                        }
                        else
                        {
                            string hipo = "HIPOTESIS -> LA SERIE TIENDE A UNA DISTRIBUCION UNIFORME ->NO SE RECHAZA LA HIPOTESIS PARA LA PRUEBA DE CHI CUADRADO  (" + Acumulado.ToString() + "<" + valorTabulado.ToString() + ")";
                            label2.Text = hipo;
                        }

                        mayorKS = mostrarTablaKs(items);
                        var tabuladoKS = devolverTabuladoKS(tablaKS, leng);
                        if (mayorKS > tabuladoKS)
                        {
                            string hipo = "HIPOTESIS -> LA SERIE TIENDE A UNA DISTRIBUCION UNIFORME ->SE RECHAZA LA HIPOTESIS PARA LA PRUEBA DE KS (" + mayorKS.ToString() + ">" + tabuladoKS.ToString() + ")";
                            label3.Text = hipo;
                        }
                        else
                        {
                            string hipo = "HIPOTESIS -> LA SERIE TIENDE A UNA DISTRIBUCION UNIFORME ->NO SE RECHAZA LA HIPOTESIS PARA LA PRUEBA DE KS  (" + mayorKS.ToString() + "<" + tabuladoKS.ToString() + ")";
                            label3.Text = hipo;
                        }
                    }
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
                decimal frecRel = frecObservada[a] / (decimal)leng;
                decimal frecRelativa = Math.Truncate(10000 * frecRel) / 10000;
                registro.FrecuenciaRelativa = frecRelativa;

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
                registro.FrecuenciaRelativa = frecRelativa;
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

        private bool puedoAcumular(List<Registro> items, int desde)
        {
            decimal acumuladoItems = 0;
            for (int i = desde; i < items.Count(); i++)
            {
                acumuladoItems += items[i].FrecuenciaEsperada;
            }
            if (acumuladoItems > 5)
            {
                //llego a 5 ==> es necesario acumular para los restantes
                //busco hasta cuando puedo acumular, si es hasta una parte o todo (recursividad ?) )
                return true;
            }
            return false;
        }

        private int limiteAcumular(decimal acumulado, List<Registro> items, int desde)
        {
            int hasta = desde;
            decimal acumuladoItems = acumulado;
            for (int i = desde; i < items.Count(); i++)
            {
                if (acumuladoItems > 5)
                {
                    hasta = i;
                    break;
                }
                acumuladoItems += items[i].FrecuenciaEsperada;
            }
            return hasta;
        }

        public int mostrarTablaChi(List<Registro> items)
        {
            var itemsChi = new List<Registro>();
            List<decimal> agrupados;
            int limiteAcumularParcial = 0;
            decimal acumulados = 0;
            decimal desde = 0;
            decimal hasta = 0;
            decimal frecuenciaObservada = 0;
            decimal frecuenciaEsperada = 0;
            bool acumuloRestante = false;
            bool limiteParcial = false;
            for (int i = 0; i < items.Count(); i++)
            {
                
                //Pregunto si tengo que acumular los valores restantes
                if (acumuloRestante)
                {
                    frecuenciaObservada += items[i].FrecuenciaObservada;
                    frecuenciaEsperada += items[i].FrecuenciaEsperada;
                    if (i == items.Count()-1)
                    {
                        hasta = items[i].Hasta;
                        Registro reg = new Registro()
                        {
                            Desde = desde,
                            Hasta = hasta,
                            FrecuenciaEsperada = frecuenciaEsperada,
                            FrecuenciaObservada = frecuenciaObservada
                        };
                        itemsChi.Add(reg);
                    }
                }
                else
                {
                    if (acumulados == 0)
                    {
                        frecuenciaObservada = items[i].FrecuenciaObservada;
                        frecuenciaEsperada = items[i].FrecuenciaEsperada;
                        desde = items[i].Desde;
                        hasta = items[i].Hasta;
                    }
                    if (i < limiteAcumularParcial)
                    {
                        frecuenciaObservada += items[i].FrecuenciaObservada;
                        frecuenciaEsperada += items[i].FrecuenciaEsperada;
                        ;
                    }
                    else 
                    {
                        if (i == limiteAcumularParcial && limiteParcial) { 
                            hasta = items[i-1].Hasta;
                            Registro reg = new Registro()
                            {
                                Desde = desde,
                                Hasta = hasta,
                                FrecuenciaEsperada = frecuenciaEsperada,
                                FrecuenciaObservada = frecuenciaObservada
                            };
                            itemsChi.Add(reg);
                            desde = 0;                            
                            hasta = 0;
                            frecuenciaObservada = items[i].FrecuenciaObservada;
                            frecuenciaEsperada = items[i].FrecuenciaEsperada;
                            acumulados = 0;
                            limiteParcial = false;
                            
                        }
                        if (i == items.Count()-1 && acumulados == 0)
                        {
                            desde = items[i].Desde;
                            hasta = (decimal)items[i].Hasta;
                            acumulados = items[i].FrecuenciaEsperada;
                            frecuenciaObservada = items[i].FrecuenciaObservada;
                            frecuenciaEsperada = items[i].FrecuenciaEsperada;
                            Registro reg = new Registro()
                            {
                                Desde = desde,
                                Hasta = hasta,
                                FrecuenciaEsperada = frecuenciaEsperada,
                                FrecuenciaObservada = frecuenciaObservada
                            };
                            itemsChi.Add(reg);
                        }
                        else
                        {
                            if (acumulados + items[i].FrecuenciaEsperada < 5)
                            {
                                //tengo que acumular.
                                acumulados += items[i].FrecuenciaEsperada;
                                //Reviso si acumulo todo lo que queda o solo los que estan mas cerca.
                                var result = puedoAcumular(items, i+1);
                                if (result)
                                {
                                    //Busco hasta donde Acumular
                                    var limite = limiteAcumular(acumulados, items, i+1);
                                    limiteAcumularParcial = limite;
                                    if (limite == items.Count()) acumuloRestante = true;
                                    limiteParcial = true;
                                }
                                else
                                {
                                    acumuloRestante = true;
                                }
                            }
                            else
                            {
                                desde = items[i].Desde;
                                hasta = (decimal)items[i].Hasta;
                                acumulados = 0;
                                frecuenciaObservada = items[i].FrecuenciaObservada;
                                frecuenciaEsperada = items[i].FrecuenciaEsperada;
                                if (puedoAcumular(items, i + 1))
                                {
                                    Registro reg = new Registro()
                                    {
                                        Desde = desde,
                                        Hasta = hasta,
                                        FrecuenciaEsperada = frecuenciaEsperada,
                                        FrecuenciaObservada = frecuenciaObservada
                                    };
                                    itemsChi.Add(reg);
                                }
                                else
                                {
                                    acumuloRestante = true;
                                }
                            }
                        }
                    }
                }
            }
            decimal acumulado = 0;
            for (int i = 0; i < itemsChi.Count(); i++)
            {
                //PRUEBA DE BONDAD DE AJUSTE CON CHI
                // calculamos el estadistico llamando a la funcion calcularEstadistico 
                //Luego lo acumulamos en acumulado para obtener el valor de chi cuadrado
                var estaditicoM = CalcularEstadistico(itemsChi[i].FrecuenciaObservada, itemsChi[i].FrecuenciaEsperada);
                acumulado += estaditicoM;
                Acumulado = (decimal)(Math.Truncate(acumulado * 10000) / 10000);
                var fila = new string[]
                {    
                            itemsChi[i].Desde.ToString(),
                            itemsChi[i].Hasta.ToString(),
                            itemsChi[i].FrecuenciaObservada.ToString(),
                            itemsChi[i].FrecuenciaEsperada.ToString(),
                            estaditicoM.ToString(),
                            Acumulado.ToString()
                 };
                dgvChiCuadrado.Rows.Add(fila);
            }

            return itemsChi.Count();
        }

        public decimal mostrarTablaKs(List<Registro> items)
        {
            var cantNumeros = Formulario1.listaDist.Count;
            decimal acumuladaPO = 0;
            decimal acumuladaPE = 0;
            decimal mayor = 0;
            bool primero = true;
            decimal probabilidadObservada = 0;
            for (int i = 0; i < items.Count(); i++)
            {
                probabilidadObservada = items[i].FrecuenciaObservada / cantNumeros;
                acumuladaPO += probabilidadObservada;
                acumuladaPE += items[i].ProbabilidadEsperada;
                var valorAbs = Math.Abs(acumuladaPO - acumuladaPE);
                if (primero)
                {
                    mayor = valorAbs;
                    primero = false;
                }
                if (valorAbs > mayor) mayor = valorAbs;

                var fila = new string[]
                   {
                        items[i].Desde.ToString(),
                        items[i].Hasta.ToString(),
                        items[i].FrecuenciaObservada.ToString(),
                        items[i].FrecuenciaEsperada.ToString(),
                        probabilidadObservada.ToString(),
                        items[i].ProbabilidadEsperada.ToString(),
                        acumuladaPO.ToString(),
                        acumuladaPE.ToString(),
                        valorAbs.ToString(),
                        mayor.ToString(),
                   };

                dgvKs.Rows.Add(fila);
            }
            return mayor;
        }
        public void mostrarEnTabla(List<Registro> items)
        {
            for (int i = 0; i < items.Count(); i++)
            {
                var fila = new string[]
                {
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

        public List<double> llenarTablaChiTabulado()
        {
            var tablaChi = new List<double>();

            for (int i = 0; i < 20; i++)
            {
                tablaChi.Add(0);
            }
            tablaChi[0] = 0;
            tablaChi[1] = 3.84;
            tablaChi[2] = 5.99;
            tablaChi[3] = 7.81;
            tablaChi[4] = 9.49;
            tablaChi[5] = 11.1;
            tablaChi[6] = 12.6;
            tablaChi[7] = 14.1;
            tablaChi[8] = 15.5;
            tablaChi[9] = 16.9;
            tablaChi[10] = 18.3;
            tablaChi[11] = 19.7;
            tablaChi[12] = 21.0;
            tablaChi[13] = 22.4;
            tablaChi[14] = 23.7;
            tablaChi[15] = 25.0;

            return tablaChi;
        }

        public decimal devolverTabulado(List<double> tablaChi, int gradosLibertad)
        {
            decimal tabu;
            if(gradosLibertad > 0)
            {
                tabu = (decimal)tablaChi[gradosLibertad];
            }
            else
            {
                tabu = 0;
            }

            return tabu;
        }

        public List<double> llenarTablaKS()
        {
            var tablaKS = new List<double>();

            for (int i = 0; i < 36; i++)
            {
                tablaKS.Add(0);
            }
            tablaKS[0] = 0;
            tablaKS[1] = 0.97500;
            tablaKS[2] = 0.84189;
            tablaKS[3] = 0.70760;
            tablaKS[4] = 0.62394;
            tablaKS[5] = 0.56328;
            tablaKS[6] = 0.51926;
            tablaKS[7] = 0.48342;
            tablaKS[8] = 0.45427;
            tablaKS[9] = 0.43001;
            tablaKS[10] = 0.40925;
            tablaKS[11] = 0.39122;
            tablaKS[12] = 0.37543;
            tablaKS[13] = 0.32143;
            tablaKS[14] = 0.34890;
            tablaKS[15] = 0.33750;
            tablaKS[16] = 0.3;
            tablaKS[17] = 0.31796;
            tablaKS[18] = 0.30936;
            tablaKS[19] = 0.30143;
            tablaKS[20] = 0.29408;
            tablaKS[21] = 0.28724;
            tablaKS[22] = 0.28087;
            tablaKS[23] = 0.2749;
            tablaKS[24] = 0.26931;
            tablaKS[25] = 0.26404;
            tablaKS[26] = 0.25908;
            tablaKS[27] = 0.25438;
            tablaKS[28] = 0.24993;
            tablaKS[29] = 0.24571;
            tablaKS[30] = 0.24170;
            tablaKS[31] = 0.23788;
            tablaKS[32] = 0.23424;

            return tablaKS;
        }
    
        public decimal devolverTabuladoKS(List<double> tablaKS, int leng)
        {
            decimal tabu;
            if (leng <= 35)
            {
                tabu = (decimal)tablaKS[leng];
            }
            else
            {
                var raizN = Math.Sqrt(leng);

                tabu = (decimal)1.36 /(decimal)raizN;
            }
            return tabu;
        }
        private void Informes_Load(object sender, EventArgs e)
        {

        }
    }
}

