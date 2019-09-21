using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_Orientada_a_Objetos
{
    public class Estudiante
    {
        //Campos
        string nombre;
        int id;
        string cedula;
        int espanol;
        int matematicas;
        int sociales;
        int naturales;

        //Propiedades
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Cedula
        {
            get { return cedula; }
            set { cedula =  value; }
        }

        public int Espanol
        { get { return espanol; } set { espanol = value; } }

        public int Matematica
        {
            get { return matematicas; }
            set { matematicas = value; }
        }

        public int Sociales
        { get { return sociales; } set { sociales = value; } }

        public int Naturales
        { get { return naturales; } set { naturales = value; } }

        //constructor

        public Estudiante() { }


        //Funciones y Metodos


        public double Promedio()
        {
            return (espanol + sociales + matematicas + naturales) / 4;
        }

    }
}
