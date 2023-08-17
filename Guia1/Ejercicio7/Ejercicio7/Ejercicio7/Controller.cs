using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    internal class Controller
    {
        Persona[] listado = new Persona[50];
        int cantidad = 0;

        public bool AgregarPersona(Persona nuevaPersona)
        {
            bool retorno = true;
            if (cantidad < 50)
            {
                listado[cantidad] = nuevaPersona;
                cantidad++;
            }
            else
            {
                retorno = false;
            }
            return retorno;
        }

        public Persona BusquedaXAño(int año) 
        {
            int desde = 0;
            int hasta = cantidad - 1;
            int mitad;
            Persona personaMitad = null;
            int indiceBuscado = -1;

            while (desde <= hasta && indiceBuscado == -1)
            {
                mitad = Convert.ToInt32(Math.Floor(Convert.ToDouble(desde + hasta) / 2));
                personaMitad = listado[mitad];

                if (personaMitad.Año == año)
                {
                    indiceBuscado = mitad;
                }
                if (año > personaMitad.Año)
                {
                    desde = mitad + 1;
                }
                if (año < personaMitad.Año)
                {
                    hasta = mitad - 1;
                }
            }
            return personaMitad;
        }

        public Persona BusquedaXDni(int dni)
        {
            int desde = 0;
            int hasta = cantidad - 1;
            int mitad;
            Persona personaMitad = null;
            int indiceBuscado = -1;

            while (desde <= hasta && indiceBuscado == -1)
            {
                mitad = Convert.ToInt32(Math.Floor(Convert.ToDouble(desde + hasta) / 2));
                personaMitad = listado[mitad];

                if (personaMitad.Dni == dni)
                {
                    indiceBuscado = mitad;
                }
                if (dni > personaMitad.Dni)
                {
                    desde = mitad + 1;
                }
                if (dni < personaMitad.Dni)
                {
                    hasta = mitad - 1;
                }
            }
            return personaMitad;
        }

        public void OrdenamientoXAño() 
        {
            Persona aux = null;

            for (int i = 1; i < cantidad; i++)
            {
                for (int j = 0; j < cantidad - 1 ; j++)
                {
                    if (listado[j].Año > listado[j + 1].Año)
                    {
                        aux = listado[j];
                        listado[j] = listado[j + 1];
                        listado[j + 1] = aux;
                    }
                }
            }
        }

        public void OrdenamientoXDni()
        {
            Persona aux = null;

            for (int i = 1; i < cantidad; i++)
            {
                for (int j = 0; j < cantidad - 1; j++)
                {
                    if (listado[j].Dni > listado[j + 1].Dni)
                    {
                        aux = listado[j];
                        listado[j] = listado[j + 1];
                        listado[j + 1] = aux;
                    }
                }
            }
        }

        public void OrdenamientoXId()
        {

            Persona aux = null;

            for (int i = 1; i < cantidad; i++)
            {
                for (int j = 0; j < cantidad - 1; j++)
                {
                    if (listado[j].Id > listado[j + 1].Id)
                    {
                        aux = listado[j];
                        listado[j] = listado[j + 1];
                        listado[j + 1] = aux;
                    }
                }
            }
        }


    }
}
