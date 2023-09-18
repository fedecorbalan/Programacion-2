namespace WinForms03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                lstTabla.Items.Clear();
                int numero = int.Parse(txtNumero.Text);
                for (int i = 1; i <= 10; i++)
                {
                    int resultado = numero * i;
                    lstTabla.Items.Add($"{numero} x {i} = {resultado}");
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstTabla.Items.Clear();
            txtNumero.Clear();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Realmente desea cerrar la aplicación?", "Confirmar Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}