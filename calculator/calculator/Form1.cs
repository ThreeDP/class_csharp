namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool hasOperator(string str)
        {
            string[] operators = { "*", "+", "/", "-" };
            if (operators.Any(opt => str.EndsWith(opt)))
            {
                return true;
            }
            return false;
        }


        private void btnZero_Click(object sender, EventArgs e)
        {

        }
    }
}
