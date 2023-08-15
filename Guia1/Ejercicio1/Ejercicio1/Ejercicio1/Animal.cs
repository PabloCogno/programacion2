using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Animal
    {
        string nombre;
        string tipo;
        int edad;
        double peso;

        public Animal(string nombre, string tipo, int edad, double peso)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.edad = edad;
            this.peso = peso;
        }

        public string Nombre
        {
            get { return nombre; }  
        }

        public string Tipo
        {
            get { return tipo; }
        }

        public int Edad
        {
            get { return edad; } 
        }

        public double Peso
        { 
            get { return peso; } 
        }

    }
}
