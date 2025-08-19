namespace Tu_primer_formulario_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //lblResultado.Text = txtNombre.Text;
            //voy a usar le framework.NET 
            MessageBox.Show("Hola " + txtNombre.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
