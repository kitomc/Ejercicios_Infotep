using System;
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
    public partial class ctrlEditarPersona : UserControl
    {
        public ctrlEditarPersona()
        {
            InitializeComponent();
        }

        string nomTemp;
        string cedTemp;
        private void ctrlEditarPersona_Load(object sender, EventArgs e)
        {
        var db = new codigo_sabadoEntities();
         dgv.DataSource = db.personas.ToList();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbNombre.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
           

            tbCedula.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            lbId.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int a = int.Parse( lbId.Text);
            var db = new codigo_sabadoEntities();
            var datos = db.personas
                .Where(c => c.id == a )
                .FirstOrDefault<personas>();

            datos.nombre = tbNombre.Text;
            datos.cedula = tbCedula.Text;
            db.personas.Add(datos);
            db.SaveChanges();
            dgv.DataSource = db.personas.ToList();
            MessageBox.Show("Registro modificado");
            Utilidades.limpiar(tbCedula, tbNombre);


        } 
    }
}
