namespace caso2
{
    public partial class caso2 : Form
    {
        public caso2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nota1 = int.Parse(txtNota1.Text);
            int nota2 = int.Parse(txtNota2.Text);
            int nota3 = int.Parse(txtNota3.Text);

            int promedio;
            promedio = (nota1 + nota2 + nota3) / 3;

            this.txtPromedio.Text = promedio.ToString();

            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";

        }

        private void txtNota1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}