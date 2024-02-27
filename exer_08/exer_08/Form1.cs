namespace exer_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtInput.Text))
            {
                lblInfo.Text = "";
                long num = Convert.ToInt64(txtInput.Text);
                if (num % 2 == 0 )
                    lblOutputResult.Text = "Par";
                else 
                    lblOutputResult.Text = "Ímpar";
            }
            else
                lblInfo.Text = "Erro: insira um número.";
        }
    }
}
