namespace exer_06
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
            lblTitle = new Label();
            txtInputN1 = new TextBox();
            txtInputN2 = new TextBox();
            lblN1 = new Label();
            lblN2 = new Label();
            lblTitleResult = new Label();
            lblResult = new Label();
            btnGenResult = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial Unicode MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(24, 32);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(330, 21);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Calcule a Diferença entre dois numeros:";
            // 
            // txtInputN1
            // 
            txtInputN1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInputN1.Location = new Point(35, 106);
            txtInputN1.Name = "txtInputN1";
            txtInputN1.Size = new Size(75, 22);
            txtInputN1.TabIndex = 2;
            // 
            // txtInputN2
            // 
            txtInputN2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInputN2.Location = new Point(179, 106);
            txtInputN2.Name = "txtInputN2";
            txtInputN2.Size = new Size(75, 22);
            txtInputN2.TabIndex = 3;
            // 
            // lblN1
            // 
            lblN1.AutoSize = true;
            lblN1.Location = new Point(35, 88);
            lblN1.Name = "lblN1";
            lblN1.Size = new Size(22, 15);
            lblN1.TabIndex = 4;
            lblN1.Text = "N1";
            // 
            // lblN2
            // 
            lblN2.AutoSize = true;
            lblN2.Location = new Point(179, 88);
            lblN2.Name = "lblN2";
            lblN2.Size = new Size(22, 15);
            lblN2.TabIndex = 5;
            lblN2.Text = "N2";
            // 
            // lblTitleResult
            // 
            lblTitleResult.AutoSize = true;
            lblTitleResult.Font = new Font("Arial Unicode MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleResult.Location = new Point(24, 165);
            lblTitleResult.Name = "lblTitleResult";
            lblTitleResult.Size = new Size(203, 21);
            lblTitleResult.TabIndex = 6;
            lblTitleResult.Text = "Resultado da Diferença:";
            // 
            // lblResult
            // 
            lblResult.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(24, 216);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(330, 97);
            lblResult.TabIndex = 7;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGenResult
            // 
            btnGenResult.Location = new Point(132, 347);
            btnGenResult.Name = "btnGenResult";
            btnGenResult.Size = new Size(115, 35);
            btnGenResult.TabIndex = 8;
            btnGenResult.Text = "Gerar Resposta";
            btnGenResult.UseVisualStyleBackColor = true;
            btnGenResult.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 450);
            Controls.Add(btnGenResult);
            Controls.Add(lblResult);
            Controls.Add(lblTitleResult);
            Controls.Add(lblN2);
            Controls.Add(lblN1);
            Controls.Add(txtInputN2);
            Controls.Add(txtInputN1);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtInputN1;
        private TextBox txtInputN2;
        private Label lblN1;
        private Label lblN2;
        private Label lblTitleResult;
        private Label lblResult;
        private Button btnGenResult;
    }
}
