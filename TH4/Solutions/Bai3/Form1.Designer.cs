namespace Bai3
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
            lblNum = new Label();
            txtNum = new TextBox();
            btnShow = new Button();
            lblPrime = new Label();
            lblCP = new Label();
            lblPerfectnum = new Label();
            SuspendLayout();
            // 
            // lblNum
            // 
            lblNum.AutoSize = true;
            lblNum.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNum.ForeColor = Color.Red;
            lblNum.Location = new Point(24, 35);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(115, 30);
            lblNum.TabIndex = 0;
            lblNum.Text = "Nhập số n ";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(171, 44);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(309, 23);
            txtNum.TabIndex = 1;
            txtNum.TextChanged += txtNum_TextChanged;
            txtNum.Leave += txtNum_Leave;
            // 
            // btnShow
            // 
            btnShow.BackColor = SystemColors.ActiveBorder;
            btnShow.Location = new Point(550, 31);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(90, 46);
            btnShow.TabIndex = 2;
            btnShow.Text = "Hiển thị";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // lblPrime
            // 
            lblPrime.AutoSize = true;
            lblPrime.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPrime.ForeColor = Color.DarkRed;
            lblPrime.Location = new Point(24, 124);
            lblPrime.Name = "lblPrime";
            lblPrime.Size = new Size(226, 21);
            lblPrime.TabIndex = 3;
            lblPrime.Text = "Các số nguyên tố nhỏ hơn n:";
            // 
            // lblCP
            // 
            lblCP.AutoSize = true;
            lblCP.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCP.ForeColor = Color.DarkRed;
            lblCP.Location = new Point(24, 167);
            lblCP.Name = "lblCP";
            lblCP.Size = new Size(256, 21);
            lblCP.TabIndex = 4;
            lblCP.Text = "Các số chính phương nhỏ hơn n:";
            // 
            // lblPerfectnum
            // 
            lblPerfectnum.AutoSize = true;
            lblPerfectnum.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPerfectnum.ForeColor = Color.DarkRed;
            lblPerfectnum.Location = new Point(24, 210);
            lblPerfectnum.Name = "lblPerfectnum";
            lblPerfectnum.Size = new Size(234, 21);
            lblPerfectnum.TabIndex = 5;
            lblPerfectnum.Text = "Các số hoàn chỉnh nhỏ hơn n:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 270);
            Controls.Add(lblPerfectnum);
            Controls.Add(lblCP);
            Controls.Add(lblPrime);
            Controls.Add(btnShow);
            Controls.Add(txtNum);
            Controls.Add(lblNum);
            Name = "Form1";
            Text = "Chương trình nhập số";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNum;
        private TextBox txtNum;
        private Button btnShow;
        private Label lblPrime;
        private Label lblCP;
        private Label lblPerfectnum;
    }
}
