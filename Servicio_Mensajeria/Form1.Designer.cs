namespace Servicio_Mensajeria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCrearCorreo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlIzquierdo = new System.Windows.Forms.Panel();
            this.pnlIzquierdo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrearCorreo
            // 
            this.btnCrearCorreo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCrearCorreo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCrearCorreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCrearCorreo.BorderRadius = 0;
            this.btnCrearCorreo.ButtonText = "Crear Correo";
            this.btnCrearCorreo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearCorreo.DisabledColor = System.Drawing.Color.Gray;
            this.btnCrearCorreo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCrearCorreo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCrearCorreo.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCrearCorreo.Iconimage")));
            this.btnCrearCorreo.Iconimage_right = null;
            this.btnCrearCorreo.Iconimage_right_Selected = null;
            this.btnCrearCorreo.Iconimage_Selected = null;
            this.btnCrearCorreo.IconMarginLeft = 0;
            this.btnCrearCorreo.IconMarginRight = 0;
            this.btnCrearCorreo.IconRightVisible = true;
            this.btnCrearCorreo.IconRightZoom = 0D;
            this.btnCrearCorreo.IconVisible = true;
            this.btnCrearCorreo.IconZoom = 90D;
            this.btnCrearCorreo.IsTab = false;
            this.btnCrearCorreo.Location = new System.Drawing.Point(23, 45);
            this.btnCrearCorreo.Name = "btnCrearCorreo";
            this.btnCrearCorreo.Normalcolor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCrearCorreo.OnHovercolor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCrearCorreo.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnCrearCorreo.selected = false;
            this.btnCrearCorreo.Size = new System.Drawing.Size(93, 35);
            this.btnCrearCorreo.TabIndex = 0;
            this.btnCrearCorreo.Text = "Crear Correo";
            this.btnCrearCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearCorreo.Textcolor = System.Drawing.Color.Black;
            this.btnCrearCorreo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCorreo.Click += new System.EventHandler(this.btnCrearCorreo_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlContenedor.Location = new System.Drawing.Point(132, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(358, 387);
            this.pnlContenedor.TabIndex = 7;
            // 
            // pnlIzquierdo
            // 
            this.pnlIzquierdo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlIzquierdo.Controls.Add(this.btnCrearCorreo);
            this.pnlIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.pnlIzquierdo.Name = "pnlIzquierdo";
            this.pnlIzquierdo.Size = new System.Drawing.Size(133, 387);
            this.pnlIzquierdo.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 387);
            this.Controls.Add(this.pnlIzquierdo);
            this.Controls.Add(this.pnlContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlIzquierdo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btnCrearCorreo;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel pnlIzquierdo;
    }
}

