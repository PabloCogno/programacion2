namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Control controlNumeros;

        private void bMostrar_Click(object sender, EventArgs e)
        {
            Form2 vResultados = new Form2();
            
            vResultados.lBresultados.Items.Add(controlNumeros.VerResultados());
            vResultados.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            controlNumeros = new Control();
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            if (!controlNumeros.AgregarNumero(Convert.ToInt32(tBnumero.Text)))
            {
                MessageBox.Show("Lista completa");
            }
            else
            {
                MessageBox.Show("Numero cargado exitosamente");
            }
        }
    }
}