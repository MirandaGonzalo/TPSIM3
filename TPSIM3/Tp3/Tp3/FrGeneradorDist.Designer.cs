
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
            this.lblEstado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTabla)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione la distribución";
            // 
            // txtValorA
            // 
            this.txtValorA.Location = new System.Drawing.Point(58, 15);
            this.txtValorA.Name = "txtValorA";
            this.txtValorA.Size = new System.Drawing.Size(63, 20);
            this.txtValorA.TabIndex = 1;
            this.txtValorA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtValorB
            // 
            this.TxtValorB.Location = new System.Drawing.Point(58, 42);
            this.TxtValorB.Name = "TxtValorB";
            this.TxtValorB.Size = new System.Drawing.Size(63, 20);
            this.TxtValorB.TabIndex = 2;
            this.TxtValorB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "B";
            // 
            // rbDistUniformeAb
            // 
            this.rbDistUniformeAb.AutoSize = true;
            this.rbDistUniformeAb.Checked = true;
            this.rbDistUniformeAb.Location = new System.Drawing.Point(12, 3);
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
            this.rbExponencial.Location = new System.Drawing.Point(135, 3);
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
            this.RbNormal.Location = new System.Drawing.Point(270, 3);
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
            this.RbPoisson.Location = new System.Drawing.Point(372, 3);
            this.RbPoisson.Name = "RbPoisson";
            this.RbPoisson.Size = new System.Drawing.Size(62, 17);
            this.RbPoisson.TabIndex = 8;
            this.RbPoisson.TabStop = true;
            this.RbPoisson.Text = "Poisson";
            this.RbPoisson.UseVisualStyleBackColor = true;
            // 
            // TxtCantMuestras
            // 
            this.TxtCantMuestras.Location = new System.Drawing.Point(177, 43);
            this.TxtCantMuestras.Name = "TxtCantMuestras";
            this.TxtCantMuestras.Size = new System.Drawing.Size(63, 20);
            this.TxtCantMuestras.TabIndex = 9;
            this.TxtCantMuestras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 46);
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
            this.DgvTabla.Location = new System.Drawing.Point(45, 211);
            this.DgvTabla.Name = "DgvTabla";
            this.DgvTabla.Size = new System.Drawing.Size(144, 299);
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
            this.botonGenerar.Location = new System.Drawing.Point(397, 118);
            this.botonGenerar.Name = "botonGenerar";
            this.botonGenerar.Size = new System.Drawing.Size(100, 46);
            this.botonGenerar.TabIndex = 12;
            this.botonGenerar.Text = "GENERAR";
            this.botonGenerar.UseVisualStyleBackColor = true;
            this.botonGenerar.Click += new System.EventHandler(this.botonGenerar_Click);
            // 
            // txtMediaExpo
            // 
            this.txtMediaExpo.Location = new System.Drawing.Point(177, 11);
            this.txtMediaExpo.Name = "txtMediaExpo";
            this.txtMediaExpo.Size = new System.Drawing.Size(63, 20);
            this.txtMediaExpo.TabIndex = 13;
            this.txtMediaExpo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(139, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "U";
            // 
            // botonInforme
            // 
            this.botonInforme.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonInforme.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botonInforme.Location = new System.Drawing.Point(397, 185);
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
            this.botonMostrar.Location = new System.Drawing.Point(397, 257);
            this.botonMostrar.Name = "botonMostrar";
            this.botonMostrar.Size = new System.Drawing.Size(100, 43);
            this.botonMostrar.TabIndex = 16;
            this.botonMostrar.Text = "Mostrar Serie";
            this.botonMostrar.UseVisualStyleBackColor = true;
            this.botonMostrar.Visible = false;
            this.botonMostrar.Click += new System.EventHandler(this.botonMostrar_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(299, 473);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 20);
            this.lblEstado.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtValorA);
            this.panel1.Controls.Add(this.TxtValorB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TxtCantMuestras);
            this.panel1.Controls.Add(this.txtMediaExpo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(45, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 74);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rbDistUniformeAb);
            this.panel2.Controls.Add(this.rbExponencial);
            this.panel2.Controls.Add(this.RbNormal);
            this.panel2.Controls.Add(this.RbPoisson);
            this.panel2.Location = new System.Drawing.Point(45, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 25);
            this.panel2.TabIndex = 19;
            // 
            // Formulario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 522);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.botonMostrar);
            this.Controls.Add(this.botonInforme);
            this.Controls.Add(this.botonGenerar);
            this.Controls.Add(this.DgvTabla);
            this.Controls.Add(this.label1);
            this.Name = "Formulario1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GENERACION DE NUMEROS PSEUDOALETORIOS CON DISTITNAS DISTRIBUCIONES";
            ((System.ComponentModel.ISupportInitialize)(this.DgvTabla)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

