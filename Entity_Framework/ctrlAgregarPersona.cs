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
    public partial class ctrlAgregarPersona : UserControl
    {
        public ctrlAgregarPersona()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var db = new codigo_sabadoEntities();
            personas personas = new personas();

            personas.nombre = tbNombre.Text;
            personas.cedula = tbCedula.Text;

            db.personas.Add(personas);
            MessageBox.Show(""+ personas.nombre+ "  fue agregado exitosamente");
            limpiar(tbNombre, tbCedula);
            
        }
        public void limpiar(TextBox a, TextBox b)
        {
            a.Text = b.Text = string.Empty;


        }
    }
}
