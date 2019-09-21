using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string nom , ape,cedu, telefono;
        int edad ;

        private void Form1_Load(object sender, EventArgs e)
        {
            lbData.Items.Add("Nombre \t Apellido\t Edad\t Cedula\t\t Telefono\t \n");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            telefono = ValidadorEspacio(tbTelefono);
            nom = ValidadorEspacio(tbNombre) ;
            ape = ValidadorEspacio(tbApellido);
            edad = ValidarNumeros(tbEdad);
            cedu = ValidadorEspacio(tbCedula);

            LetrasValidador(telefono);
            LetrasValidador(nom);
            LetrasValidador(ape);
            LetrasValidador(cedu);


            limpiar(tbApellido, tbTelefono, tbEdad, tbNombre,tbCedula);
            tbNombre.Focus();
            lbData.Items.Add(nom +"\t"+ ape + "\t" + edad + "\t" +cedu + "\t" +telefono);
        }




        public int ValidarNumeros(TextBox n1)
        {
            int a;
            if (int.tryParse(n1.Text))
            {
                MessageBox.Show("Error, debe ingresar Numeros en este campo");

            }
           

            return a;
        }


        public string ValidadorEspacio(TextBox n1)
        {

            string res;
            
            
            if (string.IsNullOrEmpty(n1.Text))
            {
                MessageBox.Show("Error, el campo no debe estar vacio");
            }

            
            else
            {
            res = n1.Text.Trim().Replace(" ","");
            ape = res;
            }
            return ape ;
           

            
        }


        public void limpiar(TextBox a, TextBox b, TextBox c, TextBox d,TextBox e)
        {

            a.Text = string.Empty;
            b.Text = string.Empty;
            c.Text = string.Empty;
            d.Text = string.Empty;
            e.Text = string.Empty;



        }



        public void LetrasValidador(string palabra)
        {
            bool sentencia = true;

            foreach (char item in palabra)
            {
                if (!char.IsLetter(item))
                {
                    sentencia = false;
                }
            }

                    if (sentencia == false)
                    {
                        MessageBox.Show("Ingresar solo letra en este campo");
                limpiar(tbApellido, tbTelefono, tbEdad, tbNombre, tbCedula);
                    }



        }
    }
}
