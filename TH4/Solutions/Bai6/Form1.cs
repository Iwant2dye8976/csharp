using System.Numerics;

namespace Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum KieuNghiem
        {
            HaiNghiemPhanBiet,
            NghiemKep,
            VoNghiem
        }

        static string KieuNghiemPT(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta >= 0)
            {
                if (delta == 0)
                    return KieuNghiem.NghiemKep.ToString();
                else
                    return KieuNghiem.HaiNghiemPhanBiet.ToString();
            }
            else
                return KieuNghiem.VoNghiem.ToString();
        }
        private void btnGiai_Click(object sender, EventArgs e)
        {
            try
            {
                lblNghiem.Text = "Nghiệm của phương trình: ";
                double a = Convert.ToDouble(txtBa.Text);
                double b = Convert.ToDouble(txtBb.Text);
                double c = Convert.ToDouble(txtBc.Text);
                string Type = KieuNghiemPT(a, b, c);

                if (Type != "VoNghiem" && a != 0)
                {
                    double x1 = 0;
                    double x2 = 0;
                    double delta = Math.Pow(b, 2) - 4 * a * c;
                    if (Type == "HaiNghiemPhanBiet")
                    {
                        x1 = -b + Math.Sqrt(delta) / (2 * a);
                        x2 = -b - Math.Sqrt(delta) / (2 * a);
                        lblNghiem.Text += $"x1 = {x1}; x2 = {x2}";
                    }
                    else
                    {
                        x1 = x2 = -b / (2 * a);
                        lblNghiem.Text += $"x1 = x2 = {x1}";
                    }
                }
                else
                {
                    lblNghiem.Text += "Vô nghiệm";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi: Nhập không đúng định dạng số");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtBa.Clear();
            txtBb.Clear();
            txtBc.Clear();
            txtBa.Focus();
        }
        private Control clickedControl;
        private void txtBa_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                clickedControl = (Control)sender;
                ctxtMenuEdit.Show((Control)sender, e.Location);
            }
        }

        public void ctxtMenuEdit_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }

        private void tsmDoiMau_Click(object sender, EventArgs e)
        {
            if(clickedControl != null)
            {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    clickedControl.BackColor = colorDialog.Color;
                }
            }
        }

        private void tsmDoiFont_Click(object sender, EventArgs e)
        {
            if(clickedControl != null)
            {
                FontDialog fontDialog = new FontDialog();
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    clickedControl.Font = fontDialog.Font;
                }
            }
        }
    }
}
