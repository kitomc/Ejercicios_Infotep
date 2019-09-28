using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Framework
{
    static class Utilidades
    {

        static public void limpiar(TextBox a, TextBox b)
        {
            a.Text = b.Text = string.Empty;


        }

        static public void Mostrar(Panel contenedor, Control contenido)
        {
            contenedor.Contains(contenido);
            contenedor.Controls.Add(contenido);
            contenido.BringToFront();

        }

        static public string validadorNombre (string nombre)
        {

            nombre.Trim();
            nombre.Replace("-", "");
            nombre.Replace(" ", "");
            nombre.TrimEnd();
            nombre.TrimStart();

            return nombre;

        }
            

        static public int validadorCedula(string cedula)
        {
            int sumaPares = 0;
            int sumaImpares = 0;
            int tmp = 0;

            int digito = 0;

            // sumamos los pares
            for (int i = 2; i <= 8; i += 2)
            {
                sumaPares = sumaPares + int.Parse(cedula.Substring(i - 1, 1));
            }

            for (int i = 1; i <= 9; i += 2)
            {
                tmp = int.Parse(cedula.Substring(i - 1, 1)) * 2;
                if (tmp > 9)
                    tmp = tmp - 9;
                sumaImpares = sumaImpares + tmp;
            }
            digito = 10 - ((sumaPares + sumaImpares) % 10);
            if (digito == 10)
            

                digito = 0;
                

            
           
            return digito;



            
        }
    }
}
