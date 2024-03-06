namespace Bai2
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
            lbl1 = new Label();
            lbl2 = new Label();
            txta = new TextBox();
            txtb = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(26, 26);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(27, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "a = ";
            lbl1.Click += label1_Click;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(26, 68);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(28, 15);
            lbl2.TabIndex = 1;
            lbl2.Text = "b = ";
            // 
            // txta
            // 
            txta.Location = new Point(81, 23);
            txta.Name = "txta";
            txta.Size = new Size(62, 23);
            txta.TabIndex = 2;
            txta.TextChanged += textBox1_TextChanged;
            // 
            // txtb
            // 
            txtb.Location = new Point(81, 60);
            txtb.Name = "txtb";
            txtb.Size = new Size(62, 23);
            txtb.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(185, 23);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Xóa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(185, 68);
            button2.Name = "button2";
            button2.Size = new Size(75, 56);
            button2.TabIndex = 5;
            button2.Text = "Dừng";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(68, 101);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "Hoán đổi";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 145);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtb);
            Controls.Add(txta);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Name = "Form1";
            Text = "Hoán đổi giá trị";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private TextBox txta;
        private TextBox txtb;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
