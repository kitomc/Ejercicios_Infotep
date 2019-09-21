using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacionCedula
{
   public class Persona
    {

        string nombre;
        public List<Items> items = new List<Items>();
       
        public Persona() {
        }

        public String Nombre { get { return nombre; } set {nombre = value ;} }

        public void AgregarItems( Items ParamItems )
        {
          
            items.Add(ParamItems);
        }

       

       

    }
}
