using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QUANLYSV
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=38-209B5;Initial Catalog=SINHVIEN;Integrated Security=True";
        SqlDataAdapter da;
        DataTable dt;
        SqlConnection Conn = null;
        SqlCommand cmd;
        int index = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conn = new SqlConnection(connectionString);
            Conn.Open();
            string xuat = "Select * from SinhVien";
            da = new SqlDataAdapter(xuat,Conn);
            dt = new DataTable();
            da.Fill(dt);
            dgSV.DataSource = dt;
        }

        private void dgSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if(index >= 0)
            {
                tbMaSV.Text = dt.Rows[index][0].ToString();
                tbHoten.Text = dt.Rows[index][1].ToString();
                dtpNgaysinh.Text = dt.Rows[index][2].ToString();
                tbGioitinh.Text = dt.Rows[index][3].ToString();
                tbQuequan.Text = dt.Rows[index][4].ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string newMaSV = tbMaSV.Text.Trim();
            string newHoten = tbHoten.Text.Trim();
            DateTime newNgaysinh = dtpNgaysinh.Value;
            string newGioitinh = tbGioitinh.Text.Trim();
            string newQuequan = tbQuequan.Text.Trim();
            if (string.IsNullOrWhiteSpace(newMaSV) || string.IsNullOrWhiteSpace(newHoten) || string.IsNullOrWhiteSpace(newQuequan))
                MessageBox.Show("Phai nhap du thong tin");
            else
            {
                try
                {
                    string add = "INSERT INTO SinhVien (MaSV, HoTen, NgaySinh, Gioitinh, Quequan) VALUES (@MaSV, @HoTen, @NgaySinh, @Gioitinh, @Quequan)";
                    SqlCommand cmd = new SqlCommand(add, Conn);
                    cmd.Parameters.AddWithValue("@MaSV", newMaSV);
                    cmd.Parameters.AddWithValue("@HoTen", newHoten);
                    cmd.Parameters.AddWithValue("@NgaySinh", newNgaysinh);
                    cmd.Parameters.AddWithValue("@Gioitinh", newGioitinh);
                    cmd.Parameters.AddWithValue("@Quequan", newQuequan);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm sinh viên thành công");
                    dt.Rows.Clear();
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.ToString());
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(index >= 0)
            {
                string MaSV = dt.Rows[index][0].ToString();
                string newHoten = tbHoten.Text.Trim();
                DateTime newNgaysinh = dtpNgaysinh.Value;
                string newGioitinh = tbGioitinh.Text.Trim();
                string newQuequan = tbQuequan.Text.Trim();
                if (string.IsNullOrWhiteSpace(newHoten) || string.IsNullOrWhiteSpace(newQuequan))
                    MessageBox.Show("Phai nhap du thong tin");
                else
                {
                    try
                    {
                        string add = "UPDATE SinhVien SET HoTen = @Hoten, NgaySinh = @Ngaysinh, Gioitinh = @Gioitinh, Quequan = @Quequan WHERE MaSV ="+MaSV;
                        SqlCommand cmd = new SqlCommand(add, Conn);
                        cmd.Parameters.AddWithValue("@Hoten", newHoten);
                        cmd.Parameters.AddWithValue("@Ngaysinh", newNgaysinh);
                        cmd.Parameters.AddWithValue("@Gioitinh", newGioitinh);
                        cmd.Parameters.AddWithValue("@Quequan", newQuequan);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sửa sinh viên thành công");
                        dt.Rows.Clear();
                        da.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.ToString());
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                string MaSV = dt.Rows[index][0].ToString();
                try
                {
                    string delete = "DELETE SinhVien where MaSV =" + MaSV;
                    cmd = new SqlCommand(delete, Conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công");
                    dt.Rows.Clear();
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi:" + ex.ToString());
                }
            }
            else MessageBox.Show("Phải chọn một trường để xóa");
        }
    }
}
