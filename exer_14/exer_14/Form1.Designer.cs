namespace exer_14
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
            txtInputEmployerName = new TextBox();
            lblTitleRegisterEmployer = new Label();
            lblInputEmployerName = new Label();
            lblInputEmployerGrossSalary = new Label();
            txtInputEmployerGrossSalary = new TextBox();
            btnRegisterEmployer = new Button();
            lblTitleShowEmployerInformation = new Label();
            btnFindmployer = new Button();
            lblInputIdEmployerForSearch = new Label();
            txtInputIdEmployerForSearch = new TextBox();
            txtOutputShowEmployerInformation = new TextBox();
            lblMessageEmployerRegister = new Label();
            SuspendLayout();
            // 
            // txtInputEmployerName
            // 
            txtInputEmployerName.Location = new Point(12, 83);
            txtInputEmployerName.Name = "txtInputEmployerName";
            txtInputEmployerName.Size = new Size(297, 23);
            txtInputEmployerName.TabIndex = 2;
            // 
            // lblTitleRegisterEmployer
            // 
            lblTitleRegisterEmployer.AutoSize = true;
            lblTitleRegisterEmployer.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleRegisterEmployer.Location = new Point(12, 23);
            lblTitleRegisterEmployer.Name = "lblTitleRegisterEmployer";
            lblTitleRegisterEmployer.Size = new Size(266, 24);
            lblTitleRegisterEmployer.TabIndex = 0;
            lblTitleRegisterEmployer.Text = "Cadastro de Funcionário:";
            // 
            // lblInputEmployerName
            // 
            lblInputEmployerName.AutoSize = true;
            lblInputEmployerName.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInputEmployerName.Location = new Point(12, 64);
            lblInputEmployerName.Name = "lblInputEmployerName";
            lblInputEmployerName.Size = new Size(41, 16);
            lblInputEmployerName.TabIndex = 1;
            lblInputEmployerName.Text = "Nome";
            // 
            // lblInputEmployerGrossSalary
            // 
            lblInputEmployerGrossSalary.AutoSize = true;
            lblInputEmployerGrossSalary.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInputEmployerGrossSalary.Location = new Point(12, 118);
            lblInputEmployerGrossSalary.Name = "lblInputEmployerGrossSalary";
            lblInputEmployerGrossSalary.Size = new Size(82, 16);
            lblInputEmployerGrossSalary.TabIndex = 3;
            lblInputEmployerGrossSalary.Text = "Salário Bruto";
            // 
            // txtInputEmployerGrossSalary
            // 
            txtInputEmployerGrossSalary.Location = new Point(12, 137);
            txtInputEmployerGrossSalary.Name = "txtInputEmployerGrossSalary";
            txtInputEmployerGrossSalary.Size = new Size(131, 23);
            txtInputEmployerGrossSalary.TabIndex = 4;
            // 
            // btnRegisterEmployer
            // 
            btnRegisterEmployer.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegisterEmployer.Location = new Point(164, 128);
            btnRegisterEmployer.Name = "btnRegisterEmployer";
            btnRegisterEmployer.Size = new Size(145, 32);
            btnRegisterEmployer.TabIndex = 5;
            btnRegisterEmployer.Text = "Cadastrar Funcionário";
            btnRegisterEmployer.UseVisualStyleBackColor = true;
            btnRegisterEmployer.Click += btnRegisterEmployer_Click;
            // 
            // lblTitleShowEmployerInformation
            // 
            lblTitleShowEmployerInformation.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleShowEmployerInformation.Location = new Point(12, 188);
            lblTitleShowEmployerInformation.Name = "lblTitleShowEmployerInformation";
            lblTitleShowEmployerInformation.Size = new Size(266, 53);
            lblTitleShowEmployerInformation.TabIndex = 6;
            lblTitleShowEmployerInformation.Text = "Visualizar Informações de Funcionário:";
            // 
            // btnFindmployer
            // 
            btnFindmployer.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFindmployer.Location = new Point(164, 264);
            btnFindmployer.Name = "btnFindmployer";
            btnFindmployer.Size = new Size(145, 32);
            btnFindmployer.TabIndex = 9;
            btnFindmployer.Text = "Buscar Funcionário";
            btnFindmployer.UseVisualStyleBackColor = true;
            btnFindmployer.Click += btnFindmployer_Click;
            // 
            // lblInputIdEmployerForSearch
            // 
            lblInputIdEmployerForSearch.AutoSize = true;
            lblInputIdEmployerForSearch.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInputIdEmployerForSearch.Location = new Point(12, 254);
            lblInputIdEmployerForSearch.Name = "lblInputIdEmployerForSearch";
            lblInputIdEmployerForSearch.Size = new Size(106, 16);
            lblInputIdEmployerForSearch.TabIndex = 7;
            lblInputIdEmployerForSearch.Text = "Id do Funcionário";
            // 
            // txtInputIdEmployerForSearch
            // 
            txtInputIdEmployerForSearch.Location = new Point(12, 273);
            txtInputIdEmployerForSearch.Name = "txtInputIdEmployerForSearch";
            txtInputIdEmployerForSearch.Size = new Size(131, 23);
            txtInputIdEmployerForSearch.TabIndex = 8;
            // 
            // txtOutputShowEmployerInformation
            // 
            txtOutputShowEmployerInformation.Enabled = false;
            txtOutputShowEmployerInformation.Location = new Point(12, 322);
            txtOutputShowEmployerInformation.Multiline = true;
            txtOutputShowEmployerInformation.Name = "txtOutputShowEmployerInformation";
            txtOutputShowEmployerInformation.ReadOnly = true;
            txtOutputShowEmployerInformation.Size = new Size(297, 100);
            txtOutputShowEmployerInformation.TabIndex = 10;
            txtOutputShowEmployerInformation.TextAlign = HorizontalAlignment.Center;
            // 
            // lblMessageEmployerRegister
            // 
            lblMessageEmployerRegister.AutoSize = true;
            lblMessageEmployerRegister.Font = new Font("Arial", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMessageEmployerRegister.Location = new Point(12, 163);
            lblMessageEmployerRegister.Name = "lblMessageEmployerRegister";
            lblMessageEmployerRegister.Size = new Size(0, 12);
            lblMessageEmployerRegister.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 450);
            Controls.Add(lblMessageEmployerRegister);
            Controls.Add(txtOutputShowEmployerInformation);
            Controls.Add(btnFindmployer);
            Controls.Add(lblInputIdEmployerForSearch);
            Controls.Add(txtInputIdEmployerForSearch);
            Controls.Add(lblTitleShowEmployerInformation);
            Controls.Add(btnRegisterEmployer);
            Controls.Add(lblInputEmployerGrossSalary);
            Controls.Add(txtInputEmployerGrossSalary);
            Controls.Add(lblInputEmployerName);
            Controls.Add(lblTitleRegisterEmployer);
            Controls.Add(txtInputEmployerName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInputEmployerName;
        private Label lblTitleRegisterEmployer;
        private Label lblInputEmployerName;
        private Label lblInputEmployerGrossSalary;
        private TextBox txtInputEmployerGrossSalary;
        private Button btnRegisterEmployer;
        private Label lblTitleShowEmployerInformation;
        private Button btnFindmployer;
        private Label lblInputIdEmployerForSearch;
        private TextBox txtInputIdEmployerForSearch;
        private TextBox txtOutputShowEmployerInformation;
        private Label lblMessageEmployerRegister;
    }
}
