using System.Text;

public struct Student
{
    public string Name;
    public double Average;
}


namespace exer_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Student> _students = new List<Student>();

        private bool checkIfNameExist(string name)
        {
            foreach (Student student in _students)
            {
                if (student.Name == name)
                    return true;
            }
            return false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string studentName = txtInputStudent.Text;
            studentName = studentName.Normalize(NormalizationForm.FormD).ToUpper();
            if (!checkIfNameExist(studentName))
            {
                _students.Add(new Student { Name = studentName, Average = 0.0 });
                lblRegisterStudentMsg.Text = "Aluno criado com sucesso!";
                lblRegisterStudentMsg.ForeColor = Color.Green;
                cleanViewStudents();
                return;
            }
            lblRegisterStudentMsg.Text = "Não foi possivel cadastrar o aluno!";
            lblRegisterStudentMsg.ForeColor = Color.Red;
        }

        private void btnCheckStudentExist_Click(object sender, EventArgs e)
        {
            string studentName = txtInputStudentExist.Text;
            studentName = studentName.Normalize(NormalizationForm.FormD).ToUpper();
            if (checkIfNameExist(studentName))
            {
                lblCheckStudentExistMsg.Text = "Aluno já cadastrado!";
                lblCheckStudentExistMsg.ForeColor = Color.Green;
                return;
            }
            lblCheckStudentExistMsg.Text = "Aluno não está cadastrado!";
            lblCheckStudentExistMsg.ForeColor = Color.Red;
        }

        private void cleanViewStudents()
        {
            lblNumberOfStudents.Text = "";
            lstBoxStudents.Items.Clear();
        }

        private void btnShowStudents_Click(object sender, EventArgs e)
        {
            Int32 numberOfStudents = 0;
            cleanViewStudents();
            foreach (Student student in _students)
            {
                lstBoxStudents.Items.Add(student.Name);
                numberOfStudents++;
            }
            lblNumberOfStudents.Text = Convert.ToString(numberOfStudents);
        }
    }
}
