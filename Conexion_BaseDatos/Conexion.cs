using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Conexion_BaseDatos
{
    class Conexion
    {


        string cc = @"Data Source=INFOTEP\SQLEXPRESS;Initial Catalog=codigo_sabado;Integrated Security=True";

        public DataTable consular()
        {
            SqlConnection con = new SqlConnection(cc);  //conexion
            SqlDataAdapter oda = new SqlDataAdapter();  //Adaptador
            DataTable odt = new DataTable();            //Tabal virtual   


            SqlCommand ocmd = con.CreateCommand();         //comando
            ocmd.CommandText = "Select id,nombre,cedula from personas";
            oda.SelectCommand = ocmd;
            oda.Fill(odt);
            return odt;
        }


        public DataTable Agregar (string Nombre , string Cedula)
        {
            SqlConnection con = new SqlConnection(cc);
            SqlDataAdapter oda = new SqlDataAdapter();
            DataTable odt = new DataTable();

            SqlCommand ocmd = con.CreateCommand();
            ocmd.CommandText = "insert into personas(nombre, cedula) values('"+ Nombre +"', '"+ Cedula +"')";
            oda.SelectCommand = ocmd;
            oda.Fill(odt);
            return odt;
        }



     
    }
}
