using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidacionCedula
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        
        Persona persona; 
        List<Items> lista = new List<Items>();

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            persona = new Persona();
            persona.Nombre = tbNombre.Text;
            Items items = new Items(tbItem.Text);
            persona.AgregarItems(items);
         

            limpiar(tbNombre,tbItem);
            tbItem.Focus();
        }


        private void btnVaciar_Click(object sender, EventArgs e)
        {

            lbDatos.Items.Add( "El señor " + persona.Nombre + " compro: " );
            foreach (var  item in persona.items)
            {
                lbDatos.Items.Add("\t \t" +item.Nombre );
            }
        }


        public void limpiar( TextBox a , TextBox b )
        {
            a.Text = "";
            b.Text = "";
        }

        public void limpiar(TextBox a)
        {
            a.Text = string.Empty;
        }

    }
}
