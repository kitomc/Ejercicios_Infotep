using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;


namespace Servicio_Mensajeria
{
    public partial class ctrlEnviarCorreo : UserControl
    {
        public ctrlEnviarCorreo()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            string host = "smtp."+ Utilidades.SelectorHost(tbOrigen.Text) + ".com";


            Utilidades.EnviarMensaje(message, smtp, tbOrigen.Text, tbTema.Text, tbMensaje.Text, host, tbDestino.Text, tbContrasena.Text);
            Utilidades.Limpiar(tbContrasena, tbDestino, tbMensaje, tbTema, tbOrigen);
            MessageBox.Show("Mensaje enviado");

        }

        private void ctrlEnviarCorreo_Load(object sender, EventArgs e)
        {

        }
    }
}
