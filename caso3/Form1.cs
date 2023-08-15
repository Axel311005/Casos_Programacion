using Microsoft.VisualBasic;

namespace caso3
{
    public partial class caso3 : Form
    {
        public caso3()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click_1(object sender, EventArgs e)
        {
            int cantidad = int.Parse(txtCant.Text);

            if (txtMedida.SelectedItem.ToString() == "Centimetros")
            {
                double conversion1 = cantidad * 100;
                txtResult.Text = conversion1.ToString();


            }
            if (txtMedida.SelectedItem.ToString() == "Pies")
            {
                double conversion2 = cantidad * 3.28084;
                txtResult.Text = conversion2.ToString();


            }
            if (txtMedida.SelectedItem.ToString() == "Pulgadas")
            {
                double conversion3 = cantidad * 39.37008;
                txtResult.Text = conversion3.ToString();


            }
            if (txtMedida.SelectedItem.ToString() == "Yardas")
            {
                double conversion4 = cantidad * 1.0936133333333;
                txtResult.Text = conversion4.ToString();


            }

            txtCant.Text = "";

        }
    }
}