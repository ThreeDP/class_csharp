namespace exer_10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitleRegisterStudent = new Label();
            txtInputStudent = new TextBox();
            btnRegisterStudent = new Button();
            lblRegisterStudentMsg = new Label();
            lblTitleCheckStudentExist = new Label();
            txtInputStudentExist = new TextBox();
            btnCheckStudentExist = new Button();
            lblCheckStudentExistMsg = new Label();
            btnShowStudents = new Button();
            lblTitleShowStudents = new Label();
            lblTitleNumberOfStudents = new Label();
            lblNumberOfStudents = new Label();
            lstBoxStudents = new ListBox();
            SuspendLayout();
            // 
            // lblTitleRegisterStudent
            // 
            lblTitleRegisterStudent.AutoSize = true;
            lblTitleRegisterStudent.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleRegisterStudent.Location = new Point(37, 33);
            lblTitleRegisterStudent.Margin = new Padding(0, 0, 3, 0);
            lblTitleRegisterStudent.Name = "lblTitleRegisterStudent";
            lblTitleRegisterStudent.Size = new Size(296, 34);
            lblTitleRegisterStudent.TabIndex = 0;
            lblTitleRegisterStudent.Text = "Cadastro de Aluno:";
            // 
            // txtInputStudent
            // 
            txtInputStudent.Location = new Point(37, 90);
            txtInputStudent.Name = "txtInputStudent";
            txtInputStudent.Size = new Size(299, 27);
            txtInputStudent.TabIndex = 1;
            // 
            // btnRegisterStudent
            // 
            btnRegisterStudent.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegisterStudent.Location = new Point(37, 140);
            btnRegisterStudent.Name = "btnRegisterStudent";
            btnRegisterStudent.Size = new Size(200, 42);
            btnRegisterStudent.TabIndex = 2;
            btnRegisterStudent.Text = "Cadastrar Aluno";
            btnRegisterStudent.UseVisualStyleBackColor = true;
            btnRegisterStudent.Click += btnRegister_Click;
            // 
            // lblRegisterStudentMsg
            // 
            lblRegisterStudentMsg.AutoSize = true;
            lblRegisterStudentMsg.ForeColor = Color.Black;
            lblRegisterStudentMsg.Location = new Point(37, 185);
            lblRegisterStudentMsg.Name = "lblRegisterStudentMsg";
            lblRegisterStudentMsg.Size = new Size(0, 20);
            lblRegisterStudentMsg.TabIndex = 3;
            // 
            // lblTitleCheckStudentExist
            // 
            lblTitleCheckStudentExist.AutoSize = true;
            lblTitleCheckStudentExist.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleCheckStudentExist.Location = new Point(37, 228);
            lblTitleCheckStudentExist.Margin = new Padding(0, 0, 3, 0);
            lblTitleCheckStudentExist.Name = "lblTitleCheckStudentExist";
            lblTitleCheckStudentExist.Size = new Size(376, 34);
            lblTitleCheckStudentExist.TabIndex = 4;
            lblTitleCheckStudentExist.Text = "Verificar se aluno existe:";
            // 
            // txtInputStudentExist
            // 
            txtInputStudentExist.Location = new Point(37, 285);
            txtInputStudentExist.Name = "txtInputStudentExist";
            txtInputStudentExist.Size = new Size(299, 27);
            txtInputStudentExist.TabIndex = 5;
            // 
            // btnCheckStudentExist
            // 
            btnCheckStudentExist.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCheckStudentExist.Location = new Point(37, 335);
            btnCheckStudentExist.Name = "btnCheckStudentExist";
            btnCheckStudentExist.Size = new Size(200, 42);
            btnCheckStudentExist.TabIndex = 6;
            btnCheckStudentExist.Text = "Buscar por Aluno";
            btnCheckStudentExist.UseVisualStyleBackColor = true;
            btnCheckStudentExist.Click += btnCheckStudentExist_Click;
            // 
            // lblCheckStudentExistMsg
            // 
            lblCheckStudentExistMsg.AutoSize = true;
            lblCheckStudentExistMsg.Location = new Point(37, 380);
            lblCheckStudentExistMsg.Name = "lblCheckStudentExistMsg";
            lblCheckStudentExistMsg.Size = new Size(0, 20);
            lblCheckStudentExistMsg.TabIndex = 7;
            // 
            // btnShowStudents
            // 
            btnShowStudents.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShowStudents.Location = new Point(469, 140);
            btnShowStudents.Name = "btnShowStudents";
            btnShowStudents.Size = new Size(200, 42);
            btnShowStudents.TabIndex = 9;
            btnShowStudents.Text = "Mostrar Alunos";
            btnShowStudents.UseVisualStyleBackColor = true;
            btnShowStudents.Click += btnShowStudents_Click;
            // 
            // lblTitleShowStudents
            // 
            lblTitleShowStudents.AutoSize = true;
            lblTitleShowStudents.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleShowStudents.Location = new Point(469, 33);
            lblTitleShowStudents.Margin = new Padding(0, 0, 3, 0);
            lblTitleShowStudents.Name = "lblTitleShowStudents";
            lblTitleShowStudents.Size = new Size(320, 34);
            lblTitleShowStudents.TabIndex = 8;
            lblTitleShowStudents.Text = "Alunos Cadastrados:";
            // 
            // lblTitleNumberOfStudents
            // 
            lblTitleNumberOfStudents.AutoSize = true;
            lblTitleNumberOfStudents.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleNumberOfStudents.Location = new Point(469, 83);
            lblTitleNumberOfStudents.Margin = new Padding(0, 0, 3, 0);
            lblTitleNumberOfStudents.Name = "lblTitleNumberOfStudents";
            lblTitleNumberOfStudents.Size = new Size(162, 34);
            lblTitleNumberOfStudents.TabIndex = 10;
            lblTitleNumberOfStudents.Text = "nº Alunos:";
            // 
            // lblNumberOfStudents
            // 
            lblNumberOfStudents.AutoSize = true;
            lblNumberOfStudents.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumberOfStudents.Location = new Point(646, 83);
            lblNumberOfStudents.Margin = new Padding(0, 0, 3, 0);
            lblNumberOfStudents.Name = "lblNumberOfStudents";
            lblNumberOfStudents.Size = new Size(0, 34);
            lblNumberOfStudents.TabIndex = 11;
            // 
            // lstBoxStudents
            // 
            lstBoxStudents.FormattingEnabled = true;
            lstBoxStudents.Location = new Point(469, 228);
            lstBoxStudents.Name = "lstBoxStudents";
            lstBoxStudents.Size = new Size(461, 184);
            lstBoxStudents.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 450);
            Controls.Add(lstBoxStudents);
            Controls.Add(lblNumberOfStudents);
            Controls.Add(lblTitleNumberOfStudents);
            Controls.Add(btnShowStudents);
            Controls.Add(lblTitleShowStudents);
            Controls.Add(lblCheckStudentExistMsg);
            Controls.Add(btnCheckStudentExist);
            Controls.Add(txtInputStudentExist);
            Controls.Add(lblTitleCheckStudentExist);
            Controls.Add(lblRegisterStudentMsg);
            Controls.Add(btnRegisterStudent);
            Controls.Add(txtInputStudent);
            Controls.Add(lblTitleRegisterStudent);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitleRegisterStudent;
        private TextBox txtInputStudent;
        private Button btnRegisterStudent;
        private Label lblRegisterStudentMsg;
        private Label lblTitleCheckStudentExist;
        private TextBox txtInputStudentExist;
        private Button btnCheckStudentExist;
        private Label lblCheckStudentExistMsg;
        private Button btnShowStudents;
        private Label lblTitleShowStudents;
        private Label lblTitleNumberOfStudents;
        private Label lblNumberOfStudents;
        private ListBox lstBoxStudents;
    }
}
