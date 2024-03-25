namespace exer_15
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
            lblTitleBooks = new Label();
            txtOutputShowBookInfo = new TextBox();
            lblMessageEmployerRegister = new Label();
            dUDSelectBook = new DomainUpDown();
            btnLendBook = new Button();
            btnReturnBook = new Button();
            btnFindBook = new Button();
            SuspendLayout();
            // 
            // lblTitleBooks
            // 
            lblTitleBooks.AutoSize = true;
            lblTitleBooks.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleBooks.Location = new Point(20, 31);
            lblTitleBooks.Name = "lblTitleBooks";
            lblTitleBooks.Size = new Size(287, 32);
            lblTitleBooks.TabIndex = 0;
            lblTitleBooks.Text = "Livros da Biblioteca:";
            // 
            // txtOutputShowBookInfo
            // 
            txtOutputShowBookInfo.Enabled = false;
            txtOutputShowBookInfo.Location = new Point(20, 236);
            txtOutputShowBookInfo.Margin = new Padding(3, 4, 3, 4);
            txtOutputShowBookInfo.Multiline = true;
            txtOutputShowBookInfo.Name = "txtOutputShowBookInfo";
            txtOutputShowBookInfo.ReadOnly = true;
            txtOutputShowBookInfo.Size = new Size(344, 193);
            txtOutputShowBookInfo.TabIndex = 10;
            // 
            // lblMessageEmployerRegister
            // 
            lblMessageEmployerRegister.AutoSize = true;
            lblMessageEmployerRegister.Font = new Font("Arial", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMessageEmployerRegister.Location = new Point(14, 217);
            lblMessageEmployerRegister.Name = "lblMessageEmployerRegister";
            lblMessageEmployerRegister.Size = new Size(0, 15);
            lblMessageEmployerRegister.TabIndex = 11;
            // 
            // dUDSelectBook
            // 
            dUDSelectBook.BackColor = Color.White;
            dUDSelectBook.Location = new Point(24, 87);
            dUDSelectBook.Name = "dUDSelectBook";
            dUDSelectBook.Size = new Size(340, 27);
            dUDSelectBook.TabIndex = 12;
            dUDSelectBook.Text = "Selecione um Livro";
            // 
            // btnLendBook
            // 
            btnLendBook.Location = new Point(20, 134);
            btnLendBook.Name = "btnLendBook";
            btnLendBook.Size = new Size(159, 29);
            btnLendBook.TabIndex = 13;
            btnLendBook.Text = "Emprestar Livro";
            btnLendBook.UseVisualStyleBackColor = true;
            btnLendBook.Click += btnLendBook_Click;
            // 
            // btnReturnBook
            // 
            btnReturnBook.Location = new Point(205, 134);
            btnReturnBook.Name = "btnReturnBook";
            btnReturnBook.Size = new Size(159, 29);
            btnReturnBook.TabIndex = 14;
            btnReturnBook.Text = "Devolver Livro";
            btnReturnBook.UseVisualStyleBackColor = true;
            btnReturnBook.Click += btnReturnBook_Click;
            // 
            // btnFindBook
            // 
            btnFindBook.Location = new Point(20, 180);
            btnFindBook.Name = "btnFindBook";
            btnFindBook.Size = new Size(159, 29);
            btnFindBook.TabIndex = 15;
            btnFindBook.Text = "Consultar Livro";
            btnFindBook.UseVisualStyleBackColor = true;
            btnFindBook.Click += btnFindBook_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 600);
            Controls.Add(btnFindBook);
            Controls.Add(btnReturnBook);
            Controls.Add(btnLendBook);
            Controls.Add(dUDSelectBook);
            Controls.Add(lblMessageEmployerRegister);
            Controls.Add(txtOutputShowBookInfo);
            Controls.Add(lblTitleBooks);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitleBooks;
        private TextBox txtOutputShowBookInfo;
        private Label lblMessageEmployerRegister;
        private DomainUpDown dUDSelectBook;
        private Button btnLendBook;
        private Button btnReturnBook;
        private Button btnFindBook;
    }
}
