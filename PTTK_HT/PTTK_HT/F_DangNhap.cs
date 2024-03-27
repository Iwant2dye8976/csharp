using PTTK_HT.Check;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTK_HT
{

    public partial class F_DangNhap : Form
    {
        check Check = new check(); 
        public F_DangNhap()
        {
            
            InitializeComponent();
            tbMatKhau.UseSystemPasswordChar = true;
        }
        Form QLCH_Sach;

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if( string.IsNullOrWhiteSpace(tbTaiKhoan.Text.Trim()) || string.IsNullOrWhiteSpace(tbMatKhau.Text.Trim()) )
            {
                MessageBox.Show("Không được bỏ trống Tài khoản hoặc mật khẩu","Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Check.IsValid(tbTaiKhoan.Text.Trim(), tbMatKhau.Text.Trim()))
                {
                    MessageBox.Show("Dang nhap thanh cong");
                    QLCH_Sach = new F_QuanLyCuaHangSach();
                    QLCH_Sach.FormClosed += QLCH_Sach_FormClosed;
                    this.Hide();
                    QLCH_Sach.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Đăng nhập không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void QLCH_Sach_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        
        private void cbHienMK_CheckedChanged(object sender, EventArgs e)
        {
           tbMatKhau.UseSystemPasswordChar = !cbHienMK.Checked;
        }

        private void btnDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
        }

        private void cbHienMK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cbHienMK.Checked = !cbHienMK.Checked;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.Close();
            }
        }
    }
}
