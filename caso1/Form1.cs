namespace caso1
{
    public partial class caso1 : Form
    {

        int resultado;
        public caso1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int precio = int.Parse(txtPrecio.Text);
            int cantidad = int.Parse(txtCantidad.Text);

            resultado = precio * cantidad;

            this.txtResult.Text = resultado.ToString();

            txtCantidad.Text = "";
            txtPrecio.Text = "";


        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}