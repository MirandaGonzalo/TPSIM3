using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tp3.Servicios;

namespace Tp3
{
    public partial class Informes : Form
    {
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

        private void botonInforme_Click(object sender, EventArgs e)
        {
            DgvInforme.Rows.Clear();
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
                for (int i = 0; i < cantidadInt; i++)
                {
                    frecObservada.Add(0);
                    decimal aux = (decimal)menor;
                    //creamos aux2 para modificar el limite superior del intervalo
                    //ver esto del aux 2 
                
                    var aux2 = (decimal)0.00001;
                
                    var limiteSuperior = menor + AcumuladovalorEntreIntervalo;
                    AcumuladovalorEntreIntervalo += valorEntreIntervalo;
                    limitesSup.Add(limiteSuperior);
                }


                for (int iteracion = 0; iteracion < leng; iteracion++)
                {
                    for (int j = 0; j < cantidadInt; j++)
                    {
                        if (serieNumeros[iteracion] <= limitesSup[j])
                        {
                            //AcumuladorMedia += (double)numeros[i];
                            frecObservada[j]++;
                            break;
                        }
                    }
                }


                //creamos el arreglo de registros
                var items = new List<Registro>();
                var primero = true;
                decimal acumuladorDesde = valorEntreIntervalo;

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
                        acumuladorDesde += acumuladorDesde;
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
                    //registro.FrecuenciaEsperada = frecEsperada;
                    // FRECUEENCIA ESPERADA SE CALCULA DE OTRA FORMA :(
                    //Agregamos los registros a una lista de objetos registros
                    items.Add(registro);
                }
                for (int i = 0; i < items.Count(); i++)
                {
                    //PRUEBA DE BONDAD DE AJUSTE CON CHI
                    // calculamos el estadistico llamando a la funcion calcularEstadistico 
                    // Luego lo acumulamos en acumulado para obtener el valor de chi cuadrado
                    //var estaditicoM = CalcularEstadistico(items[i].FrecuenciaObservada, items[i].FrecuenciaEsperada);
                    //acumulado += estaditicoM;
                    //Acumulado = (double)(Math.Truncate(acumulado * 10000) / 10000);
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
                            uwu,
                            items[i].FrecuenciaEsperada.ToString(),
                            uwu,
                            uwu
                    };
                    DgvInforme.Rows.Add(fila);
                }
            }
        }

        private void Informes_Load(object sender, EventArgs e)
        {

        }
    }
}

