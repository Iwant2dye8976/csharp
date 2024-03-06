namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPass.Text.Length == 0 || txtUser.Text.Length == 0)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu trống");
            }
            else
            {
                if (chkNho.Checked)
                {
                    MessageBox.Show($"Tên đăng nhập: {txtUser.Text}\nMật khẩu: {txtPass.Text}\nBạn có ghi nhớ");
                }
                else
                {
                    MessageBox.Show($"Tên đăng nhập: {txtUser.Text}\nMật khẩu: {txtPass.Text}");
                }
            }

        }

        private void chkNho_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            txtPass.Clear();
            txtUser.Clear();
            chkNho.Checked = false;
            txtUser.Focus();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
