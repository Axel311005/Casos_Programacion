namespace caso5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double precio = double.Parse(txtPrecio.Text);
            double cantidad = double.Parse(txtCantidad.Text);


            double descuentounidad;
            double descuentototal;
            double totalxunidad;
            double total;
            descuentounidad = precio * 0.11;
            totalxunidad = precio - descuentounidad;
            descuentototal = (precio * cantidad) * 0.11;
            total = (precio * cantidad) - descuentototal;

            txtTotalxunidad.Text = totalxunidad.ToString();
            txtDescuento.Text = descuentototal.ToString();
            txtTotal.Text = total.ToString();
        }
    }
}