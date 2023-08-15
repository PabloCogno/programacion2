using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Control
    {
        int[] numeros = new int[20];
        int cantidad = 0;


        public bool AgregarNumero(int numero)
        {
            bool retorno = true;
            if (cantidad < 20)
            {
                numeros[cantidad] = numero;
                cantidad++;
            }
            else
            {
                retorno = false;
            }

            return retorno;
        }


        public string VerResultados()
        {
            double acumulador = 0;
            double promedio = 0;
            string resultado;
            for (int i = 0; i < cantidad; i++)
            {
                acumulador += numeros[i];
            }

            promedio = acumulador / cantidad;

            int cantidadMenores = 0;
            int cantidadMayores = 0;

            for (int i = 0;i < cantidad;i++)
            {
                if (numeros[i]<promedio)
                {
                    cantidadMenores++;
                }
                if (numeros[i]>promedio)
                {
                    cantidadMayores++;
                }
            }

            resultado = "Promedio: " + promedio.ToString() + " Mayores al promedio: " + cantidadMayores.ToString() + " Menores al promedio: " + cantidadMenores.ToString();
            return resultado;
        }

    }
}
