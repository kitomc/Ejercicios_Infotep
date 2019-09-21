using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion_Orientada_a_Objetos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Estudiante estudiante = new Estudiante();

        private void btn_Agregar_Click(object sender, EventArgs e)
        {

        



            estudiante.Id = int.Parse(tb_id.Text);
            estudiante.Nombre = tb_nombre.Text;
            estudiante.Cedula = tb_cedula.Text;
            estudiante.Matematica = int.Parse(tb_notaMate.Text);
            estudiante.Naturales = int.Parse(tb_notaNatu.Text);
            estudiante.Sociales = int.Parse(tb_notaSocia.Text);
            estudiante.Espanol = int.Parse(tb_notaEspa.Text);

            AgregarBase();

           LimpiarCampos();

        }


     

        public void AgregarBase()
        {

            lb_DB.Items.Add( estudiante.Id + ("\t") + estudiante.Nombre + ("\t") + estudiante.Cedula  + ("\t") + estudiante.Promedio() ).ToString();
            lb_Promedio.Text = estudiante.Promedio().ToString();
        }


        public void formatoDB()
        {

            lb_DB.Items.Add("Id" +("\t")+ "Nombre" + ("\t")+ "Cedula"+("\t")+("\t") + "Nota Promedio").ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formatoDB();
        }
        public void LimpiarCampos()
        {
            tb_id.Text = "";
            tb_cedula.Text = "";
            tb_nombre.Text = "";
            tb_notaEspa.Text = "";
            tb_notaMate.Text = "";
            tb_notaNatu.Text = "";
            tb_notaSocia.Text = "";
            tb_id.Focus();
        }

        private void tb_nombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void lb_DB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }


}
