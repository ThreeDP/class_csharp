namespace calculator
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
            lblCalcView = new Label();
            panel1 = new Panel();
            btnResult = new Button();
            btnReset = new Button();
            btnZero = new Button();
            btnNine = new Button();
            btnSix = new Button();
            btnThree = new Button();
            btnEight = new Button();
            btnFive = new Button();
            btnTwo = new Button();
            btnPoint = new Button();
            btnSeven = new Button();
            btnFour = new Button();
            btnOne = new Button();
            btnDivide = new Button();
            btnMultiply = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblCalcView
            // 
            lblCalcView.BackColor = Color.FromArgb(224, 224, 224);
            lblCalcView.BorderStyle = BorderStyle.FixedSingle;
            lblCalcView.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCalcView.Location = new Point(49, 39);
            lblCalcView.Name = "lblCalcView";
            lblCalcView.Padding = new Padding(0, 13, 23, 0);
            lblCalcView.RightToLeft = RightToLeft.No;
            lblCalcView.Size = new Size(353, 119);
            lblCalcView.TabIndex = 0;
            lblCalcView.Text = "0\n";
            lblCalcView.TextAlign = ContentAlignment.TopRight;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnResult);
            panel1.Controls.Add(btnReset);
            panel1.Controls.Add(btnZero);
            panel1.Controls.Add(btnNine);
            panel1.Controls.Add(btnSix);
            panel1.Controls.Add(btnThree);
            panel1.Controls.Add(btnEight);
            panel1.Controls.Add(btnFive);
            panel1.Controls.Add(btnTwo);
            panel1.Controls.Add(btnPoint);
            panel1.Controls.Add(btnSeven);
            panel1.Controls.Add(btnFour);
            panel1.Controls.Add(btnOne);
            panel1.Controls.Add(btnDivide);
            panel1.Controls.Add(btnMultiply);
            panel1.Controls.Add(btnMinus);
            panel1.Controls.Add(btnPlus);
            panel1.Location = new Point(49, 163);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 495);
            panel1.TabIndex = 1;
            // 
            // btnResult
            // 
            btnResult.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResult.Location = new Point(256, 29);
            btnResult.Margin = new Padding(3, 4, 3, 4);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(69, 80);
            btnResult.TabIndex = 2;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = true;
            btnResult.Click += btnResult_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(177, 29);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(69, 80);
            btnReset.TabIndex = 1;
            btnReset.Text = "C";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnZero
            // 
            btnZero.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnZero.Location = new Point(256, 301);
            btnZero.Margin = new Padding(3, 4, 3, 4);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(69, 171);
            btnZero.TabIndex = 16;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnNumber_Click;
            // 
            // btnNine
            // 
            btnNine.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNine.Location = new Point(177, 392);
            btnNine.Margin = new Padding(3, 4, 3, 4);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(69, 80);
            btnNine.TabIndex = 15;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += btnNumber_Click;
            // 
            // btnSix
            // 
            btnSix.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSix.Location = new Point(98, 392);
            btnSix.Margin = new Padding(3, 4, 3, 4);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(69, 80);
            btnSix.TabIndex = 14;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += btnNumber_Click;
            // 
            // btnThree
            // 
            btnThree.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThree.Location = new Point(19, 392);
            btnThree.Margin = new Padding(3, 4, 3, 4);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(69, 80);
            btnThree.TabIndex = 13;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += btnNumber_Click;
            // 
            // btnEight
            // 
            btnEight.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEight.Location = new Point(177, 301);
            btnEight.Margin = new Padding(3, 4, 3, 4);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(69, 80);
            btnEight.TabIndex = 12;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += btnNumber_Click;
            // 
            // btnFive
            // 
            btnFive.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFive.Location = new Point(98, 301);
            btnFive.Margin = new Padding(3, 4, 3, 4);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(69, 80);
            btnFive.TabIndex = 11;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += btnNumber_Click;
            // 
            // btnTwo
            // 
            btnTwo.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTwo.Location = new Point(19, 301);
            btnTwo.Margin = new Padding(3, 4, 3, 4);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(69, 80);
            btnTwo.TabIndex = 10;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += btnNumber_Click;
            // 
            // btnPoint
            // 
            btnPoint.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPoint.Location = new Point(256, 211);
            btnPoint.Margin = new Padding(3, 4, 3, 4);
            btnPoint.Name = "btnPoint";
            btnPoint.Size = new Size(69, 80);
            btnPoint.TabIndex = 10;
            btnPoint.Text = ",";
            btnPoint.UseVisualStyleBackColor = true;
            btnPoint.Click += btnPoint_Click;
            // 
            // btnSeven
            // 
            btnSeven.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeven.Location = new Point(177, 211);
            btnSeven.Margin = new Padding(3, 4, 3, 4);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(69, 80);
            btnSeven.TabIndex = 9;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += btnNumber_Click;
            // 
            // btnFour
            // 
            btnFour.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFour.Location = new Point(98, 211);
            btnFour.Margin = new Padding(3, 4, 3, 4);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(69, 80);
            btnFour.TabIndex = 8;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += btnNumber_Click;
            // 
            // btnOne
            // 
            btnOne.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOne.Location = new Point(19, 211);
            btnOne.Margin = new Padding(3, 4, 3, 4);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(69, 80);
            btnOne.TabIndex = 7;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += btnNumber_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDivide.Location = new Point(256, 120);
            btnDivide.Margin = new Padding(3, 4, 3, 4);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(69, 80);
            btnDivide.TabIndex = 6;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnOperator_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMultiply.Location = new Point(177, 120);
            btnMultiply.Margin = new Padding(3, 4, 3, 4);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(69, 80);
            btnMultiply.TabIndex = 5;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnOperator_Click;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinus.Location = new Point(98, 120);
            btnMinus.Margin = new Padding(3, 4, 3, 4);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(69, 80);
            btnMinus.TabIndex = 4;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnOperator_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(19, 120);
            btnPlus.Margin = new Padding(3, 4, 3, 4);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(69, 80);
            btnPlus.TabIndex = 3;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnOperator_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 728);
            Controls.Add(panel1);
            Controls.Add(lblCalcView);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblCalcView;
        private Panel panel1;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnEight;
        private Button btnFive;
        private Button btnTwo;
        private Button btnPoint;
        private Button btnSeven;
        private Button btnFour;
        private Button btnOne;
        private Button btnDivide;
        private Button btnMultiply;
        private Button btnResult;
        private Button btnReset;
        private Button btnZero;
        private Button btnNine;
        private Button btnSix;
        private Button btnThree;
    }
}
