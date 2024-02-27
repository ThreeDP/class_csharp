namespace exer_08
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
            txtInput = new TextBox();
            lblTitleResult = new Label();
            lblOutputResult = new Label();
            button1 = new Button();
            lblInfo = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(64, 54);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(286, 22);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Par? impar? Não sei, Testa ai:";
            // 
            // txtInput
            // 
            txtInput.Font = new Font("Arial Unicode MS", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInput.Location = new Point(64, 108);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(286, 50);
            txtInput.TabIndex = 1;
            // 
            // lblTitleResult
            // 
            lblTitleResult.AutoSize = true;
            lblTitleResult.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleResult.Location = new Point(64, 196);
            lblTitleResult.Name = "lblTitleResult";
            lblTitleResult.Size = new Size(110, 22);
            lblTitleResult.TabIndex = 2;
            lblTitleResult.Text = "Resultado:";
            // 
            // lblOutputResult
            // 
            lblOutputResult.BackColor = Color.FromArgb(224, 224, 224);
            lblOutputResult.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOutputResult.ForeColor = Color.FromArgb(64, 64, 64);
            lblOutputResult.Location = new Point(64, 236);
            lblOutputResult.Name = "lblOutputResult";
            lblOutputResult.Size = new Size(286, 131);
            lblOutputResult.TabIndex = 3;
            lblOutputResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Unicode MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(121, 388);
            button1.Name = "button1";
            button1.Size = new Size(172, 50);
            button1.TabIndex = 4;
            button1.Text = "Verificar Valor";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Arial", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblInfo.Location = new Point(64, 161);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(0, 14);
            lblInfo.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 450);
            Controls.Add(lblInfo);
            Controls.Add(button1);
            Controls.Add(lblOutputResult);
            Controls.Add(lblTitleResult);
            Controls.Add(txtInput);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtInput;
        private Label lblTitleResult;
        private Label lblOutputResult;
        private Button button1;
        private Label lblInfo;
    }
}
