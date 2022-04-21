
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvKs = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvPoissonDist = new System.Windows.Forms.DataGridView();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrecObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Probabilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProbEsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrecEspe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvChiPoisson = new System.Windows.Forms.DataGridView();
            this.ValorChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FeChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAcuChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInforme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoHistrograma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiCuadrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoissonDist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiPoisson)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "INTERVALOS";
            // 
            // botonInforme
            // 
            this.botonInforme.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonInforme.Location = new System.Drawing.Point(325, 6);
            this.botonInforme.Name = "botonInforme";
            this.botonInforme.Size = new System.Drawing.Size(139, 31);
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
            this.DgvInforme.Location = new System.Drawing.Point(12, 43);
            this.DgvInforme.Name = "DgvInforme";
            this.DgvInforme.RowHeadersWidth = 51;
            this.DgvInforme.Size = new System.Drawing.Size(799, 219);
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
            this.FrecuenciaObservada.HeaderText = "FO";
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
            this.FrecuenciaEsperada.HeaderText = "FE";
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
            this.cbIntervalos.Location = new System.Drawing.Point(117, 16);
            this.cbIntervalos.Name = "cbIntervalos";
            this.cbIntervalos.Size = new System.Drawing.Size(121, 21);
            this.cbIntervalos.TabIndex = 10;
            // 
            // graficoHistrograma
            // 
            chartArea3.Name = "ChartArea1";
            this.graficoHistrograma.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.graficoHistrograma.Legends.Add(legend3);
            this.graficoHistrograma.Location = new System.Drawing.Point(817, 43);
            this.graficoHistrograma.Name = "graficoHistrograma";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.graficoHistrograma.Series.Add(series3);
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
            this.dgvChiCuadrado.Location = new System.Drawing.Point(12, 268);
            this.dgvChiCuadrado.Name = "dgvChiCuadrado";
            this.dgvChiCuadrado.Size = new System.Drawing.Size(657, 138);
            this.dgvChiCuadrado.TabIndex = 12;
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
            // dgvKs
            // 
            this.dgvKs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16});
            this.dgvKs.Location = new System.Drawing.Point(12, 482);
            this.dgvKs.Name = "dgvKs";
            this.dgvKs.Size = new System.Drawing.Size(1127, 220);
            this.dgvKs.TabIndex = 15;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Desde";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Hasta";
            this.Column6.Name = "Column6";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "FO";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "FE";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "PO()";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Pe()";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "PO()ACU";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "PE()ACU";
            this.Column14.Name = "Column14";
            // 
            // Column15
            // 
            this.Column15.HeaderText = "PO()AC - PE()AC";
            this.Column15.Name = "Column15";
            // 
            // Column16
            // 
            this.Column16.HeaderText = "MAYOR";
            this.Column16.Name = "Column16";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PeachPuff;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(684, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "<-- CHI CUADRADO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1158, 511);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "<-- KS";
            // 
            // dgvPoissonDist
            // 
            this.dgvPoissonDist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoissonDist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Valor,
            this.FrecObs,
            this.Probabilidad,
            this.ProbEsp,
            this.FrecEspe});
            this.dgvPoissonDist.Location = new System.Drawing.Point(12, 43);
            this.dgvPoissonDist.Name = "dgvPoissonDist";
            this.dgvPoissonDist.Size = new System.Drawing.Size(545, 219);
            this.dgvPoissonDist.TabIndex = 20;
            this.dgvPoissonDist.Visible = false;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // FrecObs
            // 
            this.FrecObs.HeaderText = "Fo";
            this.FrecObs.Name = "FrecObs";
            // 
            // Probabilidad
            // 
            this.Probabilidad.HeaderText = "Po()";
            this.Probabilidad.Name = "Probabilidad";
            // 
            // ProbEsp
            // 
            this.ProbEsp.HeaderText = "Pe()";
            this.ProbEsp.Name = "ProbEsp";
            // 
            // FrecEspe
            // 
            this.FrecEspe.HeaderText = "Fe";
            this.FrecEspe.Name = "FrecEspe";
            // 
            // dgvChiPoisson
            // 
            this.dgvChiPoisson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiPoisson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ValorChi,
            this.FoChi,
            this.FeChi,
            this.cChi,
            this.CAcuChi});
            this.dgvChiPoisson.Location = new System.Drawing.Point(12, 268);
            this.dgvChiPoisson.Name = "dgvChiPoisson";
            this.dgvChiPoisson.Size = new System.Drawing.Size(545, 138);
            this.dgvChiPoisson.TabIndex = 21;
            this.dgvChiPoisson.Visible = false;
            // 
            // ValorChi
            // 
            this.ValorChi.HeaderText = "Valor";
            this.ValorChi.Name = "ValorChi";
            // 
            // FoChi
            // 
            this.FoChi.HeaderText = "Fo";
            this.FoChi.Name = "FoChi";
            // 
            // FeChi
            // 
            this.FeChi.HeaderText = "Fe";
            this.FeChi.Name = "FeChi";
            // 
            // cChi
            // 
            this.cChi.HeaderText = "C";
            this.cChi.Name = "cChi";
            // 
            // CAcuChi
            // 
            this.CAcuChi.HeaderText = "C(AC)";
            this.CAcuChi.Name = "CAcuChi";
            // 
            // Informes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.dgvChiPoisson);
            this.Controls.Add(this.dgvPoissonDist);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvKs);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvKs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoissonDist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiPoisson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonInforme;
        private System.Windows.Forms.DataGridView DgvInforme;
        private System.Windows.Forms.ComboBox cbIntervalos;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoHistrograma;
        private System.Windows.Forms.DataGridView dgvChiCuadrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridView dgvKs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaClase;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrecuenciaObservada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrecuenciaEsperada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvPoissonDist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrecObs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Probabilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProbEsp;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrecEspe;
        private System.Windows.Forms.DataGridView dgvChiPoisson;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn FeChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAcuChi;
    }
}