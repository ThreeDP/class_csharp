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
            lblOutputMsg = new Label();
            SuspendLayout();
            // 
            // lblOutputNameStudent
            // 
            lblOutputNameStudent.AutoSize = true;
            lblOutputNameStudent.BackColor = Color.FromArgb(224, 224, 224);
            lblOutputNameStudent.Font = new Font("Arial Unicode MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOutputNameStudent.ForeColor = Color.FromArgb(64, 64, 64);
            lblOutputNameStudent.Location = new Point(14, 329);
            lblOutputNameStudent.Name = "lblOutputNameStudent";
            lblOutputNameStudent.Size = new Size(83, 26);
            lblOutputNameStudent.TabIndex = 0;
            lblOutputNameStudent.Text = "Nome: ";
            // 
            // lblOutputStudentAverage
            // 
            lblOutputStudentAverage.AutoSize = true;
            lblOutputStudentAverage.BackColor = Color.FromArgb(224, 224, 224);
            lblOutputStudentAverage.Font = new Font("Arial Unicode MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOutputStudentAverage.ForeColor = Color.FromArgb(64, 64, 64);
            lblOutputStudentAverage.Location = new Point(14, 365);
            lblOutputStudentAverage.Name = "lblOutputStudentAverage";
            lblOutputStudentAverage.Size = new Size(85, 26);
            lblOutputStudentAverage.TabIndex = 1;
            lblOutputStudentAverage.Text = "Média: ";
            // 
            // lblInputStudentName
            // 
            lblInputStudentName.AutoSize = true;
            lblInputStudentName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInputStudentName.Location = new Point(14, 29);
            lblInputStudentName.Name = "lblInputStudentName";
            lblInputStudentName.Size = new Size(142, 23);
            lblInputStudentName.TabIndex = 2;
            lblInputStudentName.Text = "Nome do Aluno";
            // 
            // txtInputStudentName
            // 
            txtInputStudentName.Location = new Point(14, 63);
            txtInputStudentName.Margin = new Padding(3, 4, 3, 4);
            txtInputStudentName.Name = "txtInputStudentName";
            txtInputStudentName.Size = new Size(372, 27);
            txtInputStudentName.TabIndex = 3;
            // 
            // btnRegisterStudentName
            // 
            btnRegisterStudentName.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegisterStudentName.Location = new Point(14, 101);
            btnRegisterStudentName.Margin = new Padding(3, 4, 3, 4);
            btnRegisterStudentName.Name = "btnRegisterStudentName";
            btnRegisterStudentName.Size = new Size(141, 49);
            btnRegisterStudentName.TabIndex = 4;
            btnRegisterStudentName.Text = "Cadastrar Aluno";
            btnRegisterStudentName.UseVisualStyleBackColor = true;
            btnRegisterStudentName.Click += btnRegisterStudentName_Click;
            // 
            // btnConsultStundetByName
            // 
            btnConsultStundetByName.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultStundetByName.Location = new Point(161, 101);
            btnConsultStundetByName.Margin = new Padding(3, 4, 3, 4);
            btnConsultStundetByName.Name = "btnConsultStundetByName";
            btnConsultStundetByName.Size = new Size(141, 49);
            btnConsultStundetByName.TabIndex = 5;
            btnConsultStundetByName.Text = "Consultar Aluno";
            btnConsultStundetByName.UseVisualStyleBackColor = true;
            btnConsultStundetByName.Click += btnConsultStundetByName_Click;
            // 
            // btnRegisterStudentNote
            // 
            btnRegisterStudentNote.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegisterStudentNote.Location = new Point(14, 247);
            btnRegisterStudentNote.Margin = new Padding(3, 4, 3, 4);
            btnRegisterStudentNote.Name = "btnRegisterStudentNote";
            btnRegisterStudentNote.Size = new Size(141, 49);
            btnRegisterStudentNote.TabIndex = 8;
            btnRegisterStudentNote.Text = "Cadastrar Nota";
            btnRegisterStudentNote.UseVisualStyleBackColor = true;
            btnRegisterStudentNote.Click += btnRegisterStudentNote_Click;
            // 
            // txtInputStudentNote
            // 
            txtInputStudentNote.Location = new Point(14, 208);
            txtInputStudentNote.Margin = new Padding(3, 4, 3, 4);
            txtInputStudentNote.Name = "txtInputStudentNote";
            txtInputStudentNote.Size = new Size(372, 27);
            txtInputStudentNote.TabIndex = 7;
            // 
            // lblInputStudentNote
            // 
            lblInputStudentNote.AutoSize = true;
            lblInputStudentNote.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInputStudentNote.Location = new Point(14, 175);
            lblInputStudentNote.Name = "lblInputStudentNote";
            lblInputStudentNote.Size = new Size(101, 23);
            lblInputStudentNote.TabIndex = 6;
            lblInputStudentNote.Text = "Nova Nota";
            // 
            // btnConsultAverageNoteOfAtualStudent
            // 
            btnConsultAverageNoteOfAtualStudent.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultAverageNoteOfAtualStudent.Location = new Point(161, 247);
            btnConsultAverageNoteOfAtualStudent.Margin = new Padding(3, 4, 3, 4);
            btnConsultAverageNoteOfAtualStudent.Name = "btnConsultAverageNoteOfAtualStudent";
            btnConsultAverageNoteOfAtualStudent.Size = new Size(141, 49);
            btnConsultAverageNoteOfAtualStudent.TabIndex = 9;
            btnConsultAverageNoteOfAtualStudent.Text = "Consultar Média";
            btnConsultAverageNoteOfAtualStudent.UseVisualStyleBackColor = true;
            btnConsultAverageNoteOfAtualStudent.Click += btnConsultAverageNoteOfAtualStudent_Click;
            // 
            // lblOutputMsg
            // 
            lblOutputMsg.AutoSize = true;
            lblOutputMsg.Font = new Font("Arial", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOutputMsg.Location = new Point(14, 300);
            lblOutputMsg.Name = "lblOutputMsg";
            lblOutputMsg.Size = new Size(0, 16);
            lblOutputMsg.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 485);
            Controls.Add(lblOutputMsg);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private Label lblOutputMsg;
    }
}
