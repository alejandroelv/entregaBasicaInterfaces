namespace SumaWindowsForm
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
            this.iconoSuma = new System.Windows.Forms.Label();
            this.iconoIgual = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.botonCalcular = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.cuadroSumando2 = new System.Windows.Forms.TextBox();
            this.cuadroSumando1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // iconoSuma
            // 
            this.iconoSuma.AutoSize = true;
            this.iconoSuma.Location = new System.Drawing.Point(218, 96);
            this.iconoSuma.Name = "iconoSuma";
            this.iconoSuma.Size = new System.Drawing.Size(13, 13);
            this.iconoSuma.TabIndex = 2;
            this.iconoSuma.Text = "+";
            this.iconoSuma.Click += new System.EventHandler(this.label1_Click);
            // 
            // iconoIgual
            // 
            this.iconoIgual.AutoSize = true;
            this.iconoIgual.Location = new System.Drawing.Point(359, 96);
            this.iconoIgual.Name = "iconoIgual";
            this.iconoIgual.Size = new System.Drawing.Size(13, 13);
            this.iconoIgual.TabIndex = 3;
            this.iconoIgual.Text = "=";
            this.iconoIgual.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(442, 96);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(0, 13);
            this.resultado.TabIndex = 6;
            this.resultado.Visible = false;
            this.resultado.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // botonCalcular
            // 
            this.botonCalcular.Location = new System.Drawing.Point(127, 152);
            this.botonCalcular.Name = "botonCalcular";
            this.botonCalcular.Size = new System.Drawing.Size(75, 23);
            this.botonCalcular.TabIndex = 2;
            this.botonCalcular.Text = "Calcular";
            this.botonCalcular.UseVisualStyleBackColor = true;
            this.botonCalcular.Click += new System.EventHandler(this.botonCalcular_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(244, 152);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.botonLimpiar.TabIndex = 3;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // cuadroSumando2
            // 
            this.cuadroSumando2.Location = new System.Drawing.Point(244, 93);
            this.cuadroSumando2.Name = "cuadroSumando2";
            this.cuadroSumando2.Size = new System.Drawing.Size(100, 20);
            this.cuadroSumando2.TabIndex = 1;
            this.cuadroSumando2.Text = "Segundo sumando";
            this.cuadroSumando2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cuadroSumando2_MouseClick);
            // 
            // cuadroSumando1
            // 
            this.cuadroSumando1.Location = new System.Drawing.Point(102, 93);
            this.cuadroSumando1.Name = "cuadroSumando1";
            this.cuadroSumando1.Size = new System.Drawing.Size(100, 20);
            this.cuadroSumando1.TabIndex = 0;
            this.cuadroSumando1.Text = "Primer sumando";
            this.cuadroSumando1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cuadroSumando1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 209);
            this.Controls.Add(this.cuadroSumando1);
            this.Controls.Add(this.cuadroSumando2);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonCalcular);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.iconoIgual);
            this.Controls.Add(this.iconoSuma);
            this.Name = "Form1";
            this.Text = "Suma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label iconoSuma;
        private System.Windows.Forms.Label iconoIgual;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Button botonCalcular;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.TextBox cuadroSumando2;
        private System.Windows.Forms.TextBox cuadroSumando1;
    }
}

