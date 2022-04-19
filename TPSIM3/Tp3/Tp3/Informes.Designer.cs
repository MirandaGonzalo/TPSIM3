
namespace Tp3
{
    partial class Informes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.botonInforme = new System.Windows.Forms.Button();
            this.DgvInforme = new System.Windows.Forms.DataGridView();
            this.cbIntervalos = new System.Windows.Forms.ComboBox();
            this.Desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaClase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrecuenciaObservada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrecuenciaEsperada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.graficoHistrograma = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInforme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoHistrograma)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "INTERVALOS";
            // 
            // botonInforme
            // 
            this.botonInforme.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonInforme.Location = new System.Drawing.Point(400, 28);
            this.botonInforme.Name = "botonInforme";
            this.botonInforme.Size = new System.Drawing.Size(126, 41);
            this.botonInforme.TabIndex = 2;
            this.botonInforme.Text = "INFORME";
            this.botonInforme.UseVisualStyleBackColor = true;
            this.botonInforme.Click += new System.EventHandler(this.botonInforme_Click);
            // 
            // DgvInforme
            // 
            this.DgvInforme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInforme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Desde,
            this.Hasta,
            this.MarcaClase,
            this.FrecuenciaObservada,
            this.Column7,
            this.Column8,
            this.FrecuenciaEsperada,
            this.Column5,
            this.Column6});
            this.DgvInforme.Location = new System.Drawing.Point(12, 100);
            this.DgvInforme.Name = "DgvInforme";
            this.DgvInforme.RowHeadersWidth = 51;
            this.DgvInforme.Size = new System.Drawing.Size(1127, 234);
            this.DgvInforme.TabIndex = 9;
            // 
            // cbIntervalos
            // 
            this.cbIntervalos.FormattingEnabled = true;
            this.cbIntervalos.Items.AddRange(new object[] {
            "5 intervalos",
            "8 intervalos",
            "10 intervalos",
            "12 intervalos"});
            this.cbIntervalos.Location = new System.Drawing.Point(133, 38);
            this.cbIntervalos.Name = "cbIntervalos";
            this.cbIntervalos.Size = new System.Drawing.Size(121, 21);
            this.cbIntervalos.TabIndex = 10;
            // 
            // Desde
            // 
            this.Desde.HeaderText = "Desde";
            this.Desde.MinimumWidth = 6;
            this.Desde.Name = "Desde";
            this.Desde.Width = 125;
            // 
            // Hasta
            // 
            this.Hasta.HeaderText = "Hasta";
            this.Hasta.MinimumWidth = 6;
            this.Hasta.Name = "Hasta";
            this.Hasta.Width = 125;
            // 
            // MarcaClase
            // 
            this.MarcaClase.HeaderText = "Marca de clase";
            this.MarcaClase.MinimumWidth = 6;
            this.MarcaClase.Name = "MarcaClase";
            this.MarcaClase.Width = 125;
            // 
            // FrecuenciaObservada
            // 
            this.FrecuenciaObservada.HeaderText = "Frecuencia observada";
            this.FrecuenciaObservada.MinimumWidth = 6;
            this.FrecuenciaObservada.Name = "FrecuenciaObservada";
            this.FrecuenciaObservada.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "P( ) ";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Frec relativa Acumulado";
            this.Column8.Name = "Column8";
            // 
            // FrecuenciaEsperada
            // 
            this.FrecuenciaEsperada.HeaderText = "Frecuencia esperada";
            this.FrecuenciaEsperada.MinimumWidth = 6;
            this.FrecuenciaEsperada.Name = "FrecuenciaEsperada";
            this.FrecuenciaEsperada.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "C()";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "C() Acumulado";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // graficoHistrograma
            // 
            chartArea1.Name = "ChartArea1";
            this.graficoHistrograma.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graficoHistrograma.Legends.Add(legend1);
            this.graficoHistrograma.Location = new System.Drawing.Point(100, 376);
            this.graficoHistrograma.Name = "graficoHistrograma";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.graficoHistrograma.Series.Add(series1);
            this.graficoHistrograma.Size = new System.Drawing.Size(534, 300);
            this.graficoHistrograma.TabIndex = 11;
            this.graficoHistrograma.Text = "chart1";
            // 
            // Informes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 645);
            this.Controls.Add(this.graficoHistrograma);
            this.Controls.Add(this.cbIntervalos);
            this.Controls.Add(this.DgvInforme);
            this.Controls.Add(this.botonInforme);
            this.Controls.Add(this.label1);
            this.Name = "Informes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informes";
            this.Load += new System.EventHandler(this.Informes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvInforme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoHistrograma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonInforme;
        private System.Windows.Forms.DataGridView DgvInforme;
        private System.Windows.Forms.ComboBox cbIntervalos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaClase;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrecuenciaObservada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrecuenciaEsperada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoHistrograma;
    }
}