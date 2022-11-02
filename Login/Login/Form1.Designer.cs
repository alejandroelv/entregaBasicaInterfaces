namespace Login
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
            this.cuadroUsuario = new System.Windows.Forms.TextBox();
            this.cuadroContrasenia = new System.Windows.Forms.TextBox();
            this.etiquetaContrasenia = new System.Windows.Forms.Label();
            this.etiquetaUsuario = new System.Windows.Forms.Label();
            this.botonAutenticar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cuadroUsuario
            // 
            this.cuadroUsuario.Location = new System.Drawing.Point(89, 58);
            this.cuadroUsuario.Name = "cuadroUsuario";
            this.cuadroUsuario.Size = new System.Drawing.Size(143, 20);
            this.cuadroUsuario.TabIndex = 0;
            // 
            // cuadroContrasenia
            // 
            this.cuadroContrasenia.Location = new System.Drawing.Point(89, 104);
            this.cuadroContrasenia.Name = "cuadroContrasenia";
            this.cuadroContrasenia.PasswordChar = '*';
            this.cuadroContrasenia.Size = new System.Drawing.Size(143, 20);
            this.cuadroContrasenia.TabIndex = 1;
            // 
            // etiquetaContrasenia
            // 
            this.etiquetaContrasenia.AutoSize = true;
            this.etiquetaContrasenia.Location = new System.Drawing.Point(12, 107);
            this.etiquetaContrasenia.Name = "etiquetaContrasenia";
            this.etiquetaContrasenia.Size = new System.Drawing.Size(61, 13);
            this.etiquetaContrasenia.TabIndex = 2;
            this.etiquetaContrasenia.Text = "Contraseña";
            // 
            // etiquetaUsuario
            // 
            this.etiquetaUsuario.AutoSize = true;
            this.etiquetaUsuario.Location = new System.Drawing.Point(31, 61);
            this.etiquetaUsuario.Name = "etiquetaUsuario";
            this.etiquetaUsuario.Size = new System.Drawing.Size(43, 13);
            this.etiquetaUsuario.TabIndex = 3;
            this.etiquetaUsuario.Text = "Usuario";
            // 
            // botonAutenticar
            // 
            this.botonAutenticar.Location = new System.Drawing.Point(118, 160);
            this.botonAutenticar.Name = "botonAutenticar";
            this.botonAutenticar.Size = new System.Drawing.Size(75, 23);
            this.botonAutenticar.TabIndex = 2;
            this.botonAutenticar.Text = "Autenticarse";
            this.botonAutenticar.UseVisualStyleBackColor = true;
            this.botonAutenticar.Click += new System.EventHandler(this.botonAutenticar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 213);
            this.Controls.Add(this.botonAutenticar);
            this.Controls.Add(this.etiquetaUsuario);
            this.Controls.Add(this.etiquetaContrasenia);
            this.Controls.Add(this.cuadroContrasenia);
            this.Controls.Add(this.cuadroUsuario);
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cuadroUsuario;
        private System.Windows.Forms.TextBox cuadroContrasenia;
        private System.Windows.Forms.Label etiquetaContrasenia;
        private System.Windows.Forms.Label etiquetaUsuario;
        private System.Windows.Forms.Button botonAutenticar;
    }
}

