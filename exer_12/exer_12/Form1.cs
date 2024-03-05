using ClassRoom;

namespace exer_12
{
    public partial class Form1 : Form
    {
        List<Student> _students;
        string _actualStudent = "";
        public Form1()
        {
            this._students = new List<Student>();
            InitializeComponent();
        }

        public int findStudent(string name)
        {
            int i = 0;
            foreach (Student student in _students)
            {
                if (student.Name == name)
                {
                    return i;
                }
            }
            return -1;
        }

        private void btnRegisterStudentName_Click(object sender, EventArgs e)
        {
            string studentName = lblInputStudentName.Text.Normalize().ToUpper();
            int index = this.findStudent(studentName);
            if (index == -1)
            {
                this._actualStudent = studentName;
                this._students.Add(new Student(studentName));
                lblOutputNameStudent.Text = studentName;
            }
        }

        private void btnConsultStundetByName_Click(object sender, EventArgs e)
        {
            string studentName = lblInputStudentName.Text.Normalize().ToUpper();
            int index = this.findStudent(studentName);
            if (index != -1)
            {
                this._actualStudent = studentName;
               
            }
        }

        private void btnRegisterStudentNote_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultAverageNoteOfAtualStudent_Click(object sender, EventArgs e)
        {

        }
    }
}
