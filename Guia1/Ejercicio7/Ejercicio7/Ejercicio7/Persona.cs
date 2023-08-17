using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Persona
    {
        string nombre;
        string apellido;
        int año;
        int dni;
        static int id = id + 1;

        public Persona(string nombre, string apellido, int año, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.año = año;
            this.dni = dni;
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public string Apellido
        {
            get { return apellido; }
        }

        public int Año 
        {
            get { return año; }
        }

        public int Dni 
        {
            get { return dni; }
        }

        public int Id
        {
            get { return id; }
        }
    }
}
