namespace exer_05
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
            lblOutput = new Label();
            btnGenerate = new Button();
            SuspendLayout();
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.BackColor = SystemColors.ControlDark;
            lblOutput.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOutput.Location = new Point(79, 47);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(0, 18);
            lblOutput.TabIndex = 0;
            lblOutput.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(79, 376);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(136, 35);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "Gerar Mensagem";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 450);
            Controls.Add(btnGenerate);
            Controls.Add(lblOutput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOutput;
        private Button btnGenerate;
    }
}
