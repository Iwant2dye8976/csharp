namespace Bai7
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
            txtbTemp = new TextBox();
            txtbOutput = new TextBox();
            btn0 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnSubtract = new Button();
            btnAdd = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btnClear = new Button();
            btnEqual = new Button();
            btnDivision = new Button();
            btnMultiply = new Button();
            SuspendLayout();
            // 
            // txtbTemp
            // 
            txtbTemp.BorderStyle = BorderStyle.FixedSingle;
            txtbTemp.Enabled = false;
            txtbTemp.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtbTemp.Location = new Point(1, 2);
            txtbTemp.Multiline = true;
            txtbTemp.Name = "txtbTemp";
            txtbTemp.ReadOnly = true;
            txtbTemp.RightToLeft = RightToLeft.No;
            txtbTemp.Size = new Size(325, 69);
            txtbTemp.TabIndex = 0;
            txtbTemp.WordWrap = false;
            // 
            // txtbOutput
            // 
            txtbOutput.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtbOutput.BorderStyle = BorderStyle.FixedSingle;
            txtbOutput.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtbOutput.Location = new Point(1, 71);
            txtbOutput.Multiline = true;
            txtbOutput.Name = "txtbOutput";
            txtbOutput.ReadOnly = true;
            txtbOutput.RightToLeft = RightToLeft.No;
            txtbOutput.Size = new Size(325, 69);
            txtbOutput.TabIndex = 1;
            txtbOutput.TextAlign = HorizontalAlignment.Right;
            // 
            // btn0
            // 
            btn0.AccessibleRole = AccessibleRole.None;
            btn0.BackColor = Color.LightGray;
            btn0.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.Location = new Point(88, 377);
            btn0.Name = "btn0";
            btn0.Size = new Size(70, 70);
            btn0.TabIndex = 2;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.LightGray;
            btn1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold);
            btn1.Location = new Point(12, 145);
            btn1.Name = "btn1";
            btn1.Size = new Size(70, 70);
            btn1.TabIndex = 3;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.LightGray;
            btn2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold);
            btn2.Location = new Point(88, 145);
            btn2.Name = "btn2";
            btn2.Size = new Size(70, 70);
            btn2.TabIndex = 4;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.LightGray;
            btn3.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold);
            btn3.Location = new Point(164, 145);
            btn3.Name = "btn3";
            btn3.Size = new Size(70, 70);
            btn3.TabIndex = 5;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.LightGray;
            btn7.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold);
            btn7.Location = new Point(12, 301);
            btn7.Name = "btn7";
            btn7.Size = new Size(70, 70);
            btn7.TabIndex = 9;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.LightGray;
            btn6.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold);
            btn6.Location = new Point(164, 222);
            btn6.Name = "btn6";
            btn6.Size = new Size(70, 70);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.LightGray;
            btn5.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold);
            btn5.Location = new Point(88, 222);
            btn5.Name = "btn5";
            btn5.Size = new Size(70, 70);
            btn5.TabIndex = 7;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.LightGray;
            btn4.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold);
            btn4.Location = new Point(12, 222);
            btn4.Name = "btn4";
            btn4.Size = new Size(70, 70);
            btn4.TabIndex = 6;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.BackColor = Color.LightGray;
            btnSubtract.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold);
            btnSubtract.Location = new Point(240, 222);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(70, 70);
            btnSubtract.TabIndex = 13;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = false;
            btnSubtract.Click += operator_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightGray;
            btnAdd.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold);
            btnAdd.Location = new Point(240, 145);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(70, 70);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += operator_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.LightGray;
            btn9.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold);
            btn9.Location = new Point(164, 301);
            btn9.Name = "btn9";
            btn9.Size = new Size(70, 70);
            btn9.TabIndex = 11;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.LightGray;
            btn8.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold);
            btn8.Location = new Point(88, 301);
            btn8.Name = "btn8";
            btn8.Size = new Size(70, 70);
            btn8.TabIndex = 10;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightGray;
            btnClear.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold);
            btnClear.Location = new Point(12, 377);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(70, 70);
            btnClear.TabIndex = 17;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.LightGray;
            btnEqual.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold);
            btnEqual.Location = new Point(164, 377);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(70, 70);
            btnEqual.TabIndex = 16;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnDivision
            // 
            btnDivision.BackColor = Color.LightGray;
            btnDivision.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold);
            btnDivision.Location = new Point(240, 377);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(70, 70);
            btnDivision.TabIndex = 15;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = false;
            btnDivision.Click += operator_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.LightGray;
            btnMultiply.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold);
            btnMultiply.Location = new Point(240, 301);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(70, 70);
            btnMultiply.TabIndex = 14;
            btnMultiply.Text = "x";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += operator_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(328, 458);
            Controls.Add(btnClear);
            Controls.Add(btnEqual);
            Controls.Add(btnDivision);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn0);
            Controls.Add(txtbOutput);
            Controls.Add(txtbTemp);
            MaximizeBox = false;
            Name = "Form1";
            Text = "MyCalculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbTemp;
        private TextBox txtbOutput;
        private Button btn0;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnSubtract;
        private Button btnAdd;
        private Button btnDivision;
        private Button btnClear;
        private Button btnEqual;
        private Button btnMultiply;
    }
}
