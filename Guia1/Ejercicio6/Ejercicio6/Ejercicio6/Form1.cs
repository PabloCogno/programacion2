namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Control NumericControl;

        private void bIngresar_Click(object sender, EventArgs e)
        {
            if (!NumericControl.AgregarNumero(Convert.ToInt32(tBnumero.Text)))
            {
                MessageBox.Show("Lista completa");
            }
            else
            {
                MessageBox.Show("Numero cargado exitosamente");
            }
            tBnumero.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NumericControl = new Control();
        }

        private void bAplicar_Click(object sender, EventArgs e)
        {
            int[] vectorOrdenado = null;

            lBlistado.Items.Clear();
            if (cBorden.Text == "Ascendente")
            {
                vectorOrdenado = NumericControl.Ascendente();
            }
            if (cBorden.Text == "Descendente")
            {
                vectorOrdenado = NumericControl.Descendente();
            }

            for (int i = 0; i < NumericControl.Cantidad; i++) 
            {
                lBlistado.Items.Add(vectorOrdenado[i]);
            }
        }
    }
}