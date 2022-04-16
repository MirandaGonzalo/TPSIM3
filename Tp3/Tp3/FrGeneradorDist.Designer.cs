
namespace Tp3
{
    partial class Formulario1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorA = new System.Windows.Forms.TextBox();
            this.TxtValorB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbDistUniformeAb = new System.Windows.Forms.RadioButton();
            this.rbExponencial = new System.Windows.Forms.RadioButton();
            this.RbNormal = new System.Windows.Forms.RadioButton();
            this.RbPoisson = new System.Windows.Forms.RadioButton();
            this.TxtCantMuestras = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DgvTabla = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonGenerar = new System.Windows.Forms.Button();
            this.txtMediaExpo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.botonInforme = new System.Windows.Forms.Button();
            this.botonMostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione la distribución";
            // 
            // txtValorA
            // 
            this.txtValorA.Location = new System.Drawing.Point(146, 129);
            this.txtValorA.Name = "txtValorA";
            this.txtValorA.Size = new System.Drawing.Size(63, 20);
            this.txtValorA.TabIndex = 1;
            // 
            // TxtValorB
            // 
            this.TxtValorB.Location = new System.Drawing.Point(146, 156);
            this.TxtValorB.Name = "TxtValorB";
            this.TxtValorB.Size = new System.Drawing.Size(63, 20);
            this.TxtValorB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "B";
            // 
            // rbDistUniformeAb
            // 
            this.rbDistUniformeAb.AutoSize = true;
            this.rbDistUniformeAb.Location = new System.Drawing.Point(87, 78);
            this.rbDistUniformeAb.Name = "rbDistUniformeAb";
            this.rbDistUniformeAb.Size = new System.Drawing.Size(87, 17);
            this.rbDistUniformeAb.TabIndex = 5;
            this.rbDistUniformeAb.TabStop = true;
            this.rbDistUniformeAb.Text = "Uniforme A B";
            this.rbDistUniformeAb.UseVisualStyleBackColor = true;
            this.rbDistUniformeAb.CheckedChanged += new System.EventHandler(this.rbDistUniformeAb_CheckedChanged);
            // 
            // rbExponencial
            // 
            this.rbExponencial.AutoSize = true;
            this.rbExponencial.Location = new System.Drawing.Point(210, 78);
            this.rbExponencial.Name = "rbExponencial";
            this.rbExponencial.Size = new System.Drawing.Size(86, 17);
            this.rbExponencial.TabIndex = 6;
            this.rbExponencial.TabStop = true;
            this.rbExponencial.Text = "Exponencial ";
            this.rbExponencial.UseVisualStyleBackColor = true;
            this.rbExponencial.CheckedChanged += new System.EventHandler(this.rbExponencial_CheckedChanged);
            // 
            // RbNormal
            // 
            this.RbNormal.AutoSize = true;
            this.RbNormal.Location = new System.Drawing.Point(345, 78);
            this.RbNormal.Name = "RbNormal";
            this.RbNormal.Size = new System.Drawing.Size(58, 17);
            this.RbNormal.TabIndex = 7;
            this.RbNormal.TabStop = true;
            this.RbNormal.Text = "Normal";
            this.RbNormal.UseVisualStyleBackColor = true;
            this.RbNormal.CheckedChanged += new System.EventHandler(this.RbNormal_CheckedChanged);
            // 
            // RbPoisson
            // 
            this.RbPoisson.AutoSize = true;
            this.RbPoisson.Location = new System.Drawing.Point(447, 78);
            this.RbPoisson.Name = "RbPoisson";
            this.RbPoisson.Size = new System.Drawing.Size(62, 17);
            this.RbPoisson.TabIndex = 8;
            this.RbPoisson.TabStop = true;
            this.RbPoisson.Text = "Poisson";
            this.RbPoisson.UseVisualStyleBackColor = true;
            // 
            // TxtCantMuestras
            // 
            this.TxtCantMuestras.Location = new System.Drawing.Point(265, 157);
            this.TxtCantMuestras.Name = "TxtCantMuestras";
            this.TxtCantMuestras.Size = new System.Drawing.Size(63, 20);
            this.TxtCantMuestras.TabIndex = 9;
           
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "N";
            
