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

        static public string origenNombre(string padre, string madre)
        {
            return padre + madre;
        }
    }
}
