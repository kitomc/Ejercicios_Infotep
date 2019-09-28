﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Framework
{
    public partial class ctrlEliminarPersona : UserControl
    {
        public ctrlEliminarPersona()
        {
            InitializeComponent();
        }

        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int a = int.Parse(lbId.Text);

            var db = new codigo_sabadoEntities();
            var datos = db.personas
                .Where(c => c.id == a)
                .FirstOrDefault<personas>();

            datos.nombre = lbNombre.Text;
            datos.cedula = lbCedula.Text;
            db.personas.Remove(datos);
            db.SaveChanges();
            dgv.DataSource = db.personas.ToList();
            MessageBox.Show("Registro Eliminado");
            a = 0;
           
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbNombre.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();

            lbCedula.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            lbId.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void ctrlEliminarPersona_Load(object sender, EventArgs e)
        {
            var db = new codigo_sabadoEntities();
            dgv.DataSource = db.personas.ToList();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
