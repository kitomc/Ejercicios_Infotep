using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace Servicio_Mensajeria
{
   static class Utilidades
    {


    public static void EnviarMensaje( MailMessage message,SmtpClient smtp, string correoOrigen,string Tema , string Mensaje , string host , string correoDestino , string Contrasena )
        {
            message.From = new MailAddress(correoOrigen);
            message.To.Add(new MailAddress(correoDestino));
            message.Subject = Tema;
            message.IsBodyHtml = false;
            message.Body = Mensaje;

            smtp.Port = 587;
            smtp.Host = host;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(correoOrigen, Contrasena);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(message);

            
        }


        public static void ContructorString( StringBuilder builder,string Nombre,string Apellido,string Edad, string FechaNacimiento , string Genero, string Telefono)
        {

            builder.Append("Hola ");
            builder.Append("Mi nombre es ");
            builder.Append(Nombre);
            builder.Append (" ");
            builder.Append(Apellido);
            builder.Append("Tengo ");
            builder.Append(Edad);
            builder.Append(" de edad y mi fecha de nacimiento es ");
            builder.Append( FechaNacimiento );
           MessageBox.Show(builder.ToString());
        }


        public static bool MostrarPNL( Panel Contenedor , Control Contenido)
        {

            Contenedor.Contains(Contenido);
            Contenedor.Controls.Add(Contenido);
            Contenido.BringToFront();
            Contenido.Dock = DockStyle.Fill;

            return true;

        }

        public static string SelectorHost(string correo)
        {
            string selecctor;

            if (correo.Contains("gmail"))
            {
                selecctor = "gmail";

            }
            else if (correo.Contains("hotmail") || correo.Contains("live"))
            {
                selecctor = "live";
            }
            else
            {

                MessageBox.Show(" Host no valido");
                selecctor = "";
            }

            return selecctor;

        }



        public static void Limpiar(TextBox a , TextBox b,TextBox c, TextBox d,TextBox t )
        {

            a.Text = b.Text = c.Text = d.Text = t.Text  = string.Empty;


        }

    }
}
