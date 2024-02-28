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

        string[] operators = { "*", "+", "/", "-" };
        private bool hasOperator(string str)
        {
            if (operators.Any(opt => str.EndsWith(opt)))
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

        private void insertNumberInCalc(string str)
        {
            string[] label = lblCalcView.Text.Split("\n");
            if (!hasOperator(label[1]))
                label[1] += str;
            else
                label[1] += " " + str;
            lblCalcView.Text = label[0] + "\n" + label[1];
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblCalcView.Text = "\n";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            insertNumberInCalc(btnZero.Text);
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            insertNumberInCalc(btnOne.Text);
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            insertNumberInCalc(btnTwo.Text);
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            insertNumberInCalc(btnThree.Text);
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            insertNumberInCalc(btnFour.Text);
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            insertNumberInCalc(btnFive.Text);
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            insertNumberInCalc(btnSix.Text);
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            insertNumberInCalc(btnSeven.Text);
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            insertNumberInCalc(btnEight.Text);
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            insertNumberInCalc(btnNine.Text);
        }

        private bool hasPointer(string str)
        {
            if (str.Contains("."))
                return true;
            return false;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (!hasOperator(lblCalcView.Text))
            {
                string value;
                string[] label = lblCalcView.Text.Split("\n");
                string opt = containsOperator(label[1]);

                if (opt != "")
                    value = label[1].Split(opt)[0];
                else
                    value = label[1];
                if (!hasPointer(value))
                    insertNumberInCalc(btnPoint.Text);
            }
        }

        private void insertOperator(string str)
        {
            string[] label = lblCalcView.Text.Split("\n");
            // string containsOpt = containsOperator(label[1]);
            if (!hasOperator(label[1]))
            {
                label[1] += " " + str;
                lblCalcView.Text = label[0] + "\n" + label[1];
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            insertOperator(btnPlus.Text);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            insertOperator(btnMinus.Text);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            insertOperator(btnMultiply.Text);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            insertOperator(btnDivide.Text);
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            string[] calc = lblCalcView.Text.Split("\n")[1].Split(" ");
            if (calc.Length == 3)
            {
                switch (calc[1][1])
                {
                    case '*': multiply(calc[0], calc[2]); break;
                    case '-': multiply(calc[0], calc[2]); break;
                    case '+': multiply(calc[0], calc[2]); break;
                    case '/': multiply(calc[0], calc[2]); break;
                }
            }
        }

        private Int32 multiply(string num1, string num2)
        {
            Int32 n1 = Convert.ToInt32(num1);
            Int32 n2 = Convert.ToInt32(num2);
            return n1 * n2;
        }
    }
}
