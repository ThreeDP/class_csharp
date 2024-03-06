namespace exer_13
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
            lbTitlelAccountManagement = new Label();
            lblTitleCreateBankAccount = new Label();
            lblTitleInputValueInAccount = new Label();
            txtInputValueInAccount = new TextBox();
            lblTitleAccountNumberCreateAccount = new Label();
            label2 = new Label();
            lblOutputAccountNumberCreateAccount = new Label();
            btnCreateABankAccount = new Button();
            txtInputAccountNumberManagement = new TextBox();
            lblTitleInputAccountNumberManagement = new Label();
            txtInputValue = new TextBox();
            lblTitleInputValue = new Label();
            upDownTypeOfActionInAccount = new DomainUpDown();
            lblTittleTypeOfActionInAccount = new Label();
            btnActionInAccount = new Button();
            lblOutputAccountBalance = new Label();
            lblTitleOutputAccountBalance = new Label();
            SuspendLayout();
            // 
            // lbTitlelAccountManagement
            // 
            lbTitlelAccountManagement.BackColor = Color.FromArgb(224, 224, 224);
            lbTitlelAccountManagement.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitlelAccountManagement.Location = new Point(26, 280);
            lbTitlelAccountManagement.Name = "lbTitlelAccountManagement";
            lbTitlelAccountManagement.Padding = new Padding(6);
            lbTitlelAccountManagement.Size = new Size(434, 47);
            lbTitlelAccountManagement.TabIndex = 0;
            lbTitlelAccountManagement.Text = "Gerenciar Conta:";
            // 
            // lblTitleCreateBankAccount
            // 
            lblTitleCreateBankAccount.AutoSize = true;
            lblTitleCreateBankAccount.BackColor = Color.FromArgb(224, 224, 224);
            lblTitleCreateBankAccount.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleCreateBankAccount.Location = new Point(26, 28);
            lblTitleCreateBankAccount.Name = "lblTitleCreateBankAccount";
            lblTitleCreateBankAccount.Padding = new Padding(6);
            lblTitleCreateBankAccount.Size = new Size(190, 45);
            lblTitleCreateBankAccount.TabIndex = 1;
            lblTitleCreateBankAccount.Text = "Criar Conta:";
            // 
            // lblTitleInputValueInAccount
            // 
            lblTitleInputValueInAccount.AutoSize = true;
            lblTitleInputValueInAccount.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleInputValueInAccount.Location = new Point(26, 99);
            lblTitleInputValueInAccount.Name = "lblTitleInputValueInAccount";
            lblTitleInputValueInAccount.Size = new Size(170, 19);
            lblTitleInputValueInAccount.TabIndex = 2;
            lblTitleInputValueInAccount.Text = "Valor Inicial da Conta:";
            // 
            // txtInputValueInAccount
            // 
            txtInputValueInAccount.BorderStyle = BorderStyle.None;
            txtInputValueInAccount.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInputValueInAccount.Location = new Point(26, 127);
            txtInputValueInAccount.Name = "txtInputValueInAccount";
            txtInputValueInAccount.Size = new Size(190, 27);
            txtInputValueInAccount.TabIndex = 3;
            // 
            // lblTitleAccountNumberCreateAccount
            // 
            lblTitleAccountNumberCreateAccount.AutoSize = true;
            lblTitleAccountNumberCreateAccount.BackColor = Color.FromArgb(224, 224, 224);
            lblTitleAccountNumberCreateAccount.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleAccountNumberCreateAccount.Location = new Point(239, 28);
            lblTitleAccountNumberCreateAccount.Name = "lblTitleAccountNumberCreateAccount";
            lblTitleAccountNumberCreateAccount.Padding = new Padding(6);
            lblTitleAccountNumberCreateAccount.Size = new Size(221, 31);
            lblTitleAccountNumberCreateAccount.TabIndex = 4;
            lblTitleAccountNumberCreateAccount.Text = "Numero da Conta Criada:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(224, 224, 224);
            label2.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(702, 448);
            label2.Name = "label2";
            label2.Padding = new Padding(6);
            label2.Size = new Size(221, 31);
            label2.TabIndex = 5;
            label2.Text = "Numero da Conta Criada:";
            // 
            // lblOutputAccountNumberCreateAccount
            // 
            lblOutputAccountNumberCreateAccount.BackColor = Color.FromArgb(224, 224, 224);
            lblOutputAccountNumberCreateAccount.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOutputAccountNumberCreateAccount.Location = new Point(239, 68);
            lblOutputAccountNumberCreateAccount.Name = "lblOutputAccountNumberCreateAccount";
            lblOutputAccountNumberCreateAccount.Padding = new Padding(6);
            lblOutputAccountNumberCreateAccount.Size = new Size(221, 92);
            lblOutputAccountNumberCreateAccount.TabIndex = 6;
            lblOutputAccountNumberCreateAccount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCreateABankAccount
            // 
            btnCreateABankAccount.BackColor = Color.White;
            btnCreateABankAccount.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateABankAccount.Location = new Point(26, 180);
            btnCreateABankAccount.Name = "btnCreateABankAccount";
            btnCreateABankAccount.Size = new Size(170, 48);
            btnCreateABankAccount.TabIndex = 7;
            btnCreateABankAccount.Text = "Cria Conta";
            btnCreateABankAccount.UseVisualStyleBackColor = false;
            btnCreateABankAccount.Click += btnCreateABankAccount_Click;
            // 
            // txtInputAccountNumberManagement
            // 
            txtInputAccountNumberManagement.BorderStyle = BorderStyle.None;
            txtInputAccountNumberManagement.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInputAccountNumberManagement.Location = new Point(26, 372);
            txtInputAccountNumberManagement.Name = "txtInputAccountNumberManagement";
            txtInputAccountNumberManagement.Size = new Size(190, 27);
            txtInputAccountNumberManagement.TabIndex = 9;
            // 
            // lblTitleInputAccountNumberManagement
            // 
            lblTitleInputAccountNumberManagement.AutoSize = true;
            lblTitleInputAccountNumberManagement.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleInputAccountNumberManagement.Location = new Point(26, 344);
            lblTitleInputAccountNumberManagement.Name = "lblTitleInputAccountNumberManagement";
            lblTitleInputAccountNumberManagement.Size = new Size(142, 19);
            lblTitleInputAccountNumberManagement.TabIndex = 8;
            lblTitleInputAccountNumberManagement.Text = "Numero da Conta:";
            // 
            // txtInputValue
            // 
            txtInputValue.BorderStyle = BorderStyle.None;
            txtInputValue.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInputValue.Location = new Point(26, 444);
            txtInputValue.Name = "txtInputValue";
            txtInputValue.Size = new Size(190, 27);
            txtInputValue.TabIndex = 11;
            // 
            // lblTitleInputValue
            // 
            lblTitleInputValue.AutoSize = true;
            lblTitleInputValue.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitleInputValue.Location = new Point(26, 416);
            lblTitleInputValue.Name = "lblTitleInputValue";
            lblTitleInputValue.Size = new Size(51, 19);
            lblTitleInputValue.TabIndex = 10;
            lblTitleInputValue.Text = "Valor:";
            // 
            // upDownTypeOfActionInAccount
            // 
            upDownTypeOfActionInAccount.Items.Add("Déposito");
            upDownTypeOfActionInAccount.Items.Add("Saque");
            upDownTypeOfActionInAccount.Items.Add("Consultar Saldo");
            upDownTypeOfActionInAccount.Location = new Point(26, 516);
            upDownTypeOfActionInAccount.Name = "upDownTypeOfActionInAccount";
            upDownTypeOfActionInAccount.SelectedIndex = 0;
            upDownTypeOfActionInAccount.Size = new Size(190, 27);
            upDownTypeOfActionInAccount.TabIndex = 12;
            upDownTypeOfActionInAccount.Text = "Déposito";
            upDownTypeOfActionInAccount.SelectedItemChanged += upDownTypeOfActionInAccount_SelectedItemChanged;
            // 
            // lblTittleTypeOfActionInAccount
            // 
            lblTittleTypeOfActionInAccount.AutoSize = true;
            lblTittleTypeOfActionInAccount.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTittleTypeOfActionInAccount.Location = new Point(26, 492);
            lblTittleTypeOfActionInAccount.Name = "lblTittleTypeOfActionInAccount";
            lblTittleTypeOfActionInAccount.Size = new Size(122, 19);
            lblTittleTypeOfActionInAccount.TabIndex = 13;
            lblTittleTypeOfActionInAccount.Text = "Ação desejada:";
            // 
            // btnActionInAccount
            // 
            btnActionInAccount.BackColor = Color.White;
            btnActionInAccount.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActionInAccount.Location = new Point(239, 552);
            btnActionInAccount.Name = "btnActionInAccount";
            btnActionInAccount.Size = new Size(221, 48);
            btnActionInAccount.TabIndex = 14;
            btnActionInAccount.Text = "Dépositar Dinheiro";
            btnActionInAccount.UseVisualStyleBackColor = false;
            // 
            // lblOutputAccountBalance
            // 
            lblOutputAccountBalance.BackColor = Color.FromArgb(224, 224, 224);
            lblOutputAccountBalance.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOutputAccountBalance.Location = new Point(239, 379);
            lblOutputAccountBalance.Name = "lblOutputAccountBalance";
            lblOutputAccountBalance.Padding = new Padding(6);
            lblOutputAccountBalance.Size = new Size(221, 92);
            lblOutputAccountBalance.TabIndex = 16;
            lblOutputAccountBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitleOutputAccountBalance
            // 
            lblTitleOutputAccountBalance.AutoSize = true;
            lblTitleOutputAccountBalance.BackColor = Color.FromArgb(224, 224, 224);
            lblTitleOutputAccountBalance.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleOutputAccountBalance.Location = new Point(239, 339);
            lblTitleOutputAccountBalance.Name = "lblTitleOutputAccountBalance";
            lblTitleOutputAccountBalance.Padding = new Padding(6);
            lblTitleOutputAccountBalance.Size = new Size(147, 31);
            lblTitleOutputAccountBalance.TabIndex = 15;
            lblTitleOutputAccountBalance.Text = "Saldo da Conta:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 627);
            Controls.Add(lblOutputAccountBalance);
            Controls.Add(lblTitleOutputAccountBalance);
            Controls.Add(btnActionInAccount);
            Controls.Add(lblTittleTypeOfActionInAccount);
            Controls.Add(upDownTypeOfActionInAccount);
            Controls.Add(txtInputValue);
            Controls.Add(lblTitleInputValue);
            Controls.Add(txtInputAccountNumberManagement);
            Controls.Add(lblTitleInputAccountNumberManagement);
            Controls.Add(btnCreateABankAccount);
            Controls.Add(lblOutputAccountNumberCreateAccount);
            Controls.Add(label2);
            Controls.Add(lblTitleAccountNumberCreateAccount);
            Controls.Add(txtInputValueInAccount);
            Controls.Add(lblTitleInputValueInAccount);
            Controls.Add(lblTitleCreateBankAccount);
            Controls.Add(lbTitlelAccountManagement);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitlelAccountManagement;
        private Label lblTitleCreateBankAccount;
        private Label lblTitleInputValueInAccount;
        private TextBox txtInputValueInAccount;
        private Label lblTitleAccountNumberCreateAccount;
        private Label label2;
        private Label lblOutputAccountNumberCreateAccount;
        private Button btnCreateABankAccount;
        private TextBox txtInputAccountNumberManagement;
        private Label lblTitleInputAccountNumberManagement;
        private TextBox txtInputValue;
        private Label lblTitleInputValue;
        private DomainUpDown upDownTypeOfActionInAccount;
        private Label lblTittleTypeOfActionInAccount;
        private Button btnActionInAccount;
        private Label lblOutputAccountBalance;
        private Label lblTitleOutputAccountBalance;
    }
}
