namespace Servicio_Mensajeria
{
    partial class ctrlEnviarCorreo
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbDestino = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOrigen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTema = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbContrasena = new System.Windows.Forms.TextBox();
            this.tbMensaje = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDestino
            // 
            this.tbDestino.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbDestino.ForeColor = System.Drawing.Color.Black;
            this.tbDestino.Location = new System.Drawing.Point(85, 36);
            this.tbDestino.Name = "tbDestino";
            this.tbDestino.Size = new System.Drawing.Size(100, 20);
            this.tbDestino.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Para";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "De";
            // 
            // tbOrigen
            // 
            this.tbOrigen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbOrigen.ForeColor = System.Drawing.Color.Black;
            this.tbOrigen.Location = new System.Drawing.Point(240, 36);
            this.tbOrigen.Name = "tbOrigen";
            this.tbOrigen.Size = new System.Drawing.Size(100, 20);
            this.tbOrigen.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tema";
            // 
            // tbTema
            // 
            this.tbTema.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbTema.ForeColor = System.Drawing.Color.Black;
            this.tbTema.Location = new System.Drawing.Point(85, 107);
            this.tbTema.Name = "tbTema";
            this.tbTema.Size = new System.Drawing.Size(255, 20);
            this.tbTema.TabIndex = 3;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(265, 312);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Contraseña";
            // 
            // tbContrasena
            // 
            this.tbContrasena.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbContrasena.ForeColor = System.Drawing.Color.Black;
            this.tbContrasena.Location = new System.Drawing.Point(240, 62);
            this.tbContrasena.Name = "tbContrasena";
            this.tbContrasena.Size = new System.Drawing.Size(100, 20);
            this.tbContrasena.TabIndex = 2;
            this.tbContrasena.UseSystemPasswordChar = true;
            // 
            // tbMensaje
            // 
            this.tbMensaje.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbMensaje.ForeColor = System.Drawing.Color.Black;
            this.tbMensaje.Location = new System.Drawing.Point(60, 157);
            this.tbMensaje.Multiline = true;
            this.tbMensaje.Name = "tbMensaje";
            this.tbMensaje.Size = new System.Drawing.Size(268, 128);
            this.tbMensaje.TabIndex = 4;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(159, 312);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // ctrlEnviarCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.tbMensaje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbContrasena);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTema);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbOrigen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDestino);
            this.Name = "ctrlEnviarCorreo";
            this.Size = new System.Drawing.Size(358, 387);
            this.Load += new System.EventHandler(this.ctrlEnviarCorreo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOrigen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTema;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbContrasena;
        private System.Windows.Forms.TextBox tbMensaje;
        private System.Windows.Forms.Button btnCerrar;
    }
}
