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
            lblCalcView.Location = new Point(43, 29);
            lblCalcView.Name = "lblCalcView";
            lblCalcView.Padding = new Padding(0, 10, 20, 0);
            lblCalcView.RightToLeft = RightToLeft.No;
            lblCalcView.Size = new Size(309, 90);
            lblCalcView.TabIndex = 0;
            lblCalcView.Text = "result\ncalc";
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
            panel1.Location = new Point(43, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 371);
            panel1.TabIndex = 1;
            // 
            // btnResult
            // 
            btnResult.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResult.Location = new Point(224, 22);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(60, 60);
            btnResult.TabIndex = 2;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(155, 22);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(60, 60);
            btnReset.TabIndex = 1;
            btnReset.Text = "C";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnZero
            // 
            btnZero.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnZero.Location = new Point(224, 226);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(60, 128);
            btnZero.TabIndex = 16;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnNine
            // 
            btnNine.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNine.Location = new Point(155, 294);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(60, 60);
            btnNine.TabIndex = 15;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            // 
            // btnSix
            // 
            btnSix.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSix.Location = new Point(86, 294);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(60, 60);
            btnSix.TabIndex = 14;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            // 
            // btnThree
            // 
            btnThree.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThree.Location = new Point(17, 294);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(60, 60);
            btnThree.TabIndex = 13;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            // 
            // btnEight
            // 
            btnEight.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEight.Location = new Point(155, 226);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(60, 60);
            btnEight.TabIndex = 12;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            // 
            // btnFive
            // 
            btnFive.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFive.Location = new Point(86, 226);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(60, 60);
            btnFive.TabIndex = 11;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            // 
            // btnTwo
            // 
            btnTwo.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTwo.Location = new Point(17, 226);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(60, 60);
            btnTwo.TabIndex = 11;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            // 
            // btnPoint
            // 
            btnPoint.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPoint.Location = new Point(224, 158);
            btnPoint.Name = "btnPoint";
            btnPoint.Size = new Size(60, 60);
            btnPoint.TabIndex = 10;
            btnPoint.Text = ".";
            btnPoint.UseVisualStyleBackColor = true;
            // 
            // btnSeven
            // 
            btnSeven.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeven.Location = new Point(155, 158);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(60, 60);
            btnSeven.TabIndex = 9;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            // 
            // btnFour
            // 
            btnFour.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFour.Location = new Point(86, 158);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(60, 60);
            btnFour.TabIndex = 8;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            // 
            // btnOne
            // 
            btnOne.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOne.Location = new Point(17, 158);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(60, 60);
            btnOne.TabIndex = 7;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDivide.Location = new Point(224, 90);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(60, 60);
            btnDivide.TabIndex = 6;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMultiply.Location = new Point(155, 90);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(60, 60);
            btnMultiply.TabIndex = 5;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinus.Location = new Point(86, 90);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(60, 60);
            btnMinus.TabIndex = 4;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Arial Unicode MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(17, 90);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(60, 60);
            btnPlus.TabIndex = 3;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 546);
            Controls.Add(panel1);
            Controls.Add(lblCalcView);
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
