namespace Sumatoria1aN
{
    partial class Form1
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
            this.cuadroNumero = new System.Windows.Forms.TextBox();
            this.listaResultados = new System.Windows.Forms.ListBox();
            this.botonCalcular = new System.Windows.Forms.Button();
            this.checkBoxResultados = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular suma desde 1 hasta:";
            // 
            // cuadroNumero
            // 
            this.cuadroNumero.Location = new System.Drawing.Point(193, 25);
            this.cuadroNumero.MaxLength = 7;
            this.cuadroNumero.Name = "cuadroNumero";
            this.cuadroNumero.Size = new System.Drawing.Size(143, 20);
            this.cuadroNumero.TabIndex = 1;
            // 
            // listaResultados
            // 
            this.listaResultados.FormattingEnabled = true;
            this.listaResultados.Location = new System.Drawing.Point(44, 97);
            this.listaResultados.Name = "listaResultados";
            this.listaResultados.Size = new System.Drawing.Size(292, 225);
            this.listaResultados.TabIndex = 2;
            // 
            // botonCalcular
            // 
            this.botonCalcular.Location = new System.Drawing.Point(153, 340);
            this.botonCalcular.Name = "botonCalcular";
            this.botonCalcular.Size = new System.Drawing.Size(75, 23);
            this.botonCalcular.TabIndex = 3;
            this.botonCalcular.Text = "Calcular";
            this.botonCalcular.UseVisualStyleBackColor = true;
            this.botonCalcular.Click += new System.EventHandler(this.botonCalcular_Click);
            // 
            // checkBoxResultados
            // 
            this.checkBoxResultados.AutoSize = true;
            this.checkBoxResultados.Location = new System.Drawing.Point(44, 62);
            this.checkBoxResultados.Name = "checkBoxResultados";
            this.checkBoxResultados.Size = new System.Drawing.Size(138, 17);
            this.checkBoxResultados.TabIndex = 5;
            this.checkBoxResultados.Text = "Ver resultados parciales";
            this.checkBoxResultados.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 375);
            this.Controls.Add(this.checkBoxResultados);
            this.Controls.Add(this.botonCalcular);
            this.Controls.Add(this.listaResultados);
            this.Controls.Add(this.cuadroNumero);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sumatoria de 1 a N";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cuadroNumero;
        private System.Windows.Forms.ListBox listaResultados;
        private System.Windows.Forms.Button botonCalcular;
        private System.Windows.Forms.CheckBox checkBoxResultados;
    }
}

