using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacionCedula
{
  public  class Items
    {
        string nombre;


        public Items( string Nombre) { }

        public string Nombre 
        {
            get { return nombre ; }
            set { nombre = value; }
        }

    }
}
