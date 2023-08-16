namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (romanNumerals.ContainsKey(Convert.ToInt32(tBnumero.Text)))
            {
                MessageBox.Show(romanNumerals[Convert.ToInt32(tBnumero.Text)]);
            }
            else
            {
                MessageBox.Show("Number out of range (1-20)");
            }

        }

        public Dictionary<int, string> romanNumerals = new Dictionary<int, string>
        {
            {1, "I"}, {2, "II"}, {3, "III"}, {4, "IV"}, {5, "V"},
            {6, "VI"}, {7, "VII"}, {8, "VIII"}, {9, "IX"}, {10, "X"},
            {11, "XI"}, {12, "XII"}, {13, "XIII"}, {14, "XIV"}, {15, "XV"},
            {16, "XVI"}, {17, "XVII"}, {18, "XVIII"}, {19, "XIX"}, {20, "XX"}
        };


        
    }
}