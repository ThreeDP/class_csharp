namespace exer_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtInputN1.Text == "" || txtInputN2.Text == "")
            {
                lblResult.Text = "";
                return;
            }
            double n1 = Convert.ToDouble(txtInputN1.Text);
            double n2 = Convert.ToDouble(txtInputN2.Text);

            lblResult.Text = Convert.ToString(Math.Abs(n1 - n2));
        }
    }
}
