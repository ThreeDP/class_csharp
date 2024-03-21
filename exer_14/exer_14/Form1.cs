namespace exer_14
{
    public partial class Form1 : Form
    {
        List<Employer> _employers;
        public Form1()
        {
            InitializeComponent();
            this._employers = new List<Employer>();
        }


        private void clearRegisterInputs()
        {
            txtInputEmployerName.Text = "";
            txtInputEmployerGrossSalary.Text = "";
        }
        private void btnRegisterEmployer_Click(object sender, EventArgs e)
        {
            if (lblInputEmployerName.Text != "" &&
                lblInputEmployerGrossSalary.Text != "")
            {
                try
                {
                    double value = Convert.ToDouble(txtInputEmployerGrossSalary.Text);
                    Employer new_emp = new Employer(txtInputEmployerName.Text, value);
                    this._employers.Add(new_emp);
                    clearRegisterInputs();
                    lblMessageEmployerRegister.Text = "";
                    return;
                }
                catch
                {
                    lblMessageEmployerRegister.Text = "Entre um valor válido.";
                    return;
                }
            }
            lblMessageEmployerRegister.Text = "Entre todos os dados para cadastrar.";
        }

        private void btnFindmployer_Click(object sender, EventArgs e)
        {
            if (txtInputIdEmployerForSearch.Text != "")
            {
                int id = 0;
                try { id = Convert.ToInt32(txtInputIdEmployerForSearch.Text); } catch { txtOutputShowEmployerInformation.Text = "Entre um Id válido!"; return; }
                if (id <= 0 || id > this._employers.Count) { txtOutputShowEmployerInformation.Text = "Entre um Id válido!"; return; }
                id -= 1;
                string message = $"Id do Funcionário:\t\t {_employers[0].Id}\n"; 
                message = $"Nome do Funcionário:\t\t {_employers[0].Name}\n";
                message = $"Salário Bruto:\t\t {_employers[id].GrossSalary}\n";
                message = $"Salário Liquído:\t\t {_employers[id].CalculateNetSalary()}\n";
                message = $"Previdência:\t\t {_employers[id].Security}\n";
                txtInputIdEmployerForSearch.Text = "";
                txtOutputShowEmployerInformation.Text = message;
                return;
            }
            txtOutputShowEmployerInformation.Text = "Entre um Id para buscar!";
        }
    }
}
