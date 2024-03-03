using System.Linq.Expressions;
using System.Numerics;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string viewValuePattern = "0\n";
        string[] operators = { "*", "+", "/", "-" };
        string[] numbers = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        private bool hasOperator(string str)
        {
            if (operators.Any(opt => str.EndsWith(opt)))
            {
                return true;
            }
            return false;
        }

        private bool hasNumber(string str)
        {
            if (numbers.Any(num => str.EndsWith(num)))
            {
                return true;
            }
            return false;
        }

        private string containsOperator(string str)
        {
            foreach (var opt in operators)
            {
                if (str.Contains(opt))
                    return opt;
            }
            return "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblCalcView.Text = viewValuePattern;
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            string[] label = lblCalcView.Text.Split("\n");
            string btnStr = ((Button)sender).Text;
            if (label[1] == "0" && btnStr == "0")
                return;
            if (!hasOperator(label[1]))
                label[1] += btnStr;
            else
                label[1] += " " + btnStr;
            lblCalcView.Text = label[0] + "\n" + label[1];
        }

        private bool hasPointer(string str)
        {
            if (str.Contains("."))
                return true;
            return false;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            string[] view = lblCalcView.Text.Split("\n");
            if (hasOperator(view[1]))
                return;
            if (hasNumber(view[1]))
            {
                string value;
                string auxPiece = "";
                string opt = containsOperator(view[1]);

                if (opt != "")
                {
                    value = view[1].Split(opt)[1];
                    auxPiece = view[1].Split(opt)[0];
                }
                else
                    value = view[1];
                if (!hasPointer(value))
                    lblCalcView.Text = view[0] + "\n" + auxPiece + opt + value + ((Button)sender).Text;
            }
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            string btnValue = ((Button)sender).Text;
            string[] label = lblCalcView.Text.Split("\n");
            if (hasOperator(label[1]))
                return;
            string containsOpt = containsOperator(label[1]);
            if (containsOpt != "")
            {
                btnResult_Click(sender, e);
                label = lblCalcView.Text.Split("\n");
            }
            label[1] += " " + btnValue;
            lblCalcView.Text = label[0] + "\n" + label[1];
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            string[] view = lblCalcView.Text.Split("\n");
            string[] calc = view[1].Split(" ");
            if (calc.Length == 3)
            {
                Double res = 0;
                string baseStr;
                if (calc[0] == "") {
                    baseStr = view[0];
                } else {
                    baseStr = calc[0];
                }
                switch (calc[1][0])
                {
                    case '*': res = Convert.ToDouble(baseStr) * Convert.ToDouble(calc[2]); break;
                    case '-': res = Convert.ToDouble(baseStr) - Convert.ToDouble(calc[2]); break;
                    case '+': res = Convert.ToDouble(baseStr) + Convert.ToDouble(calc[2]); break;
                    case '/': res = divide(baseStr, calc[2]); break;
                }
                lblCalcView.Text = Convert.ToString(res) + "\n";
            }
        }

        private Double divide(string num1, string num2)
        {
            Double n1 = Convert.ToDouble(num1);
            Double n2 = Convert.ToDouble(num2);
            if (n2 == 0)
                return 0;
            return n1 / n2;
        }
    }
}
