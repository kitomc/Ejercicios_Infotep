using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Framework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public void Mostrar(Panel contenedor , Control contenido)
        {
            contenedor.Contains(contenido);
            contenedor.Controls.Add(contenido);
            contenido.BringToFront();

        }



        public void limpiar (TextBox a,  TextBox b)
        {
            a.Text = b.Text = string.Empty;


        }

        private void btnRegistrarPersona_Click(object sender, EventArgs e)
        {
            ctrlAgregarPersona ctrlAgregarPersona = new ctrlAgregarPersona();
            Mostrar(pnlContenedor,ctrlAgregarPersona);
        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ctrlEditarPersona ctrlEditarPersona = new ctrlEditarPersona();
            Utilidades.Mostrar(pnlContenedor, ctrlEditarPersona);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ctrlEliminarPersona ctrlEliminarPersona = new ctrlEliminarPersona();
            Utilidades.Mostrar(pnlContenedor , ctrlEliminarPersona);
        }
    }
}
