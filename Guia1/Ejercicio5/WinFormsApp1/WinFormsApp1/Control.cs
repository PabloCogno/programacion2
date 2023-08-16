using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Control
    {
        double promedioGeneral = 0;
        double acumulador = 0;
        double promedioEntreMayYMen = 0;
        double promedioMediana = 0;
        int[] vectorOrdenado;

        public double Promedio(int[] vector) 
        {
            acumulador = 0;
            for (int i = 0; i < vector.Length; i++) 
            {
                for (int j = i; j < vector.Length; ++j)
                {
                    if (vector[i] > vector[j])
                    {
                        int aux = vector[i];
                        vector[i] = vector[j];
                        vector[j] = aux;
                    }
                }
                acumulador += vector[i];
            }
            promedioGeneral = acumulador / vector.Length;
            promedioEntreMayYMen = (vector[9] + vector[0]) / 2;
            promedioMediana = (vector[4] + vector[5]) / 2;
            vectorOrdenado = vector;

            return promedioGeneral;
        }

        public double PromedioMediana
        {
            get { return promedioMediana; }
        }

        public double PromedioEntreMayYMen { get { return promedioEntreMayYMen; } }

        
        
    }
}
