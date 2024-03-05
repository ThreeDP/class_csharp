namespace exer_12
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblOutputNameStudent = new Label();
            lblOutputStudentAverage = new Label();
            lblInputStudentName = new Label();
            txtInputStudentName = new TextBox();
            btnRegisterStudentName = new Button();
            btnConsultStundetByName = new Button();
            btnRegisterStudentNote = new Button();
            txtInputStudentNote = new TextBox();
            lblInputStudentNote = new Label();
            btnConsultAverageNoteOfAtualStudent = new Button();
            SuspendLayout();
            // 
            // lblOutputNameStudent
            // 
            lblOutputNameStudent.AutoSize = true;
            lblOutputNameStudent.BackColor = Color.FromArgb(224, 224, 224);
            lblOutputNameStudent.Font = new Font("Arial Unicode MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOutputNameStudent.ForeColor = Color.FromArgb(64, 64, 64);
            lblOutputNameStudent.Location = new Point(12, 247);
            lblOutputNameStudent.Name = "lblOutputNameStudent";
            lblOutputNameStudent.Size = new Size(87, 28);
            lblOutputNameStudent.TabIndex = 0;
            lblOutputNameStudent.Text = "Nome: ";
            // 
            // lblOutputStudentAverage
            // 
            lblOutputStudentAverage.AutoSize = true;
            lblOutputStudentAverage.BackColor = Color.FromArgb(224, 224, 224);
            lblOutputStudentAverage.Font = new Font("Arial Unicode MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOutputStudentAverage.ForeColor = Color.FromArgb(64, 64, 64);
            lblOutputStudentAverage.Location = new Point(12, 284);
            lblOutputStudentAverage.Name = "lblOutputStudentAverage";
            lblOutputStudentAverage.Size = new Size(89, 28);
            lblOutputStudentAverage.TabIndex = 1;
            lblOutputStudentAverage.Text = "Média: ";
            // 
            // lblInputStudentName
            // 
            lblInputStudentName.AutoSize = true;
            lblInputStudentName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInputStudentName.Location = new Point(12, 22);
            lblInputStudentName.Name = "lblInputStudentName";
            lblInputStudentName.Size = new Size(114, 18);
            lblInputStudentName.TabIndex = 2;
            lblInputStudentName.Text = "Nome do Aluno";
            // 
            // txtInputStudentName
            // 
            txtInputStudentName.Location = new Point(12, 47);
            txtInputStudentName.Name = "txtInputStudentName";
            txtInputStudentName.Size = new Size(326, 23);
            txtInputStudentName.TabIndex = 3;
            // 
            // btnRegisterStudentName
            // 
            btnRegisterStudentName.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegisterStudentName.Location = new Point(12, 76);
            btnRegisterStudentName.Name = "btnRegisterStudentName";
            btnRegisterStudentName.Size = new Size(123, 37);
            btnRegisterStudentName.TabIndex = 4;
            btnRegisterStudentName.Text = "Cadastrar Aluno";
            btnRegisterStudentName.UseVisualStyleBackColor = true;
            btnRegisterStudentName.Click += btnRegisterStudentName_Click;
            // 
            // btnConsultStundetByName
            // 
            btnConsultStundetByName.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultStundetByName.Location = new Point(141, 76);
            btnConsultStundetByName.Name = "btnConsultStundetByName";
            btnConsultStundetByName.Size = new Size(123, 37);
            btnConsultStundetByName.TabIndex = 5;
            btnConsultStundetByName.Text = "Consultar Aluno";
            btnConsultStundetByName.UseVisualStyleBackColor = true;
            btnConsultStundetByName.Click += btnConsultStundetByName_Click;
            // 
            // btnRegisterStudentNote
            // 
            btnRegisterStudentNote.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegisterStudentNote.Location = new Point(12, 185);
            btnRegisterStudentNote.Name = "btnRegisterStudentNote";
            btnRegisterStudentNote.Size = new Size(123, 37);
            btnRegisterStudentNote.TabIndex = 8;
            btnRegisterStudentNote.Text = "Cadastrar Nota";
            btnRegisterStudentNote.UseVisualStyleBackColor = true;
            btnRegisterStudentNote.Click += btnRegisterStudentNote_Click;
            // 
            // txtInputStudentNote
            // 
            txtInputStudentNote.Location = new Point(12, 156);
            txtInputStudentNote.Name = "txtInputStudentNote";
            txtInputStudentNote.Size = new Size(326, 23);
            txtInputStudentNote.TabIndex = 7;
            // 
            // lblInputStudentNote
            // 
            lblInputStudentNote.AutoSize = true;
            lblInputStudentNote.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInputStudentNote.Location = new Point(12, 131);
            lblInputStudentNote.Name = "lblInputStudentNote";
            lblInputStudentNote.Size = new Size(81, 18);
            lblInputStudentNote.TabIndex = 6;
            lblInputStudentNote.Text = "Nova Nota";
            // 
            // btnConsultAverageNoteOfAtualStudent
            // 
            btnConsultAverageNoteOfAtualStudent.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultAverageNoteOfAtualStudent.Location = new Point(141, 185);
            btnConsultAverageNoteOfAtualStudent.Name = "btnConsultAverageNoteOfAtualStudent";
            btnConsultAverageNoteOfAtualStudent.Size = new Size(123, 37);
            btnConsultAverageNoteOfAtualStudent.TabIndex = 9;
            btnConsultAverageNoteOfAtualStudent.Text = "Consultar Média";
            btnConsultAverageNoteOfAtualStudent.UseVisualStyleBackColor = true;
            btnConsultAverageNoteOfAtualStudent.Click += btnConsultAverageNoteOfAtualStudent_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 364);
            Controls.Add(btnConsultAverageNoteOfAtualStudent);
            Controls.Add(btnRegisterStudentNote);
            Controls.Add(txtInputStudentNote);
            Controls.Add(lblInputStudentNote);
            Controls.Add(btnConsultStundetByName);
            Controls.Add(btnRegisterStudentName);
            Controls.Add(txtInputStudentName);
            Controls.Add(lblInputStudentName);
            Controls.Add(lblOutputStudentAverage);
            Controls.Add(lblOutputNameStudent);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblOutputNameStudent;
        private Label lblOutputStudentAverage;
        private Label lblInputStudentName;
        private TextBox txtInputStudentName;
        private Button btnRegisterStudentName;
        private Button btnConsultStundetByName;
        private Button btnRegisterStudentNote;
        private TextBox txtInputStudentNote;
        private Label lblInputStudentNote;
        private Button btnConsultAverageNoteOfAtualStudent;
    }
}
