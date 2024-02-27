namespace exer_03
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
            lblWorkHours = new Label();
            lblHourValue = new Label();
            lblDiscont = new Label();
            lblGrossSalary = new Label();
            lblTotalDiscount = new Label();
            lblNetSalary = new Label();
            lblOutputGrossSalary = new Label();
            lblOutputNetSalary = new Label();
            lblOutputDiscount = new Label();
            txtWorkHours = new TextBox();
            txtDiscount = new TextBox();
            txtHourValue = new TextBox();
            btnProcessSalary = new Button();
            lblInfo = new Label();
            SuspendLayout();
            // 
            // lblWorkHours
            // 
            lblWorkHours.AutoSize = true;
            lblWorkHours.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblWorkHours.Location = new Point(12, 51);
            lblWorkHours.Name = "lblWorkHours";
            lblWorkHours.Size = new Size(221, 19);
            lblWorkHours.TabIndex = 0;
            lblWorkHours.Text = "Quantas horas de trabalho?";
            // 
            // lblHourValue
            // 
            lblHourValue.AutoSize = true;
            lblHourValue.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblHourValue.Location = new Point(12, 89);
            lblHourValue.Name = "lblHourValue";
            lblHourValue.Size = new Size(172, 19);
            lblHourValue.TabIndex = 2;
            lblHourValue.Text = "Qual o valor da hora?";
            // 
            // lblDiscont
            // 
            lblDiscont.AutoSize = true;
            lblDiscont.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblDiscont.Location = new Point(12, 127);
            lblDiscont.Name = "lblDiscont";
            lblDiscont.Size = new Size(252, 19);
            lblDiscont.TabIndex = 4;
            lblDiscont.Text = "Qual o percentual de desconto?";
            // 
            // lblGrossSalary
            // 
            lblGrossSalary.AutoSize = true;
            lblGrossSalary.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblGrossSalary.Location = new Point(12, 210);
            lblGrossSalary.Name = "lblGrossSalary";
            lblGrossSalary.Size = new Size(107, 19);
            lblGrossSalary.TabIndex = 7;
            lblGrossSalary.Text = "Salário bruto";
            // 
            // lblTotalDiscount
            // 
            lblTotalDiscount.AutoSize = true;
            lblTotalDiscount.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblTotalDiscount.Location = new Point(12, 252);
            lblTotalDiscount.Name = "lblTotalDiscount";
            lblTotalDiscount.Size = new Size(147, 19);
            lblTotalDiscount.TabIndex = 9;
            lblTotalDiscount.Text = "Total de Desconto";
            // 
            // lblNetSalary
            // 
            lblNetSalary.AutoSize = true;
            lblNetSalary.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblNetSalary.Location = new Point(12, 294);
            lblNetSalary.Name = "lblNetSalary";
            lblNetSalary.Size = new Size(124, 19);
            lblNetSalary.TabIndex = 11;
            lblNetSalary.Text = "Salário Liquido";
            // 
            // lblOutputGrossSalary
            // 
            lblOutputGrossSalary.Anchor = AnchorStyles.Right;
            lblOutputGrossSalary.AutoSize = true;
            lblOutputGrossSalary.BackColor = SystemColors.ActiveBorder;
            lblOutputGrossSalary.Font = new Font("Arial", 12F);
            lblOutputGrossSalary.Location = new Point(316, 211);
            lblOutputGrossSalary.Name = "lblOutputGrossSalary";
            lblOutputGrossSalary.RightToLeft = RightToLeft.No;
            lblOutputGrossSalary.Size = new Size(13, 18);
            lblOutputGrossSalary.TabIndex = 8;
            lblOutputGrossSalary.Text = "-";
            lblOutputGrossSalary.TextAlign = ContentAlignment.TopRight;
            // 
            // lblOutputNetSalary
            // 
            lblOutputNetSalary.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblOutputNetSalary.AutoSize = true;
            lblOutputNetSalary.BackColor = SystemColors.ActiveBorder;
            lblOutputNetSalary.Font = new Font("Arial", 12F);
            lblOutputNetSalary.Location = new Point(316, 295);
            lblOutputNetSalary.Name = "lblOutputNetSalary";
            lblOutputNetSalary.Size = new Size(13, 18);
            lblOutputNetSalary.TabIndex = 12;
            lblOutputNetSalary.Text = "-";
            lblOutputNetSalary.TextAlign = ContentAlignment.TopRight;
            // 
            // lblOutputDiscount
            // 
            lblOutputDiscount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblOutputDiscount.AutoSize = true;
            lblOutputDiscount.BackColor = SystemColors.ActiveBorder;
            lblOutputDiscount.Font = new Font("Arial", 12F);
            lblOutputDiscount.Location = new Point(316, 253);
            lblOutputDiscount.Name = "lblOutputDiscount";
            lblOutputDiscount.Size = new Size(13, 18);
            lblOutputDiscount.TabIndex = 10;
            lblOutputDiscount.Text = "-";
            lblOutputDiscount.TextAlign = ContentAlignment.TopRight;
            // 
            // txtWorkHours
            // 
            txtWorkHours.Location = new Point(311, 52);
            txtWorkHours.Name = "txtWorkHours";
            txtWorkHours.Size = new Size(100, 23);
            txtWorkHours.TabIndex = 1;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(311, 124);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(100, 23);
            txtDiscount.TabIndex = 5;
            // 
            // txtHourValue
            // 
            txtHourValue.Location = new Point(311, 90);
            txtHourValue.Name = "txtHourValue";
            txtHourValue.Size = new Size(100, 23);
            txtHourValue.TabIndex = 3;
            // 
            // btnProcessSalary
            // 
            btnProcessSalary.BackColor = SystemColors.ButtonHighlight;
            btnProcessSalary.Location = new Point(12, 166);
            btnProcessSalary.Name = "btnProcessSalary";
            btnProcessSalary.Size = new Size(100, 23);
            btnProcessSalary.TabIndex = 6;
            btnProcessSalary.Text = "Salário Liquido";
            btnProcessSalary.UseVisualStyleBackColor = false;
            btnProcessSalary.Click += btnProcessSalary_Click;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(12, 337);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(0, 15);
            lblInfo.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 361);
            Controls.Add(lblInfo);
            Controls.Add(btnProcessSalary);
            Controls.Add(txtHourValue);
            Controls.Add(txtDiscount);
            Controls.Add(txtWorkHours);
            Controls.Add(lblOutputDiscount);
            Controls.Add(lblOutputNetSalary);
            Controls.Add(lblOutputGrossSalary);
            Controls.Add(lblNetSalary);
            Controls.Add(lblTotalDiscount);
            Controls.Add(lblGrossSalary);
            Controls.Add(lblDiscont);
            Controls.Add(lblHourValue);
            Controls.Add(lblWorkHours);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWorkHours;
        private Label lblHourValue;
        private Label lblDiscont;
        private Label lblGrossSalary;
        private Label lblTotalDiscount;
        private Label lblNetSalary;
        private Label label2;
        private Label lblOutputGrossSalary;
        private Label lblOutputNetSalary;
        private Label lblOutputDiscount;
        private TextBox txtWorkHours;
        private TextBox txtDiscount;
        private TextBox txtHourValue;
        private Button btnProcessSalary;
        private Label lblInfo;
    }
}