            // 
            // DgvTabla
            // 
            this.DgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero});
            this.DgvTabla.Location = new System.Drawing.Point(87, 198);
            this.DgvTabla.Name = "DgvTabla";
            this.DgvTabla.Size = new System.Drawing.Size(158, 378);
            this.DgvTabla.TabIndex = 11;
            this.DgvTabla.Visible = false;
            // 
            // numero
            // 
            this.numero.HeaderText = "NUMERO ";
            this.numero.Name = "numero";
            // 
            // botonGenerar
            // 
            this.botonGenerar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonGenerar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botonGenerar.Location = new System.Drawing.Point(345, 133);
            this.botonGenerar.Name = "botonGenerar";
            this.botonGenerar.Size = new System.Drawing.Size(100, 46);
            this.botonGenerar.TabIndex = 12;
            this.botonGenerar.Text = "GENERAR";
            this.botonGenerar.UseVisualStyleBackColor = true;
            this.botonGenerar.Click += new System.EventHandler(this.botonGenerar_Click);
            // 
            // txtMediaExpo
            // 
            this.txtMediaExpo.Location = new System.Drawing.Point(265, 125);
            this.txtMediaExpo.Name = "txtMediaExpo";
            this.txtMediaExpo.Size = new System.Drawing.Size(63, 20);
            this.txtMediaExpo.TabIndex = 13;

            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(227, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "U";
           
            // 
            // botonInforme
            // 
            this.botonInforme.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonInforme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botonInforme.Location = new System.Drawing.Point(456, 133);
            this.botonInforme.Name = "botonInforme";
            this.botonInforme.Size = new System.Drawing.Size(100, 46);
            this.botonInforme.TabIndex = 15;
            this.botonInforme.Text = "INFORME";
            this.botonInforme.UseVisualStyleBackColor = true;
            this.botonInforme.Click += new System.EventHandler(this.botonInforme_Click);
            // 
            // botonMostrar
            // 
            this.botonMostrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonMostrar.Location = new System.Drawing.Point(447, 198);
            this.botonMostrar.Name = "botonMostrar";
            this.botonMostrar.Size = new System.Drawing.Size(109, 43);
            this.botonMostrar.TabIndex = 16;
            this.botonMostrar.Text = "Mostrar Serie";
            this.botonMostrar.UseVisualStyleBackColor = true;
            this.botonMostrar.Click += new System.EventHandler(this.botonMostrar_Click);
            // 
            // Formulario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.botonMostrar);
            this.Controls.Add(this.botonInforme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMediaExpo);
            this.Controls.Add(this.botonGenerar);
            this.Controls.Add(this.DgvTabla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtCantMuestras);
            this.Controls.Add(this.RbPoisson);
            this.Controls.Add(this.RbNormal);
            this.Controls.Add(this.rbExponencial);
            this.Controls.Add(this.rbDistUniformeAb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtValorB);
            this.Controls.Add(this.txtValorA);
            this.Controls.Add(this.label1);
            this.Name = "Formulario1";
            this.Text = "GENERACION DE NUMEROS PSEUDOALETORIOS CON DISTITNAS DISTRIBUCIONES";
            
            ((System.ComponentModel.ISupportInitialize)(this.DgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorA;
        private System.Windows.Forms.TextBox TxtValorB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbDistUniformeAb;
        private System.Windows.Forms.RadioButton rbExponencial;
        private System.Windows.Forms.RadioButton RbNormal;
        private System.Windows.Forms.RadioButton RbPoisson;
        private System.Windows.Forms.TextBox TxtCantMuestras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DgvTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.Button botonGenerar;
        private System.Windows.Forms.TextBox txtMediaExpo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button botonInforme;
        private System.Windows.Forms.Button botonMostrar;
    }
}

