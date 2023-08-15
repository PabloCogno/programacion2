namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Control controlAnimals;


        private void bAgregar_Click(object sender, EventArgs e)
        {
            AgregarAnimal vAgregar = new AgregarAnimal();
            if (vAgregar.ShowDialog() == DialogResult.OK)
            {
                Animal nuevoAnimal = new Animal(vAgregar.tBnombre.Text, vAgregar.cBtipo.Text, Convert.ToInt32(vAgregar.tBedad.Text), Convert.ToDouble(vAgregar.tBpeso.Text));
                if (!controlAnimals.AgregarAnimal(nuevoAnimal))
                {
                    MessageBox.Show("Lista completa");
                }
                else
                {
                    MessageBox.Show("Se ha cargado exitosamente");
                }
            }
            else
            {
                MessageBox.Show("El usuario canceló la operacion");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            controlAnimals = new Control();

        }

        private void bMostrar_Click(object sender, EventArgs e)
        {
            lBlistado.Items.Clear(); //limpia el listado al inicio.
            Animal[] lista = controlAnimals.VerTipo(cBtipo.Text);
            foreach (Animal a in lista)
            {
                lBlistado.Items.Add("Nombre: " + a.Nombre + " edad: " + a.Edad.ToString() + " peso: " + a.Peso.ToString());
            }
        }
    }
}