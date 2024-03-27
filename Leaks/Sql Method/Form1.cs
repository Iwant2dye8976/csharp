using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Data Source=DESKTOP-NN2JUAV\SQLEXPRESS;Initial Catalog=TTSINHVIEN;Integrated Security=True";
        private DataTable dt;
        private SqlDataAdapter da;
        private int index = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string selectQuery = "SELECT * FROM SinhVien";
                da = new SqlDataAdapter(selectQuery, conn);
                dt = new DataTable();
                da.Fill(dt);
                dgSinhVien.DataSource = dt;
            }
        }

        private void Clear()
        {
            tbMaSV.Clear();
            tbDiaChi.Clear();
            tbDiaChi.Clear();
            tbTenSV.Clear();
            tbTimKiem.Clear();
            index = -1;
        }

        private void dgSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                tbMaSV.Text = dt.Rows[index][0].ToString().Trim();
                tbTenSV.Text = dt.Rows[index][1].ToString().Trim();
                dtpNgaySinh.Value = Convert.ToDateTime(dt.Rows[index][2]);
                tbDiaChi.Text = dt.Rows[index][3].ToString().Trim();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string newMaSV = tbMaSV.Text.Trim();
                string newTenSV = tbTenSV.Text.Trim();
                DateTime newNgaySinh = dtpNgaySinh.Value;
                string newDiaChi = tbDiaChi.Text.Trim();
                if (string.IsNullOrWhiteSpace(newMaSV) || string.IsNullOrWhiteSpace(newTenSV) || string.IsNullOrWhiteSpace(newDiaChi))
                {
                    MessageBox.Show("Hãy nhập đầy đủ thông tin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        string insertQuery = "INSERT INTO SinhVien (MaSV, TenSV, NgaySinh, DiaChi) VALUES (@MaSV, @TenSV, @NgaySinh, @DiaChi)";
                        using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaSV", newMaSV);
                            cmd.Parameters.AddWithValue("@TenSV", newTenSV);
                            cmd.Parameters.AddWithValue("@NgaySinh", newNgaySinh);
                            cmd.Parameters.AddWithValue("@DiaChi", newDiaChi);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Thêm thành công", "Done", MessageBoxButtons.OK, MessageBoxIcon.None);
                        Clear();
                        LoadData(); // Refresh DataGridView
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                if (index >= 0)
                {
                    try
                    {
                        string MaSV = tbMaSV.Text.Trim();
                        string newTenSV = tbTenSV.Text.Trim();
                        DateTime newNgaySinh = dtpNgaySinh.Value;
                        string newDiaChi = tbDiaChi.Text.Trim();
                        if (string.IsNullOrWhiteSpace(newTenSV) || string.IsNullOrWhiteSpace(newDiaChi))
                        {
                            MessageBox.Show("Hãy nhập đầy đủ thông tin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            string updateQuery = "UPDATE SinhVien SET TenSV = @TenSV, NgaySinh = @NgaySinh, DiaChi = @DiaChi WHERE MaSV = @MaSV";
                            using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@TenSV", newTenSV);
                                cmd.Parameters.AddWithValue("@NgaySinh", newNgaySinh);
                                cmd.Parameters.AddWithValue("@DiaChi", newDiaChi);
                                cmd.Parameters.AddWithValue("@MaSV", MaSV);
                                cmd.ExecuteNonQuery();
                            }
                            MessageBox.Show("Cập nhật thành công", "Done", MessageBoxButtons.OK, MessageBoxIcon.None);
                            Clear();
                            LoadData(); // Refresh DataGridView
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn một trường để sửa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                if (index >= 0)
                {
                    try
                    {
                        string MaSV = tbMaSV.Text.Trim();
                        string updateQuery = "Delete SinhVien WHERE MaSV = @MaSV";
                        using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaSV", MaSV);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Xóa thành công", "Done", MessageBoxButtons.OK, MessageBoxIcon.None);
                        Clear();
                        LoadData(); // Refresh DataGridView
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn một trường để sửa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {
            string HoTen = tbTimKiem.Text.ToString();
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string find = $"Select * from SinhVien where TenSV Like N'%{HoTen}%'";
                using(SqlDataAdapter da1 = new SqlDataAdapter(find,conn))
                {
                    dt = new DataTable();
                    da1.Fill(dt);
                    dgSinhVien.DataSource = dt;
                }
            }
        }
    }
}
