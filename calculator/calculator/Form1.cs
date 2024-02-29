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
        string[] numbers = { "0", "1", "2", "3", "4". "5", "6", "7", "8", "9" };

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
            if (label[1] == "0" && sender.Text == "0")
                return;
            if (!hasOperator(label[1]))
                label[1] += str;
            else
                label[1] += " " + str;
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
            if (hasOperator(view))
                return;
            if (hasNumber(view))
            {
                string value;
                string opt = containsOperator(view[1]);

                if (opt != "")
                    value = view[1].Split(opt)[0];
                else
                    value = view[1];
                if (!hasPointer(value))
                    lblCalcView.Text = view[0] + "\n" + value + ".";
            }
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            string btnValue = sender.Text;
            if (hasOperator(label[1]))
                return;
            string[] label = lblCalcView.Text.Split("\n");
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
            string[] calc = view.Split(" ");
            if (calc.Length == 3)
            {
                Int32 res = 0;
                string base;
                if (calc[0] == "") {
                    base = view[0]
                } else {
                    base = calc[0];
                }
                switch (calc[1][1])
                {
                    case '*': res = Convert.ToInt32(base) * Convert.ToInt32(calc[2]); break;
                    case '-': res = Convert.ToInt32(base) - Convert.ToInt32(calc[2]); break;
                    case '+': res = Convert.ToInt32(base) + Convert.ToInt32(calc[2]); break;
                    case '/': res = divide(base, calc[2]); break;
                }
                lblCalcView.Text = res + "\n";
            }
        }

        private Int32 divide(string num1, string num2)
        {
            Int32 n1 = Convert.ToInt32(num1);
            Int32 n2 = Convert.ToInt32(num2);
            if (n2 == 0)
                return 0;
            return n1 / n2;
        }
    }
}
