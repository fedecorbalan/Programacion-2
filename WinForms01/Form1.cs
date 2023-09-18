namespace WinForms01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.Purple;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Bienvenido broder";

        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {


            string nombre = this.txtNombre.Text;

            MessageBox.Show("Hola negro " + nombre);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}