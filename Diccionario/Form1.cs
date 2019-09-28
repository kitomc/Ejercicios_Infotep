using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diccionario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
        //    if (Combinacion1 =1 )
        //    {

        //    }
        //    Combinacion1(cbSistemaOperativo,cbIde,cbLenguaje); 
        //    Combinacion2(cbSistemaOperativo, cbIde, cbLenguaje);
        //    Combinacion3(cbSistemaOperativo, cbIde, cbLenguaje);
        //    Combinacion4(cbSistemaOperativo, cbIde, cbLenguaje);
        //    Combinacion5(cbSistemaOperativo, cbIde, cbLenguaje);
        //    Combinacion6(cbSistemaOperativo, cbIde, cbLenguaje);
        //    Combinacion7(cbSistemaOperativo, cbIde, cbLenguaje);
        //    Combinacion8(cbSistemaOperativo, cbIde, cbLenguaje);
        //    Combinacion9(cbSistemaOperativo, cbIde, cbLenguaje);
        //    Combinacion10(cbSistemaOperativo, cbIde, cbLenguaje);
        //    Combinacion11(cbSistemaOperativo, cbIde, cbLenguaje);
        //    Combinacion12(cbSistemaOperativo, cbIde, cbLenguaje);



        //}

        private void Form1_Load(object sender, EventArgs e)
        {

            Dictionary<string, string> SistemaOperativo = new Dictionary<string, string>();
            Dictionary<string, string> Ide = new Dictionary<string, string>();
            Dictionary<string, string> Lenguaje = new Dictionary<string, string>();

            SistemaOperativo.Add("GNU/Linux", "GL");
            SistemaOperativo.Add("Microsoft Windows", "MW");
            SistemaOperativo.Add("Mac OS", "MO");

            Ide.Add("Eclipse", "E");
            Ide.Add("NetBeans", "N");
            Ide.Add("Visual Studio", "V");
            Ide.Add("Xcode", "X");


            Lenguaje.Add("C Sharp", "C#");
            Lenguaje.Add("Visual Basic", "VB");
            Lenguaje.Add("Java", "JA");
            Lenguaje.Add("PHP", "PP");
            Lenguaje.Add("Swift", "ST");
            Lenguaje.Add("Objective-C", "OC");

            cbSistemaOperativo.DataSource = SistemaOperativo.ToList();
            cbSistemaOperativo.ValueMember = "value";
            cbSistemaOperativo.DisplayMember = "key";

            cbIde.DataSource = Ide.ToList();
            cbIde.ValueMember = "value";
            cbIde.DisplayMember = "key";

            cbLenguaje.DataSource = Lenguaje.ToList();
            cbLenguaje.ValueMember = "value";
            cbLenguaje.DisplayMember = "key";


        }

        public int Combinacion1(ListControl SistemaOperativo ,ComboBox Ide, ComboBox Lenguaje)
        {
            if (SistemaOperativo.SelectedValue == "GL" && Ide.SelectedValue == "E" && Lenguaje.SelectedValue == "JA") 

            {
                MessageBox.Show("Combinacion Valida");
                return 1;
            }
            else
            {
                MessageBox.Show("Combinacion Invalida");

                return 0;
            }
        }

        public void Combinacion2(ComboBox SistemaOperativo, ComboBox Ide, ComboBox Lenguaje)
        {
            if (SistemaOperativo.SelectedValue == "GL" && Ide.SelectedValue == "E" && Lenguaje.SelectedValue == "PP")

            {
                MessageBox.Show("Combinacion Valida");
            }
            else
            {
                MessageBox.Show("Combinacion Invalida");
            }
        }
            //        public void Combinacion3(ComboBox SistemaOperativo, ComboBox Ide, ComboBox Lenguaje)
            //        {
            //            if (SistemaOperativo.SelectedValue == "GL" && Ide.SelectedValue == "N" && Lenguaje.SelectedValue == "JA")

            //            {
            //                MessageBox.Show("Combinacion Valida");
            //            }
            //            else
            //            {
            //                MessageBox.Show("Combinacion Invalida");
            //            }
            //        }
            //        public void Combinacion4(ComboBox SistemaOperativo, ComboBox Ide, ComboBox Lenguaje)
            //        {
            //            if (SistemaOperativo.SelectedValue == "GL" && Ide.SelectedValue == "N" && Lenguaje.SelectedValue == "PP")

            //            {
            //                MessageBox.Show("Combinacion Valida");
            //            }
            //            else
            //            {
            //                MessageBox.Show("Combinacion Invalida");
            //            }
            //        }
            //        public void Combinacion5(ComboBox SistemaOperativo, ComboBox Ide, ComboBox Lenguaje)
            //        {
            //            if (SistemaOperativo.SelectedValue == "MW" && Ide.SelectedValue == "E" && Lenguaje.SelectedValue == "JA")

            //            {
            //                MessageBox.Show("Combinacion Valida");
            //            }
            //            else
            //            {
            //                MessageBox.Show("Combinacion Invalida");
            //            }
            //        }
            //        public void Combinacion6(ComboBox SistemaOperativo, ComboBox Ide, ComboBox Lenguaje)
            //        {
            //            if (SistemaOperativo.SelectedValue == "MW" && Ide.SelectedValue == "E" && Lenguaje.SelectedValue == "PP")

            //            {
            //                MessageBox.Show("Combinacion Valida");
            //            }
            //            else
            //            {
            //                MessageBox.Show("Combinacion Invalida");
            //            }
            //        }
            //        public void Combinacion7(ComboBox SistemaOperativo, ComboBox Ide, ComboBox Lenguaje)
            //        {
            //            if (SistemaOperativo.SelectedValue == "MW" && Ide.SelectedValue == "N" && Lenguaje.SelectedValue == "JA")

            //            {
            //                MessageBox.Show("Combinacion Valida");
            //            }
            //            else
            //            {
            //                MessageBox.Show("Combinacion Invalida");
            //            }
            //        }
            //        public void Combinacion8(ComboBox SistemaOperativo, ComboBox Ide, ComboBox Lenguaje)
            //        {
            //            if (SistemaOperativo.SelectedValue == "MW" && Ide.SelectedValue == "N" && Lenguaje.SelectedValue == "PP")

            //            {
            //                MessageBox.Show("Combinacion Valida");
            //            }
            //            else
            //            {
            //                MessageBox.Show("Combinacion Invalida");
            //            }
            //        }
            //        public void Combinacion9(ComboBox SistemaOperativo, ComboBox Ide, ComboBox Lenguaje)
            //        {
            //            if (SistemaOperativo.SelectedValue == "MW" && Ide.SelectedValue == "V" && Lenguaje.SelectedValue == "C#")

            //            {
            //                MessageBox.Show("Combinacion Valida");
            //            }
            //            else
            //            {
            //                MessageBox.Show("Combinacion Invalida");
            //            }
            //        }
            //        public void Combinacion10(ComboBox SistemaOperativo, ComboBox Ide, ComboBox Lenguaje)
            //        {
            //            if (SistemaOperativo.SelectedValue == "MW" && Ide.SelectedValue == "V" && Lenguaje.SelectedValue == "VB")

            //            {
            //                MessageBox.Show("Combinacion Valida");
            //            }
            //            else
            //            {
            //                MessageBox.Show("Combinacion Invalida");
            //            }
            //        }
            //        public void Combinacion11(ComboBox SistemaOperativo, ComboBox Ide, ComboBox Lenguaje)
            //        {
            //            if (SistemaOperativo.SelectedValue == "MO" && Ide.SelectedValue == "X" && Lenguaje.SelectedValue == "ST")

            //            {
            //                MessageBox.Show("Combinacion Valida");
            //            }
            //            else
            //            {
            //                MessageBox.Show("Combinacion Invalida");
            //            }
            //        }
            //        public void Combinacion12(ComboBox SistemaOperativo, ComboBox Ide, ComboBox Lenguaje)
            //        {
            //            if (SistemaOperativo.SelectedValue == "MO" && Ide.SelectedValue == "X" && Lenguaje.SelectedValue == "OC")

            //            {
            //                MessageBox.Show("Combinacion Valida");
            //            }
            //            else
            //            {
            //                MessageBox.Show("Combinacion Invalida");
            //            }
            //        }

        }
    }
