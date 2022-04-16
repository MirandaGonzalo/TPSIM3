using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tp3.Servicios;

namespace Tp3
{
    public partial class Formulario1 : Form
    {
        public static List<decimal> listaDist;
        public Formulario1()
        {
            listaDist = new List<decimal>();
            InitializeComponent();
            DgvTabla.AllowUserToAddRows = false;
        }


        private void botonGenerar_Click(object sender, EventArgs e)
        {
            DgvTabla.Visible = false;
            //limpio tabla
            DgvTabla.Rows.Clear();
            //limpio lista
            listaDist.Clear();
            // tomo la cantidad de mueestas
            var cantMuestras = Convert.ToInt64(TxtCantMuestras.Text);

            //uniforme a b
            if (rbDistUniformeAb.Checked)
            {
                var generador = new Generador();
                var valorA = Convert.ToInt64(txtValorA.Text);
                var valorB = Convert.ToInt64(TxtValorB.Text);

                generador.valorA = valorA;
                generador.valorB = valorB;

                Random random = new Random();

                for (var i = 0; cantMuestras > i; i++)
                {
                    double numeroRND = random.NextDouble();
                    decimal x = generador.generarSerieDistribucionUniformeAB(generador, numeroRND);

                    listaDist.Add(x);
                }
            }

            //exponencial negativa
            if (rbExponencial.Checked)
            {


                var gen = new Generador();
                Random random = new Random();

                gen.valorMedia = decimal.Parse(txtMediaExpo.Text);


                for (var i = 0; cantMuestras > i; i++)
                {
                    double numeroRND = random.NextDouble();
                    var x = (decimal)gen.generarSerieExponencuialNegativa(gen, numeroRND);

                    listaDist.Add(x);
                }


            }

            if (RbNormal.Checked)
            {
                if((cantMuestras % 2) == 0)
                {
                    cantMuestras = cantMuestras / 2;
                }
                else
                {
                    cantMuestras = (cantMuestras / 2) + 1; 
                }

                var generador = new Generador();
                var listaNormal = new List<decimal>();
                var mediaNormal = Convert.ToInt64(txtValorA.Text);
                var desviacion = Convert.ToInt64(TxtValorB.Text);

                generador.mediaNormal = mediaNormal;
                generador.desviacionNormal = desviacion;

                Random random1 = new Random();
                Random random2 = new Random();

                for (var i = 0; cantMuestras > i; i++)
                {
                    double numeroRND1 = random1.NextDouble();
                    double numeroRND2 = random2.NextDouble();
                    var n1 = (decimal)generador.generarNormalN1(generador, numeroRND1, numeroRND2);
                    var n2 = (decimal)generador.generarNormalN2(generador, numeroRND1, numeroRND2);

                    listaDist.Add(n1);
                    listaDist.Add(n2);
                }


            }

            if (RbPoisson.Checked)
            {
                Random random = new Random();
                var listaPoisson = new List<Int64>();
                for (var i = 0; cantMuestras > i; i++)
                {
                    var lambda = double.Parse(txtMediaExpo.Text);
                    double p = 1;
                    var x = -1;
                    var A = Math.Exp(-lambda);

                    do
                    {
                        double numeroRND = random.NextDouble();
                        p *= numeroRND;
                        x += 1;                       
                    }
                    while (p >= A);
                    {
                        listaDist.Add((decimal)x);
                        
                    }
                }
            }


        }

        private void limpiarCampoExpo()
        {
            txtMediaExpo.Enabled = true;
            txtValorA.Enabled = false;
            TxtValorB.Enabled = false;
            label5.BackColor = System.Drawing.Color.Red;
            label2.BackColor = System.Drawing.Color.Black;
            label3.BackColor = System.Drawing.Color.Black;
        }
        private void limpiarCampoUniforme()
        {
            txtMediaExpo.Enabled = false;
            txtValorA.Enabled = true;
            TxtValorB.Enabled = true;
            label2.BackColor = System.Drawing.Color.Red;
            label3.BackColor = System.Drawing.Color.Red;
            label5.BackColor = System.Drawing.Color.Black;
        }
        private void rbDistUniformeAb_CheckedChanged(object sender, EventArgs e)
        {
            limpiarCampoUniforme();

        }

        private void rbExponencial_CheckedChanged(object sender, EventArgs e)
        {
            limpiarCampoExpo();


        }

        private void limpiarCampoNormal()
        {
            label2.Text = "Media:";
            label3.Text = "D.E";
            txtMediaExpo.Enabled = false;
            txtValorA.Enabled = true;
            TxtValorB.Enabled = true;
            label2.BackColor = System.Drawing.Color.Red;
            label3.BackColor = System.Drawing.Color.Red;
            label5.BackColor = System.Drawing.Color.Black;
        }
        private void RbNormal_CheckedChanged(object sender, EventArgs e)
        {
            limpiarCampoNormal();
        }


        private void botonInforme_Click(object sender, EventArgs e)
        {
            Informes frm2 = new Informes();
            frm2.Show();
        }

        private void botonMostrar_Click(object sender, EventArgs e)
        {
            foreach (var item in listaDist)
            {
                var fila = new string[]
                {
                     item.ToString(),
                };
                DgvTabla.Rows.Add(fila);
            }
            DgvTabla.Visible = true;
        }
    }
}
