namespace exer_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcessSalary_Click(object sender, EventArgs e)
        {
            if (txtDiscount.Text == "" ||  txtHourValue.Text == "" || txtWorkHours.Text == "")
            {
                lblInfo.Text = "Erro: Falta inserir valores.";
                return;
            }
            double grossSalary = Convert.ToDouble(txtHourValue.Text) * Convert.ToDouble(txtWorkHours.Text);
            double discount = (grossSalary * Convert.ToDouble(txtDiscount.Text)) / 100;

            lblOutputGrossSalary.Text = Convert.ToString(grossSalary);
            lblOutputDiscount.Text = Convert.ToString(discount);
            lblOutputNetSalary.Text = Convert.ToString(grossSalary - discount);
        }
    }
}
