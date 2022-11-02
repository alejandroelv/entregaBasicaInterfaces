namespace Envios
{
    partial class Envio
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
            this.grupoEnvios = new System.Windows.Forms.GroupBox();
            this.radioPaqUrgente = new System.Windows.Forms.RadioButton();
            this.radioPaqNormal = new System.Windows.Forms.RadioButton();
            this.radioCorrNormal = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioFax = new System.Windows.Forms.RadioButton();
            this.radioTelefono = new System.Windows.Forms.RadioButton();
            this.radioEmail = new System.Windows.Forms.RadioButton();
            this.textoEnvio = new System.Windows.Forms.Label();
            this.textoProductos = new System.Windows.Forms.Label();
            this.textoImporteTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.precioProductos = new System.Windows.Forms.Label();
            this.precioEnvio = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.botonCalcular = new System.Windows.Forms.Button();
            this.cuadroPrecioProductos = new System.Windows.Forms.TextBox();
            this.textoCuadroProductos = new System.Windows.Forms.Label();
            this.textoNotificacion = new System.Windows.Forms.Label();
            this.precioNotificacion = new System.Windows.Forms.Label();
            this.grupoEnvios.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupoEnvios
            // 
            this.grupoEnvios.Controls.Add(this.radioPaqUrgente);
            this.grupoEnvios.Controls.Add(this.radioPaqNormal);
            this.grupoEnvios.Controls.Add(this.radioCorrNormal);
            this.grupoEnvios.Location = new System.Drawing.Point(90, 93);
            this.grupoEnvios.Name = "grupoEnvios";
            this.grupoEnvios.Size = new System.Drawing.Size(200, 100);
            this.grupoEnvios.TabIndex = 1;
            this.grupoEnvios.TabStop = false;
            this.grupoEnvios.Text = "Tipo de envío";
            // 
            // radioPaqUrgente
            // 
            this.radioPaqUrgente.AutoSize = true;
            this.radioPaqUrgente.Location = new System.Drawing.Point(20, 81);
            this.radioPaqUrgente.Name = "radioPaqUrgente";
            this.radioPaqUrgente.Size = new System.Drawing.Size(161, 17);
            this.radioPaqUrgente.TabIndex = 2;
            this.radioPaqUrgente.Text = "Paquetería Urgente (+6,99€)";
            this.radioPaqUrgente.UseVisualStyleBackColor = true;
            this.radioPaqUrgente.CheckedChanged += new System.EventHandler(this.radioPaqUrgente_CheckedChanged);
            // 
            // radioPaqNormal
            // 
            this.radioPaqNormal.AutoSize = true;
            this.radioPaqNormal.Location = new System.Drawing.Point(20, 57);
            this.radioPaqNormal.Name = "radioPaqNormal";
            this.radioPaqNormal.Size = new System.Drawing.Size(156, 17);
            this.radioPaqNormal.TabIndex = 1;
            this.radioPaqNormal.Text = "Paquetería Normal (+3,99€)";
            this.radioPaqNormal.UseVisualStyleBackColor = true;
            this.radioPaqNormal.CheckedChanged += new System.EventHandler(this.radioPaqNormal_CheckedChanged);
            // 
            // radioCorrNormal
            // 
            this.radioCorrNormal.AutoSize = true;
            this.radioCorrNormal.Checked = true;
            this.radioCorrNormal.Location = new System.Drawing.Point(20, 33);
            this.radioCorrNormal.Name = "radioCorrNormal";
            this.radioCorrNormal.Size = new System.Drawing.Size(124, 17);
            this.radioCorrNormal.TabIndex = 0;
            this.radioCorrNormal.TabStop = true;
            this.radioCorrNormal.Text = "Correo normal (gratis)";
            this.radioCorrNormal.UseVisualStyleBackColor = true;
            this.radioCorrNormal.CheckedChanged += new System.EventHandler(this.radioCorrNormal_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioFax);
            this.groupBox1.Controls.Add(this.radioTelefono);
            this.groupBox1.Controls.Add(this.radioEmail);
            this.groupBox1.Location = new System.Drawing.Point(90, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 101);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de notificación";
            // 
            // radioFax
            // 
            this.radioFax.AutoSize = true;
            this.radioFax.Location = new System.Drawing.Point(20, 81);
            this.radioFax.Name = "radioFax";
            this.radioFax.Size = new System.Drawing.Size(78, 17);
            this.radioFax.TabIndex = 2;
            this.radioFax.Text = "Fax (1,49€)";
            this.radioFax.UseVisualStyleBackColor = true;
            this.radioFax.CheckedChanged += new System.EventHandler(this.radioFax_CheckedChanged);
            // 
            // radioTelefono
            // 
            this.radioTelefono.AutoSize = true;
            this.radioTelefono.Location = new System.Drawing.Point(20, 57);
            this.radioTelefono.Name = "radioTelefono";
            this.radioTelefono.Size = new System.Drawing.Size(103, 17);
            this.radioTelefono.TabIndex = 1;
            this.radioTelefono.Text = "Teléfono (0,99€)";
            this.radioTelefono.UseVisualStyleBackColor = true;
            this.radioTelefono.CheckedChanged += new System.EventHandler(this.radioTelefono_CheckedChanged);
            // 
            // radioEmail
            // 
            this.radioEmail.AutoSize = true;
            this.radioEmail.Checked = true;
            this.radioEmail.Location = new System.Drawing.Point(20, 33);
            this.radioEmail.Name = "radioEmail";
            this.radioEmail.Size = new System.Drawing.Size(84, 17);
            this.radioEmail.TabIndex = 0;
            this.radioEmail.TabStop = true;
            this.radioEmail.Text = "Email (gratis)";
            this.radioEmail.UseVisualStyleBackColor = true;
            this.radioEmail.CheckedChanged += new System.EventHandler(this.radioEmail_CheckedChanged);
            // 
            // textoEnvio
            // 
            this.textoEnvio.AutoSize = true;
            this.textoEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.textoEnvio.Location = new System.Drawing.Point(369, 180);
            this.textoEnvio.Name = "textoEnvio";
            this.textoEnvio.Size = new System.Drawing.Size(40, 15);
            this.textoEnvio.TabIndex = 2;
            this.textoEnvio.Text = "Envío:";
            // 
            // textoProductos
            // 
            this.textoProductos.AutoSize = true;
            this.textoProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.textoProductos.Location = new System.Drawing.Point(369, 154);
            this.textoProductos.Name = "textoProductos";
            this.textoProductos.Size = new System.Drawing.Size(65, 15);
            this.textoProductos.TabIndex = 3;
            this.textoProductos.Text = "Productos:";
            // 
            // textoImporteTotal
            // 
            this.textoImporteTotal.AutoSize = true;
            this.textoImporteTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textoImporteTotal.Location = new System.Drawing.Point(369, 239);
            this.textoImporteTotal.Name = "textoImporteTotal";
            this.textoImporteTotal.Size = new System.Drawing.Size(90, 17);
            this.textoImporteTotal.TabIndex = 4;
            this.textoImporteTotal.Text = "Importe total:";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(372, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 2);
            this.label3.TabIndex = 5;
            // 
            // precioProductos
            // 
            this.precioProductos.AutoSize = true;
            this.precioProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.precioProductos.Location = new System.Drawing.Point(537, 154);
            this.precioProductos.Name = "precioProductos";
            this.precioProductos.Size = new System.Drawing.Size(38, 15);
            this.precioProductos.TabIndex = 6;
            this.precioProductos.Text = "0,00€";
            // 
            // precioEnvio
            // 
            this.precioEnvio.AutoSize = true;
            this.precioEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.precioEnvio.Location = new System.Drawing.Point(537, 180);
            this.precioEnvio.Name = "precioEnvio";
            this.precioEnvio.Size = new System.Drawing.Size(38, 15);
            this.precioEnvio.TabIndex = 7;
            this.precioEnvio.Text = "0,00€";
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.resultado.Location = new System.Drawing.Point(537, 239);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(0, 17);
            this.resultado.TabIndex = 8;
            // 
            // botonCalcular
            // 
            this.botonCalcular.Location = new System.Drawing.Point(382, 296);
            this.botonCalcular.Name = "botonCalcular";
            this.botonCalcular.Size = new System.Drawing.Size(172, 23);
            this.botonCalcular.TabIndex = 3;
            this.botonCalcular.Text = "Calcular importe total";
            this.botonCalcular.UseVisualStyleBackColor = true;
            this.botonCalcular.Click += new System.EventHandler(this.botonCalcular_Click);
            // 
            // cuadroPrecioProductos
            // 
            this.cuadroPrecioProductos.Location = new System.Drawing.Point(277, 40);
            this.cuadroPrecioProductos.MaxLength = 7;
            this.cuadroPrecioProductos.Name = "cuadroPrecioProductos";
            this.cuadroPrecioProductos.Size = new System.Drawing.Size(120, 20);
            this.cuadroPrecioProductos.TabIndex = 0;
            this.cuadroPrecioProductos.Text = "0,00";
            this.cuadroPrecioProductos.TextChanged += new System.EventHandler(this.cuadroPrecioProductos_TextChanged);
            // 
            // textoCuadroProductos
            // 
            this.textoCuadroProductos.AutoSize = true;
            this.textoCuadroProductos.Location = new System.Drawing.Point(87, 43);
            this.textoCuadroProductos.Name = "textoCuadroProductos";
            this.textoCuadroProductos.Size = new System.Drawing.Size(184, 13);
            this.textoCuadroProductos.TabIndex = 11;
            this.textoCuadroProductos.Text = "Introduzca el precio de los productos:";
            // 
            // textoNotificacion
            // 
            this.textoNotificacion.AutoSize = true;
            this.textoNotificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.textoNotificacion.Location = new System.Drawing.Point(369, 205);
            this.textoNotificacion.Name = "textoNotificacion";
            this.textoNotificacion.Size = new System.Drawing.Size(74, 15);
            this.textoNotificacion.TabIndex = 12;
            this.textoNotificacion.Text = "Notificación:";
            // 
            // precioNotificacion
            // 
            this.precioNotificacion.AutoSize = true;
            this.precioNotificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.precioNotificacion.Location = new System.Drawing.Point(537, 205);
            this.precioNotificacion.Name = "precioNotificacion";
            this.precioNotificacion.Size = new System.Drawing.Size(38, 15);
            this.precioNotificacion.TabIndex = 13;
            this.precioNotificacion.Text = "0,00€";
            // 
            // Envio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 362);
            this.Controls.Add(this.precioNotificacion);
            this.Controls.Add(this.textoNotificacion);
            this.Controls.Add(this.textoCuadroProductos);
            this.Controls.Add(this.cuadroPrecioProductos);
            this.Controls.Add(this.botonCalcular);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.precioEnvio);
            this.Controls.Add(this.precioProductos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textoImporteTotal);
            this.Controls.Add(this.textoProductos);
            this.Controls.Add(this.textoEnvio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grupoEnvios);
            this.Name = "Envio";
            this.Text = "Envio";
            this.grupoEnvios.ResumeLayout(false);
            this.grupoEnvios.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grupoEnvios;
        private System.Windows.Forms.RadioButton radioPaqUrgente;
        private System.Windows.Forms.RadioButton radioPaqNormal;
        private System.Windows.Forms.RadioButton radioCorrNormal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioFax;
        private System.Windows.Forms.RadioButton radioTelefono;
        private System.Windows.Forms.RadioButton radioEmail;
        private System.Windows.Forms.Label textoEnvio;
        private System.Windows.Forms.Label textoProductos;
        private System.Windows.Forms.Label textoImporteTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label precioProductos;
        private System.Windows.Forms.Label precioEnvio;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Button botonCalcular;
        private System.Windows.Forms.TextBox cuadroPrecioProductos;
        private System.Windows.Forms.Label textoCuadroProductos;
        private System.Windows.Forms.Label textoNotificacion;
        private System.Windows.Forms.Label precioNotificacion;
    }
}

