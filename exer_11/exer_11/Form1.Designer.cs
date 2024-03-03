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
            txtInputStudentName = new TextBox();
            btnRegisterAverage = new Button();
            lblRegisterStudentMsg = new Label();
            lblStudentName = new Label();
            lblTitleStudentAverage = new Label();
            txtInputStudentAverage = new TextBox();
            lblTitleNumberOfAverage = new Label();
            lblOutputNumberOfStudents = new Label();
            lblOutputClassRoomAverage = new Label();
            lblTitleClassRoomAverage = new Label();
            SuspendLayout();
            // 
            // lblTitleRegisterStudent
            // 
            lblTitleRegisterStudent.AutoSize = true;
            lblTitleRegisterStudent.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleRegisterStudent.Location = new Point(37, 33);
            lblTitleRegisterStudent.Margin = new Padding(0, 0, 3, 0);
            lblTitleRegisterStudent.Name = "lblTitleRegisterStudent";
            lblTitleRegisterStudent.Size = new Size(350, 34);
            lblTitleRegisterStudent.TabIndex = 0;
            lblTitleRegisterStudent.Text = "Entrar Média do Aluno:";
            // 
            // txtInputStudentName
            // 
            txtInputStudentName.Location = new Point(119, 90);
            txtInputStudentName.Name = "txtInputStudentName";
            txtInputStudentName.Size = new Size(217, 27);
            txtInputStudentName.TabIndex = 1;
            // 
            // btnRegisterAverage
            // 
            btnRegisterAverage.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegisterAverage.Location = new Point(37, 198);
            btnRegisterAverage.Name = "btnRegisterAverage";
            btnRegisterAverage.Size = new Size(200, 42);
            btnRegisterAverage.TabIndex = 2;
            btnRegisterAverage.Text = "Cadastrar Média";
            btnRegisterAverage.UseVisualStyleBackColor = true;
            btnRegisterAverage.Click += btnRegister_Click;
            // 
            // lblRegisterStudentMsg
            // 
            lblRegisterStudentMsg.AutoSize = true;
            lblRegisterStudentMsg.ForeColor = Color.Black;
            lblRegisterStudentMsg.Location = new Point(37, 248);
            lblRegisterStudentMsg.Name = "lblRegisterStudentMsg";
            lblRegisterStudentMsg.Size = new Size(0, 20);
            lblRegisterStudentMsg.TabIndex = 3;
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Location = new Point(50, 90);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(53, 20);
            lblStudentName.TabIndex = 4;
            lblStudentName.Text = "Nome:";
            // 
            // lblTitleStudentAverage
            // 
            lblTitleStudentAverage.AutoSize = true;
            lblTitleStudentAverage.Location = new Point(50, 141);
            lblTitleStudentAverage.Name = "lblTitleStudentAverage";
            lblTitleStudentAverage.Size = new Size(54, 20);
            lblTitleStudentAverage.TabIndex = 6;
            lblTitleStudentAverage.Text = "Média:";
            // 
            // txtInputStudentAverage
            // 
            txtInputStudentAverage.Location = new Point(119, 141);
            txtInputStudentAverage.Name = "txtInputStudentAverage";
            txtInputStudentAverage.Size = new Size(78, 27);
            txtInputStudentAverage.TabIndex = 5;
            // 
            // lblTitleNumberOfAverage
            // 
            lblTitleNumberOfAverage.AutoSize = true;
            lblTitleNumberOfAverage.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleNumberOfAverage.Location = new Point(430, 33);
            lblTitleNumberOfAverage.Margin = new Padding(0, 0, 3, 0);
            lblTitleNumberOfAverage.Name = "lblTitleNumberOfAverage";
            lblTitleNumberOfAverage.Size = new Size(442, 34);
            lblTitleNumberOfAverage.TabIndex = 7;
            lblTitleNumberOfAverage.Text = "Número de médias inseridas:";
            lblTitleNumberOfAverage.UseMnemonic = false;
            // 
            // lblOutputNumberOfStudents
            // 
            lblOutputNumberOfStudents.AutoSize = true;
            lblOutputNumberOfStudents.Font = new Font("Arial Rounded MT Bold", 79.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOutputNumberOfStudents.Location = new Point(579, 75);
            lblOutputNumberOfStudents.Margin = new Padding(0, 0, 3, 0);
            lblOutputNumberOfStudents.Name = "lblOutputNumberOfStudents";
            lblOutputNumberOfStudents.Size = new Size(144, 154);
            lblOutputNumberOfStudents.TabIndex = 8;
            lblOutputNumberOfStudents.Text = "0";
            lblOutputNumberOfStudents.UseMnemonic = false;
            // 
            // lblOutputClassRoomAverage
            // 
            lblOutputClassRoomAverage.AutoSize = true;
            lblOutputClassRoomAverage.Font = new Font("Arial Rounded MT Bold", 79.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOutputClassRoomAverage.Location = new Point(579, 283);
            lblOutputClassRoomAverage.Margin = new Padding(0, 0, 3, 0);
            lblOutputClassRoomAverage.Name = "lblOutputClassRoomAverage";
            lblOutputClassRoomAverage.Size = new Size(144, 154);
            lblOutputClassRoomAverage.TabIndex = 10;
            lblOutputClassRoomAverage.Text = "0";
            lblOutputClassRoomAverage.UseMnemonic = false;
            // 
            // lblTitleClassRoomAverage
            // 
            lblTitleClassRoomAverage.AutoSize = true;
            lblTitleClassRoomAverage.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleClassRoomAverage.Location = new Point(430, 242);
            lblTitleClassRoomAverage.Margin = new Padding(0, 0, 3, 0);
            lblTitleClassRoomAverage.Name = "lblTitleClassRoomAverage";
            lblTitleClassRoomAverage.Size = new Size(229, 34);
            lblTitleClassRoomAverage.TabIndex = 9;
            lblTitleClassRoomAverage.Text = "Média da Sala:";
            lblTitleClassRoomAverage.UseMnemonic = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 450);
            Controls.Add(lblOutputClassRoomAverage);
            Controls.Add(lblTitleClassRoomAverage);
            Controls.Add(lblOutputNumberOfStudents);
            Controls.Add(lblTitleNumberOfAverage);
            Controls.Add(lblTitleStudentAverage);
            Controls.Add(txtInputStudentAverage);
            Controls.Add(lblStudentName);
            Controls.Add(lblRegisterStudentMsg);
            Controls.Add(btnRegisterAverage);
            Controls.Add(txtInputStudentName);
            Controls.Add(lblTitleRegisterStudent);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitleRegisterStudent;
        private TextBox txtInputStudentName;
        private Button btnRegisterAverage;
        private Label lblRegisterStudentMsg;
        private Label lblStudentName;
        private Label lblTitleStudentAverage;
        private TextBox txtInputStudentAverage;
        private Label lblTitleNumberOfAverage;
        private Label lblOutputNumberOfStudents;
        private Label lblOutputClassRoomAverage;
        private Label lblTitleClassRoomAverage;
    }
}
