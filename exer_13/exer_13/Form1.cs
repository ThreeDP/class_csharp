using System.Xml.Serialization;

namespace exer_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void upDownTypeOfActionInAccount_SelectedItemChanged(object sender, EventArgs e)
        {
            string choice = upDownTypeOfActionInAccount.Text.Normalize().ToUpper();
            string insertTextBtn = "";
            switch (choice)
            {
                case "DEPOSITO":
                    insertTextBtn = "Dépositar Dinheiro";
                    break;
                case "SAQUE":
                    insertTextBtn = "Sacar Dinheiro";
                    break;
                case "SALDO":
                    insertTextBtn = "Consultar Saldo";
                    break;
            }
            btnActionInAccount.Text = insertTextBtn;
        }

        private void btnCreateABankAccount_Click(object sender, EventArgs e)
        {

        }
    }
}
