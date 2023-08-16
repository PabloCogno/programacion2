using System.Numerics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random misNumeros;
        int[] vector;
        Control controlNumerico;
        int primero;
        int segundo;


        private void Form1_Load(object sender, EventArgs e)
        {
            misNumeros = new Random();
            vector = new int[10];
            controlNumerico = new Control();
        }

        private void bResultados_Click(object sender, EventArgs e)
        {
            primero = Convert.ToInt32(tBprimero.Text);
            segundo = Convert.ToInt32(tBsegundo.Text);
            for (int i = 0; i < 10; i++) 
            {
                vector[i] = misNumeros.Next(primero, segundo+1);
            }

            lBresultados.Items.Clear();
            lBresultados.Items.Add("Promedio general: " + controlNumerico.Promedio(vector).ToString("00"));
            lBresultados.Items.Add("Promedio entre el menor y el mayor: " + controlNumerico.PromedioEntreMayYMen.ToString("00"));
            lBresultados.Items.Add("Promedio de la mediana: " + controlNumerico.PromedioMediana.ToString("00"));

            lBresultados.Items.Add("------------------");

            for (int i = 0;i < 10; i++) 
            {
                lBresultados.Items.Add("Posicion: " + i + " Valor: " + vector[i]);
            }

        }
    }
}