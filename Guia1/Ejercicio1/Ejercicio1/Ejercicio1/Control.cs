using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Control
    {
        Animal[] lista = new Animal[20]; //maximo 20 animales
        int cantidad = 0; //para recorrer vector

        public bool AgregarAnimal(Animal nuevo)
        {
            bool retorno = true; //si se puede agregar retorna true.
            if (cantidad < 20)
            {
                lista[cantidad] = nuevo; //agrego parametro recibido a la lista
                cantidad++;
            }
            else
            {
                retorno = false; //en caso de que no se pueda retorna false
            }
            
            return retorno;
        }

        public Animal[] VerTipo(string tipo)
        {
            Animal[] retorno; //crea un vector de tipo animal
            int c = 0; // contador para recorrer vector

            for (int i = 0; i < cantidad; i++)
            {
                if (lista[i].Tipo == tipo)
                {
                    c++;//si el tipo es igual a la del parametro incrementa el contador
                }
            }
            retorno = new Animal[c]; // crea un vecto de tamañao c (contador)
            int cumple = 0; //contador para el nuevo vector.
            if (c != 0) //verifico si hay en el vector de tipo parametro
            {
                for (int i = 0; i < cantidad; i++)
                {
                    if (lista[i].Tipo == tipo)
                    {
                        retorno[cumple] = lista[i];
                        cumple++;
                    }
                }
            }
            return retorno;

        }
    }
}
