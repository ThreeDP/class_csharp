using System.Security.Policy;
using System.Windows.Forms;

namespace exer_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque ac lorem at augue / rhoncus tincidunt et vel turpis.\n\nCras ullamcorper luctus condimentum. Donec ornare condimentum \"magna eu egestas\".\n\nLorem ipsum dolor sit amet, consectetur adipiscing elit.\n\nSed suscipit arcu at ante semper lacinia.\n\nUt lacinia cursus nulla.";
        }
    }
}
