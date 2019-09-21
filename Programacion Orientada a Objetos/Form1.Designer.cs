namespace Programacion_Orientada_a_Objetos
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
            this.lb_DB = new System.Windows.Forms.ListBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_cedula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_notaEspa = new System.Windows.Forms.TextBox();
            this.tb_notaMate = new System.Windows.Forms.TextBox();
            this.tb_notaSocia = new System.Windows.Forms.TextBox();
            this.tb_notaNatu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_Promedio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lb_DB
            // 
            this.lb_DB.FormattingEnabled = true;
            this.lb_DB.Location = new System.Drawing.Point(449, 39);
            this.lb_DB.Name = "lb_DB";
            this.lb_DB.Size = new System.Drawing.Size(286, 329);
            this.lb_DB.TabIndex = 0;
            this.lb_DB.SelectedIndexChanged += new System.EventHandler(this.lb_DB_SelectedIndexChanged);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(187, 361);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 1;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(81, 31);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(36, 20);
            this.tb_id.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cedula";
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(81, 57);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(100, 20);
            this.tb_nombre.TabIndex = 6;
            this.tb_nombre.TextChanged += new System.EventHandler(this.tb_nombre_TextChanged);
            // 
            // tb_cedula
            // 
            this.tb_cedula.Location = new System.Drawing.Point(81, 101);
            this.tb_cedula.Name = "tb_cedula";
            this.tb_cedula.Size = new System.Drawing.Size(100, 20);
            this.tb_cedula.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Español";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Matematicas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(240, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sociales";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(325, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Naturales";
            // 
            // tb_notaEspa
            // 
            this.tb_notaEspa.Location = new System.Drawing.Point(81, 254);
            this.tb_notaEspa.Name = "tb_notaEspa";
            this.tb_notaEspa.Size = new System.Drawing.Size(42, 20);
            this.tb_notaEspa.TabIndex = 14;
            // 
            // tb_notaMate
            // 
            this.tb_notaMate.Location = new System.Drawing.Point(165, 254);
            this.tb_notaMate.Name = "tb_notaMate";
            this.tb_notaMate.Size = new System.Drawing.Size(42, 20);
            this.tb_notaMate.TabIndex = 18;
            // 
            // tb_notaSocia
            // 
            this.tb_notaSocia.Location = new System.Drawing.Point(245, 254);
            this.tb_notaSocia.Name = "tb_notaSocia";
            this.tb_notaSocia.Size = new System.Drawing.Size(42, 20);
            this.tb_notaSocia.TabIndex = 19;
            // 
            // tb_notaNatu
            // 
            this.tb_notaNatu.Location = new System.Drawing.Point(335, 254);
            this.tb_notaNatu.Name = "tb_notaNatu";
            this.tb_notaNatu.Size = new System.Drawing.Size(42, 20);
            this.tb_notaNatu.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(183, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 24);
            this.label9.TabIndex = 21;
            this.label9.Text = "Notas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(514, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 24);
            this.label10.TabIndex = 22;
            this.label10.Text = "Base de datos";
            // 
            // lb_Promedio
            // 
            this.lb_Promedio.AutoSize = true;
            this.lb_Promedio.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Promedio.ForeColor = System.Drawing.Color.Red;
            this.lb_Promedio.Location = new System.Drawing.Point(208, 302);
            this.lb_Promedio.Name = "lb_Promedio";
            this.lb_Promedio.Size = new System.Drawing.Size(20, 24);
            this.lb_Promedio.TabIndex = 23;
            this.lb_Promedio.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(243, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 116);
            this.panel1.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 418);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_Promedio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_notaNatu);
            this.Controls.Add(this.tb_notaSocia);
            this.Controls.Add(this.tb_notaMate);
            this.Controls.Add(this.tb_notaEspa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_cedula);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.lb_DB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_DB;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.TextBox tb_cedula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_notaEspa;
        private System.Windows.Forms.TextBox tb_notaMate;
        private System.Windows.Forms.TextBox tb_notaSocia;
        private System.Windows.Forms.TextBox tb_notaNatu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_Promedio;
        private System.Windows.Forms.Panel panel1;
    }
}

