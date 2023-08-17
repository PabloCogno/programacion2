using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Control
    {
        int[] vector = new int[10];
        int cantidad = 0;

        public bool AgregarNumero(int numero)
        {
            bool retorno = true;
            if (cantidad < 10)
            {
                vector[cantidad] = numero;
                cantidad++;
            }
            else 
            {
                retorno = false;
            }
            return retorno;
        }

        public int[] Ascendente()
        {
            int aux;
            for (int i = 1; i < cantidad; i++)
            {
                for (int j = 0; j < cantidad-1; ++j)
                {
                    if (vector[j] > vector[j+1])
                    {
                        aux = vector[j];
                        vector[j] = vector[j+1];
                        vector[j+1] = aux;
                    }
                }
            }
            return vector;
        }

        public int[] Descendente()
        {
            for (int i = 1; i < cantidad; i++)
            {
                for (int j = 0; j < cantidad-1; ++j)
                {
                    if (vector[j] < vector[j+1])
                    {
                        int aux = vector[j];
                        vector[j] = vector[j+1];
                        vector[j+1] = aux;
                    }
                }
            }
            return vector;
        }

        public int Cantidad { get { return cantidad; } } 


    }
}
