namespace caso4
{
    public partial class caso4 : Form
    {
        public caso4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            double socio1 = double.Parse(txtSocio1.Text);
            double socio2 = double.Parse(txtSocio2.Text);
            double socio3 = double.Parse(txtSocio3.Text);

            double capital = socio1 + socio2 + socio3;

            double porcentaje1 = (socio1 * 100) / capital;
            double porcentaje2 = (socio2 * 100) / capital;
            double porcentaje3 = (socio3 * 100) / capital;

            txtTotal.Text = capital.ToString();

            txtPorcentaje1.Text = porcentaje1.ToString();
            txtPorcentaje2.Text = porcentaje2.ToString();
            txtPorcentaje3.Text = porcentaje3.ToString();

            txtSocio1.Text = "";
            txtSocio2.Text = "";
            txtSocio3.Text = "";

        }
    }
}