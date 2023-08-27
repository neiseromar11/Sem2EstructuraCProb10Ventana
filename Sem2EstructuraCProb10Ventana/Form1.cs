namespace Sem2EstructuraCProb10Ventana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtnum.Text);
            double desc = 0;

            if (num >= 100.0)
            {
                desc = 0.10 * num;

            }
            else
            {
                desc = 0.20 * num;
            }

            double totalneto = num - desc;
            double igv = 0.18 * totalneto;
            double total = totalneto + igv;
            lblcuenta.Text = string.Format(" su total es: " + totalneto + "\n su igv es: " + igv + "\n su total a pagar es: " + total);

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            lblcuenta.Text = string.Empty;
        }
    }
}