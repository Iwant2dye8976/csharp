namespace PTTK_HT
{
    partial class F_DangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTaikhoan = new System.Windows.Forms.Label();
            this.lbMatkhau = new System.Windows.Forms.Label();
            this.tbTaiKhoan = new System.Windows.Forms.TextBox();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cbHienMK = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbTaikhoan
            // 
            this.lbTaikhoan.AutoSize = true;
            this.lbTaikhoan.Location = new System.Drawing.Point(37, 43);
            this.lbTaikhoan.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTaikhoan.Name = "lbTaikhoan";
            this.lbTaikhoan.Size = new System.Drawing.Size(92, 25);
            this.lbTaikhoan.TabIndex = 0;
            this.lbTaikhoan.Text = "Tài khoản";
            // 
            // lbMatkhau
            // 
            this.lbMatkhau.AutoSize = true;
            this.lbMatkhau.Location = new System.Drawing.Point(37, 102);
            this.lbMatkhau.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbMatkhau.Name = "lbMatkhau";
            this.lbMatkhau.Size = new System.Drawing.Size(91, 25);
            this.lbMatkhau.TabIndex = 1;
            this.lbMatkhau.Text = "Mật khẩu";
            // 
            // tbTaiKhoan
            // 
            this.tbTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTaiKhoan.Location = new System.Drawing.Point(138, 40);
            this.tbTaiKhoan.Name = "tbTaiKhoan";
            this.tbTaiKhoan.Size = new System.Drawing.Size(309, 33);
            this.tbTaiKhoan.TabIndex = 0;
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMatKhau.Location = new System.Drawing.Point(138, 100);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.Size = new System.Drawing.Size(309, 33);
            this.tbMatKhau.TabIndex = 1;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(93, 193);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(117, 39);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            this.btnDangNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnDangNhap_KeyPress);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(288, 193);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(117, 39);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            this.btnThoat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnThoat_KeyPress);
            // 
            // cbHienMK
            // 
            this.cbHienMK.AutoSize = true;
            this.cbHienMK.Location = new System.Drawing.Point(294, 139);
            this.cbHienMK.Name = "cbHienMK";
            this.cbHienMK.Size = new System.Drawing.Size(153, 29);
            this.cbHienMK.TabIndex = 2;
            this.cbHienMK.Text = "Hiện mật khẩu";
            this.cbHienMK.UseVisualStyleBackColor = true;
            this.cbHienMK.CheckedChanged += new System.EventHandler(this.cbHienMK_CheckedChanged);
            this.cbHienMK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbHienMK_KeyPress);
            // 
            // F_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 244);
            this.Controls.Add(this.cbHienMK);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.tbMatKhau);
            this.Controls.Add(this.tbTaiKhoan);
            this.Controls.Add(this.lbMatkhau);
            this.Controls.Add(this.lbTaikhoan);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "F_DangNhap";
            this.Text = "Quản lý cửa hàng sách";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTaikhoan;
        private System.Windows.Forms.Label lbMatkhau;
        private System.Windows.Forms.TextBox tbTaiKhoan;
        private System.Windows.Forms.TextBox tbMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.CheckBox cbHienMK;
    }
}

