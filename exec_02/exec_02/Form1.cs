namespace exec_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtInputValueOne.Text != "" && txtInputValueTwo.Text != "")
            {
                double numOne = Convert.ToDouble(txtInputValueOne.Text);
                double numTwo = Convert.ToDouble(txtInputValueTwo.Text);
                lblResult.Text = Convert.ToString(numOne + numTwo);
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (txtInputValueOne.Text != "" && txtInputValueTwo.Text != "")
            {
                double numOne = Convert.ToDouble(txtInputValueOne.Text);
                double numTwo = Convert.ToDouble(txtInputValueTwo.Text);
                lblResult.Text = Convert.ToString(numOne - numTwo);
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtInputValueTwo.Text) == 0)
            {
                lblResult.Text = "indeterminado";
                return;
            }
            if (txtInputValueOne.Text != "" && txtInputValueTwo.Text != "")
            {
                double numOne = Convert.ToDouble(txtInputValueOne.Text);
                double numTwo = Convert.ToDouble(txtInputValueTwo.Text);
                lblResult.Text = Convert.ToString(numOne / numTwo);
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (txtInputValueOne.Text != "" && txtInputValueTwo.Text != "")
            {
                double numOne = Convert.ToDouble(txtInputValueOne.Text);
                double numTwo = Convert.ToDouble(txtInputValueTwo.Text);
                lblResult.Text = Convert.ToString(numOne * numTwo);
            }
        }
    }
}
