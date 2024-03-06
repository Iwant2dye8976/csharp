namespace Bai1
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
            lbUsername = new Label();
            lbPass = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            chkNho = new CheckBox();
            btnLogin = new Button();
            btnErase = new Button();
            btnStop = new Button();
            SuspendLayout();
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(32, 26);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(85, 15);
            lbUsername.TabIndex = 0;
            lbUsername.Text = "Tên đăng nhập";
            lbUsername.Click += label1_Click;
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Location = new Point(32, 71);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(57, 15);
            lbPass.TabIndex = 1;
            lbPass.Text = "Mật khẩu";
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.Wheat;
            txtUser.Location = new Point(133, 23);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(224, 23);
            txtUser.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.AntiqueWhite;
            txtPass.Location = new Point(133, 63);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(224, 23);
            txtPass.TabIndex = 3;
            // 
            // chkNho
            // 
            chkNho.AutoSize = true;
            chkNho.Location = new Point(32, 102);
            chkNho.Name = "chkNho";
            chkNho.Size = new Size(68, 19);
            chkNho.TabIndex = 4;
            chkNho.Text = "Ghi nhớ";
            chkNho.UseVisualStyleBackColor = true;
            chkNho.CheckedChanged += chkNho_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(32, 142);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(92, 32);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnErase
            // 
            btnErase.Location = new Point(148, 142);
            btnErase.Name = "btnErase";
            btnErase.Size = new Size(92, 32);
            btnErase.TabIndex = 6;
            btnErase.Text = "Xóa";
            btnErase.UseVisualStyleBackColor = true;
            btnErase.Click += btnErase_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(264, 142);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(92, 32);
            btnStop.TabIndex = 7;
            btnStop.Text = "Dừng";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 207);
            Controls.Add(btnStop);
            Controls.Add(btnErase);
            Controls.Add(btnLogin);
            Controls.Add(chkNho);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(lbPass);
            Controls.Add(lbUsername);
            Name = "Form1";
            Text = "Form Đăng Nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUsername;
        private Label lbPass;
        private TextBox txtUser;
        private TextBox txtPass;
        private CheckBox chkNho;
        private Button btnLogin;
        private Button btnErase;
        private Button btnStop;
    }
}
