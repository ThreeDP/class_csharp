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

        List<Student>   _students = new List<Student>();
        Int32           _numberOfStudents = 0;
        double          _sumOfGradesClassRoom = 0;

        private Int32 getIfNameExist(string name)
        {
            Int32 i = 0;
            foreach (Student student in _students)
            {
                if (student.Name == name)
                    return i;
                i++;
            }
            return -1;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string studentName = txtInputStudentName.Text;
            if (studentName == "")
            {
                lblRegisterStudentMsg.Text = "insira o nome do aluno!";
                lblRegisterStudentMsg.ForeColor = Color.Red;
                return;
            }
            if (txtInputStudentAverage.Text == "")
            {
                lblRegisterStudentMsg.Text = "insira a média do aluno!";
                lblRegisterStudentMsg.ForeColor = Color.Red;
                return;
            }
            double studentAverage = Convert.ToDouble(txtInputStudentAverage.Text);
            if (studentAverage < 0 || studentAverage > 10)
            {
                lblRegisterStudentMsg.Text = "insira uma média válida, entre 0 e 10, para o aluno!";
                lblRegisterStudentMsg.ForeColor = Color.Red;
                return;
            }
            studentName = studentName.Normalize(NormalizationForm.FormD).ToUpper();
            Int32 index = getIfNameExist(studentName);
            if (index >= 0)
            {
                _sumOfGradesClassRoom -= _students[index].Average;
                _sumOfGradesClassRoom += studentAverage;

                Student updatedStudent = new Student { Name = _students[index].Name, Average = studentAverage };
                _students[index] = updatedStudent;
                lblRegisterStudentMsg.Text = "Média do aluno " + studentName + " atualizada!";
                lblRegisterStudentMsg.ForeColor = Color.Green;
                setAverageClassRoom();
                return;
            }
            else if (_numberOfStudents < 8){
                _students.Add(new Student { Name = studentName, Average = studentAverage });
                _sumOfGradesClassRoom += studentAverage;
                lblRegisterStudentMsg.Text = "Média do aluno " + studentName + " inserida!";
                lblRegisterStudentMsg.ForeColor = Color.Green;
                _numberOfStudents++;
                lblOutputNumberOfStudents.Text = Convert.ToString(_numberOfStudents);
                setAverageClassRoom();
                return;
            }
            lblRegisterStudentMsg.Text = "A sala já atingiu seu limite de alunos!";
            lblRegisterStudentMsg.ForeColor = Color.Red;
        }

        private void setAverageClassRoom()
        {
            if (_numberOfStudents >= 8)
            {
                lblOutputClassRoomAverage.Text = Convert.ToString(_sumOfGradesClassRoom / 8.0);
            }
        }
    }
}
