using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conexion_BaseDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Conexion conexion = new Conexion();

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_data.DataSource = conexion.consular();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(tbNombre.Text.Trim())||string.IsNullOrEmpty(tbCedula.Text.Trim()))
            {
                MessageBox.Show("Error Critico, los campos no pueden estar vacios, Intente de nuevo", "Errror Critico Error ", MessageBoxButtons.RetryCancel);
            }
            else
            {
            conexion.Agregar(tbNombre.Text.Trim(), tbCedula.Text.Trim());

            Limpiar(tbNombre, tbCedula);
            actualizar();

            }


            //if (validadorNULL(tbNombre,tbCedula)==false)
            //{
            //}
            //else
            //{
            //Limpiar(tbNombre, tbCedula);
            //actualizar();

            //}

        }


        //Funciones y metodos

        public void actualizar()
        {
            dgv_data.DataSource = conexion.consular();
        }

        public void Limpiar(TextBox a ,TextBox b)
        {
            a.Text = string.Empty;
            b.Text = string.Empty;


        }



        public bool validadorNULL(TextBox a ,TextBox b)
        {
            bool x=false;

            if (a.Text == string.Empty || b.Text == string.Empty)
            {
                MessageBox.Show("Error Critico, los campos no pueden estar vacios, Intente de nuevo","Errror Critico Error ",MessageBoxButtons.RetryCancel);
                x = true;
            }
            return x;

        }

    }
}
