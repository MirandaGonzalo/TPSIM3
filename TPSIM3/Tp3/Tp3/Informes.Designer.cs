
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
            this.Desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaClase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrecuenciaObservada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrecuenciaEsperada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbIntervalos = new System.Windows.Forms.ComboBox();
            this.graficoHistrograma = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvChiCuadrado = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInforme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoHistrograma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiCuadrado)).BeginInit();
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
            this.FrecuenciaEsperada});
            this.DgvInforme.Location = new System.Drawing.Point(12, 100);
            this.DgvInforme.Name = "DgvInforme";
            this.DgvInforme.RowHeadersWidth = 51;
            this.DgvInforme.Size = new System.Drawing.Size(1127, 234);
            this.DgvInforme.TabIndex = 9;
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
            this.Column7.HeaderText = "PO()";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Pe()";
            this.Column8.Name = "Column8";
            // 
            // FrecuenciaEsperada
            // 
            this.FrecuenciaEsperada.HeaderText = "Frecuencia esperada";
            this.FrecuenciaEsperada.MinimumWidth = 6;
            this.FrecuenciaEsperada.Name = "FrecuenciaEsperada";
            this.FrecuenciaEsperada.Width = 125;
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
            // graficoHistrograma
            // 
            chartArea1.Name = "ChartArea1";
            this.graficoHistrograma.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graficoHistrograma.Legends.Add(legend1);
            this.graficoHistrograma.Location = new System.Drawing.Point(64, 340);
            this.graficoHistrograma.Name = "graficoHistrograma";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.graficoHistrograma.Series.Add(series1);
            this.graficoHistrograma.Size = new System.Drawing.Size(534, 300);
            this.graficoHistrograma.TabIndex = 11;
            this.graficoHistrograma.Text = "chart1";
            // 
            // dgvChiCuadrado
            // 
            this.dgvChiCuadrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiCuadrado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.FO,
            this.FE,
            this.Column3,
            this.Column4});
            this.dgvChiCuadrado.Location = new System.Drawing.Point(604, 376);
            this.dgvChiCuadrado.Name = "dgvChiCuadrado";
            this.dgvChiCuadrado.Size = new System.Drawing.Size(615, 150);
            this.dgvChiCuadrado.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "label3";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Desde";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Hasta";
            this.Column2.Name = "Column2";
            // 
            // FO
            // 
            this.FO.HeaderText = "FO";
            this.FO.Name = "FO";
            // 
            // FE
            // 
            this.FE.HeaderText = "FE";
            this.FE.Name = "FE";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "C()";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "C() Acu";
            this.Column4.Name = "Column4";
            // 
            // Informes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 645);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvChiCuadrado);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiCuadrado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonInforme;
        private System.Windows.Forms.DataGridView DgvInforme;
        private System.Windows.Forms.ComboBox cbIntervalos;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoHistrograma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaClase;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrecuenciaObservada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrecuenciaEsperada;
        private System.Windows.Forms.DataGridView dgvChiCuadrado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}