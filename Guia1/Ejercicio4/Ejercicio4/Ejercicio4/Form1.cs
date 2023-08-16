using System.Collections;
namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        ArrayList listado = new ArrayList();
        int puntoMinimo = 1000;
        int puntoMaximo = -1000;
        int puntoActual = 0;
        Punto ejeMax;
        Punto ejeMin;
        double acumulado = 0;
        double promedio = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void bResultados_Click(object sender, EventArgs e)
        {
            AgregarEjes(Convert.ToInt32(tBx.Text), Convert.ToInt32(tBy.Text));
            MostrarResultados();
            tBx.Clear();
            tBy.Clear();

        }

        public struct Punto
        {
            public int x;
            public int y;
        }

        public int Cantidad
        {
            get { return listado.Count; }
        }

        public double Promedio
        {
            get { return promedio; }
        }


        public void AgregarEjes(int x, int y)
        {
            listado.Add(new Punto { x = x, y = y });

            foreach (Punto p in listado)
            {
                puntoActual = Math.Abs(p.x) + Math.Abs(p.y);
                acumulado += puntoActual;
                if (puntoMaximo < puntoActual)
                {
                    puntoMaximo = puntoActual;
                    ejeMax.x = p.x;
                    ejeMax.y = p.y;
                }
                if (puntoMinimo > puntoActual)
                {
                    puntoMinimo = puntoActual;
                    ejeMin.x = p.x;
                    ejeMin.y = p.y;
                }
            }

            promedio = acumulado / listado.Count;
        }

        public void MostrarResultados()
        {
            lBresultados.Items.Clear();
            lBresultados.Items.Add("Punto más lejano: ");
            lBresultados.Items.Add("    X: " + ejeMax.x);
            lBresultados.Items.Add("    Y: " + ejeMax.y);
            lBresultados.Items.Add("Punto más cercano: ");
            lBresultados.Items.Add("    X: " + ejeMin.x);
            lBresultados.Items.Add("    Y: " + ejeMin.y);
            lBresultados.Items.Add("Cantidad de puntos procesados: " + Cantidad);
            lBresultados.Items.Add("Distancia promedio entre los puntos : " + Promedio);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ejeMax = new Punto();
            ejeMin = new Punto();
        }
    }
}