using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicio_Mensajeria
{
    public partial class ctrlStringBuilder : UserControl
    {
        public ctrlStringBuilder()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            Utilidades.ContructorString(sb,tbNombre.Text,tbApellido.Text,tbEdad.Text , dtpCalendario.Text, cbGenero.Text,tbTelefono.Text);
            Utilidades.Limpiar(tbApellido, tbEdad, tbNombre, tbTelefono,tbApellido );
        }
    }
}
