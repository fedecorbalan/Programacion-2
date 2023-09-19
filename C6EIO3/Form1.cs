namespace C6EIO3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string texto = rtxtPalabras.Text;

            string[] palabras = texto.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> contadorPalabras = new Dictionary<string, int>();

            foreach (string palabra in palabras)
            {
                if (contadorPalabras.ContainsKey(palabra))
                {
                    contadorPalabras[palabra]++;
                }
                else
                {
                    contadorPalabras[palabra] = 1;
                }
            }

            var topPalabras = contadorPalabras.OrderByDescending(kv => kv.Value).Take(3);

            // Crear un mensaje con el TOP 3 de palabras
            string mensaje = "TOP 3 de palabras más frecuentes:\n";
            foreach (var kvp in topPalabras)
            {
                mensaje += $"{kvp.Key}: {kvp.Value} veces\n";
            }

            // Mostrar el mensaje en un MessageBox
            MessageBox.Show(mensaje, "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}