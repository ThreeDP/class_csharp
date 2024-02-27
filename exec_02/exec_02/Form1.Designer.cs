namespace exec_02
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
            btnAdd = new Button();
            btnSub = new Button();
            btnDiv = new Button();
            btnMul = new Button();
            lblTitleResult = new Label();
            lblResult = new Label();
            txtInputValueOne = new TextBox();
            txtInputValueTwo = new TextBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(287, 217);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(45, 42);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSub
            // 
            btnSub.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSub.Location = new Point(338, 217);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(45, 42);
            btnSub.TabIndex = 1;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDiv.Location = new Point(398, 217);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(45, 42);
            btnDiv.TabIndex = 2;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnMul
            // 
            btnMul.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMul.Location = new Point(449, 217);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(45, 42);
            btnMul.TabIndex = 3;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += btnMul_Click;
            // 
            // lblTitleResult
            // 
            lblTitleResult.AutoSize = true;
            lblTitleResult.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleResult.Location = new Point(360, 78);
            lblTitleResult.Name = "lblTitleResult";
            lblTitleResult.Size = new Size(64, 15);
            lblTitleResult.TabIndex = 5;
            lblTitleResult.Text = "Resultado";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(287, 130);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 34);
            lblResult.TabIndex = 6;
            // 
            // txtInputValueOne
            // 
            txtInputValueOne.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInputValueOne.Location = new Point(314, 179);
            txtInputValueOne.Name = "txtInputValueOne";
            txtInputValueOne.Size = new Size(69, 32);
            txtInputValueOne.TabIndex = 7;

            // 
            // txtInputValueTwo
            // 
            txtInputValueTwo.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInputValueTwo.Location = new Point(398, 179);
            txtInputValueTwo.Name = "txtInputValueTwo";
            txtInputValueTwo.Size = new Size(69, 32);
            txtInputValueTwo.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtInputValueTwo);
            Controls.Add(txtInputValueOne);
            Controls.Add(lblResult);
            Controls.Add(lblTitleResult);
            Controls.Add(btnMul);
            Controls.Add(btnDiv);
            Controls.Add(btnSub);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnSub;
        private Button btnDiv;
        private Button btnMul;
        private Label lblTitleResult;
        private Label lblResult;
        private TextBox txtInputValueOne;
        private TextBox txtInputValueTwo;
    }
}
