using Microsoft.VisualBasic;

namespace exer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenResult_Click(object sender, EventArgs e)
        {
            TextBox[] inputsTxt = { txtInputN1, txtInputN2, txtInputN3, txtInputN4 };
            Label[] outputsNumbers = { lblResultN1, lblResultN2, lblResultN3, lblResultN4 };

            int size = inputsTxt.Length;
            for (int i = 0; i < size; i++) 
            {
                if (!string.IsNullOrEmpty(inputsTxt[i].Text))
                {
                    long num = Convert.ToInt64(inputsTxt[i].Text);
                    if (num % 3 == 0 && num % 2 == 0)
                    {
                        outputsNumbers[i].Text = Convert.ToString(num);
                    } else 
                        outputsNumbers[i].Text = "";

                }
            }
        }
    }
}
