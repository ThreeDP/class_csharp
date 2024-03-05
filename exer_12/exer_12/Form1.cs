using ClassRoom;

namespace exer_12
{
    public partial class Form1 : Form
    {
        List<Student> _students;
        public Form1()
        {
            this._students = new List<Student>();
            InitializeComponent();
        }

        private void btnRegisterStudentName_Click(object sender, EventArgs e)
        {
            string studentName = txtInputStudentName.Text.Normalize().ToUpper();
            if (studentName == "")
                return;
            Student student = new Student(studentName); 
            if (this._students.IndexOf(student) == -1)
            {
                this._students.Add(student);
                lblOutputStudentAverage.Text = lblOutputStudentAverage.Text.Split(": ")[0] + ": ";
                lblOutputNameStudent.Text = lblOutputNameStudent.Text.Split(":")[0] + ": " + studentName;
                lblOutputMsg.Text = "Àluno adicionada com sucesso!";
                lblOutputMsg.ForeColor = Color.Green;
                return;
            }
            lblOutputMsg.Text = "Aluno já registrado!";
            lblOutputMsg.ForeColor = Color.Red;
        }

        private void btnConsultStundetByName_Click(object sender, EventArgs e)
        {
            string studentName = txtInputStudentName.Text.Normalize().ToUpper();
            if (studentName == "")
                return;
            Student student = new Student(studentName);
            int index = this._students.IndexOf(student);
            if (index != -1)
            {

                lblOutputNameStudent.Text = lblOutputNameStudent.Text.Split(":")[0] + ": " + this._students[index].Name;
                lblOutputStudentAverage.Text = lblOutputStudentAverage.Text.Split(": ")[0] + ": ";
            }
            lblOutputMsg.Text = "";
        }

        private int getStudentIndex()
        {
            string studentName = lblOutputNameStudent.Text.Split(": ")[1];
            if (studentName == "")
                return -1;
            Student student = new Student(studentName);
            return this._students.IndexOf(student);
        }

        private void btnRegisterStudentNote_Click(object sender, EventArgs e)
        {
            int index = getStudentIndex();
            if (index != -1)
            {
                lblOutputMsg.Text = "Nota adicionada com sucesso!";
                lblOutputMsg.ForeColor = Color.Green;
                this._students[index].Note = Convert.ToDouble(txtInputStudentNote.Text);
                lblOutputStudentAverage.Text = lblOutputStudentAverage.Text.Split(": ")[0] + ": ";
                return;
            }
            lblOutputMsg.Text = "Não foi possivel adicionar a nota!";
            lblOutputMsg.ForeColor = Color.Red;
        }

        private void btnConsultAverageNoteOfAtualStudent_Click(object sender, EventArgs e)
        {
            int index = getStudentIndex();
            if (index != -1)
                lblOutputStudentAverage.Text = lblOutputStudentAverage.Text.Split(":")[0] + ": " + this._students[index].GetAverage();
            lblOutputMsg.Text = "";
        }
    }
}
