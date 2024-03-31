using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace QLSACH_Sql
{
    public partial class Form1 : Form
    {
        private string connectionStr = @"Data Source = DESKTOP-NN2JUAV\SQLEXPRESS;Initial Catalog = QLSACH1;Integrated Security = True";
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dt;
        SqlDataAdapter da;
        int index = -1;
        string newTheLoai;
        string newMaS,newTenS,newTacGia,newNgonNgu;
        private void Load_Data()
        {
            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                conn.Open();
                string fill = @"SELECT * FROM sach";
                da = new SqlDataAdapter(fill, conn);
                dt = new DataTable();
                da.Fill(dt);
                dgSach.DataSource = dt;
            }
        }

        private void Update_TheLoai()
        {
            if (rbGiaoTrinh.Checked)
                newTheLoai = rbGiaoTrinh.Text.Trim();
            else
                if (rbTapChi.Checked)
                newTheLoai = rbTapChi.Text.Trim();
            else
                    if (rbSChuyenKhao.Checked)
                newTheLoai = rbSChuyenKhao.Text.Trim();
            else
                newTheLoai = rbSThamKhao.Text.Trim();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void Clear_()
        {
            tbMaS.Clear();
            tbTenS.Clear();
            tbTacGia.Clear();
            cbNgonNgu.SelectedIndex = 0;
            tbTimKiem.Clear();
            index = -1;
        }

        private void dgSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                tbMaS.Text = dt.Rows[index][0].ToString().Trim();
                tbTenS.Text = dt.Rows[index][1].ToString().Trim();
                tbTacGia.Text = dt.Rows[index][2].ToString().Trim();
                cbNgonNgu.Text = dt.Rows[index][3].ToString().Trim();
                Update_TheLoai();
                switch (newTheLoai)
                {
                    case "Tạp chí": rbTapChi.Checked = true; break;
                    case "Giáo trình": rbGiaoTrinh.Checked = true; break;
                    case "Sách tham khảo": rbSThamKhao.Checked = true; break;
                    case "Sách chuyên khảo": rbSChuyenKhao.Checked = true; break;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using(SqlConnection conn = new SqlConnection(connectionStr))
            {
                conn.Open();
                newMaS = tbMaS.Text.ToString();
                newTenS = tbTenS.Text.ToString();
                newTacGia = tbTacGia.Text.ToString();
                newNgonNgu = cbNgonNgu.SelectedItem.ToString();
                Update_TheLoai();
                if (string.IsNullOrWhiteSpace(newMaS) || string.IsNullOrWhiteSpace(newTenS) || string.IsNullOrWhiteSpace(newTacGia))
                    MessageBox.Show("Hãy điền đầy đủ thông tin");
                else
                {
                    string insert = "INSERT INTO sach (MaSach , TenSach, TacGia, NgonNgu, TheLoai) VALUES (@MaSach, @TenSach, @TacGia, @NgonNgu, @TheLoai)";
                    using(SqlCommand cmd = new SqlCommand(insert,conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSach", newMaS);
                        cmd.Parameters.AddWithValue("@TenSach", newTenS);
                        cmd.Parameters.AddWithValue("@TacGia", newTacGia);
                        cmd.Parameters.AddWithValue("@NgonNgu", newNgonNgu);
                        cmd.Parameters.AddWithValue("@TheLoai", newTheLoai);
                        cmd.ExecuteNonQuery();
                        Load_Data();
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear_();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(index >= 0)
            {
                newMaS = tbMaS.Text.ToString();
                newTenS = tbTenS.Text.ToString();
                newTacGia = tbTacGia.Text.ToString();
                newNgonNgu = cbNgonNgu.SelectedItem.ToString();
                Update_TheLoai();
                Update_TheLoai();
                if (string.IsNullOrWhiteSpace(newMaS) || string.IsNullOrWhiteSpace(newTenS) || string.IsNullOrWhiteSpace(newTacGia))
                    MessageBox.Show("Hãy điền đầy đủ thông tin");
                else
                {
                    using (SqlConnection conn = new SqlConnection(connectionStr))
                    {
                        conn.Open();
                        string update = "UPDATE sach SET TenSach = @TenSach, TacGia = @TacGia, NgonNgu = @NgonNgu, TheLoai = @TheLoai WHERE MaSach = @MaSach";
                        using (SqlCommand cmd = new SqlCommand(update, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaSach", newMaS);
                            cmd.Parameters.AddWithValue("@TenSach", newTenS);
                            cmd.Parameters.AddWithValue("@TacGia", newTacGia);
                            cmd.Parameters.AddWithValue("@NgonNgu", newNgonNgu);
                            cmd.Parameters.AddWithValue("@TheLoai", newTheLoai);
                            cmd.ExecuteNonQuery();
                        }
                        Load_Data();
                    }
                        
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(index >= 0)
            {
                using(SqlConnection conn = new SqlConnection(connectionStr))
                {
                    conn.Open();
                }
            }
        }
    }
}
