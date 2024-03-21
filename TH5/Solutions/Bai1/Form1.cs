using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=DESKTOP-NN2JUAV\SQLEXPRESS;Initial Catalog=QLSACH;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        //LoaiSach
        SqlDataAdapter daLoaiSach;
        DataTable dtLoaiSach;
        //NXB
        SqlDataAdapter daNXB;
        DataTable dtNXB;
        //Tacgia
        SqlDataAdapter daTacgia;
        DataTable dtTacgia;
        //Sach
        SqlDataAdapter daSach;
        DataTable dtSach;
        int index = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
            //Đổ dữ liệu vào bảng loại sách
            string ttLoaiSach = "Select * from LoaiSach";
            daLoaiSach = new SqlDataAdapter(ttLoaiSach,conn);
            dtLoaiSach = new DataTable();
            daLoaiSach.Fill(dtLoaiSach);
            dgLoaiSach.DataSource = dtLoaiSach;
            //Đổ dữ liệu vào bảng NXB
            string ttNXB = "Select * from NXB";
            daNXB = new SqlDataAdapter(ttNXB, conn);
            dtNXB = new DataTable();
            daNXB.Fill(dtNXB);
            dgNXB.DataSource = dtNXB;
            //Đổ dữ liệu vào bảng Tác giả
            string ttTacgia = "Select * from Tacgia";
            daTacgia = new SqlDataAdapter(ttTacgia, conn);
            dtTacgia = new DataTable();
            daTacgia.Fill(dtTacgia);
            dgTacgia.DataSource = dtTacgia;
            // Đổ dữ liệu vào bảng Sách
            string ttSach = "Select * from Sach";
            daSach = new SqlDataAdapter(ttSach, conn);
            dtSach = new DataTable();
            daSach.Fill(dtSach);
            dgSach.DataSource = dtSach;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNXB = tbMaNXB.Text.ToString();
            string tenNXB = tbTenNXB.Text.ToString();
            if (string.Empty == maNXB || string.Empty == tenNXB)
                MessageBox.Show("Bạn phải nhập đủ thông tin của NXB");
            else
            {
                try
                {
                    string add = $"Insert into NXB values({maNXB},N'{tenNXB}')";
                    cmd = new SqlCommand(add, conn);
                    cmd.ExecuteNonQuery();
                    dtNXB.Rows.Clear();
                    daNXB.Fill(dtNXB);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Nhà xuất bản đã có trong danh sách");
                }

            }
        }
        private void dgNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if(index >= 0)
            {
                tbMaNXB.Text = dtNXB.Rows[index][0].ToString();
                tbTenNXB.Text = dtNXB.Rows[index][1].ToString();
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                string MaNXB = dtNXB.Rows[index][0].ToString();
                string newTenNXB = tbTenNXB.Text;
                if (string.Empty != newTenNXB)
                {
                    string update = $"Update NXB set TenNXB = N'{newTenNXB}' where MaNXB = '{MaNXB}'";
                    cmd = new SqlCommand(update, conn);
                    cmd.ExecuteNonQuery();
                    dtNXB.Rows.Clear();
                    daNXB.Fill(dtNXB);
                }
                else MessageBox.Show("Không được để trống tên NXB");
            }
            else
                MessageBox.Show("Bạn phải chọn một hàng để sửa");
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                try
                {
                    string MaNXB = dtNXB.Rows[index][0].ToString();
                    string delete = $"Delete NXB where MaNXB = '{MaNXB}'";
                    cmd = new SqlCommand(delete, conn);
                    cmd.ExecuteNonQuery();
                    dtNXB.Rows.Clear();
                    daNXB.Fill(dtNXB);
                    index = -1;
                    tbMaNXB.Clear();
                    tbTenNXB.Clear();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Lỗi");
                }
            }
            else
                MessageBox.Show("Bạn phải chọn một hàng để xóa");

        }
        private void dgLoaiSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if(index >= 0)
            {
                tbMaLoaisach.Text = dtLoaiSach.Rows[index][0].ToString();
                tbTenLoaisach.Text = dtLoaiSach.Rows[index][1].ToString();
            }
        }
        private void btThemLoaisach_Click(object sender, EventArgs e)
        {
            try
            {
                string newMaLoai = tbMaLoaisach.Text.ToString();
                string newTenLoai = tbTenLoaisach.Text.ToString();
                string them = $"Insert into LOAISACH values({newMaLoai},N'{newTenLoai}')";
                cmd = new SqlCommand(them, conn);
                cmd.ExecuteNonQuery();
                dtLoaiSach.Rows.Clear();
                daLoaiSach.Fill(dtLoaiSach);
            }
            catch (SqlException)
            {
                MessageBox.Show("Mã sách đã tồn tại");
            }
        }
        private void btSuaLoaisach_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                string MaLoai = dtLoaiSach.Rows[index][0].ToString();
                string newTenLoai = tbTenLoaisach.Text.ToString();
                if (string.Empty != newTenLoai)
                {
                    string update = $"Update LOAISACH set TenLoai = N'{newTenLoai}' where MaLoai = '{MaLoai}'";
                    cmd = new SqlCommand(update, conn);
                    cmd.ExecuteNonQuery();
                    dtLoaiSach.Rows.Clear();
                    daLoaiSach.Fill(dtLoaiSach);
                }
                else MessageBox.Show("Không được để trống tên loại");
            }
            else MessageBox.Show("Bạn phải chọn một hàng để sửa");
        }
        private void btXoaLoaisach_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                try
                {
                    string MaLoai = dtLoaiSach.Rows[index][0].ToString();
                    string delete = $"Delete LOAISACH where MaLoai = '{MaLoai}'";
                    cmd = new SqlCommand(delete, conn);
                    cmd.ExecuteNonQuery();
                    dtLoaiSach.Rows.Clear();
                    daLoaiSach.Fill(dtLoaiSach);
                    index = -1;
                    tbMaLoaisach.Clear();
                    tbTenLoaisach.Clear();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Lỗi");
                }
            }
            else MessageBox.Show("Bạn phải chọn một hàng để xóa");
        }

        private void dgTacgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if(index >= 0)
            {
                tbMaTacgia.Text = dtTacgia.Rows[index][0].ToString();
                tbTenTacgia.Text = dtTacgia.Rows[index][1].ToString();
            }
        }
        private void btnThemTacgia_Click(object sender, EventArgs e)
        {
            try
            {
                string newMaTacgia = tbMaTacgia.Text.ToString();
                string newTenTacgia = tbTenTacgia.Text.ToString();
                if(string.Empty == newTenTacgia || string.Empty == newMaTacgia)
                {
                    MessageBox.Show("Bạn phải nhập đủ thông tin");
                }
                else
                {
                    string them = $"Insert into Tacgia values({newMaTacgia},N'{newTenTacgia}')";
                    cmd = new SqlCommand(them, conn);
                    cmd.ExecuteNonQuery();
                    dtTacgia.Rows.Clear();
                    daTacgia.Fill(dtTacgia);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Mã tác giả đã tồn tại");
            }
        }
        private void btnSuatacgia_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                string MaTacgia = dtTacgia.Rows[index][0].ToString();
                string newTenTacgia = tbTenTacgia.Text.ToString();
                if (string.Empty != newTenTacgia)
                {
                    string update = $"Update Tacgia set TenTG = N'{newTenTacgia}' where MaTG = '{MaTacgia}'";
                    cmd = new SqlCommand(update, conn);
                    cmd.ExecuteNonQuery();
                    dtTacgia.Rows.Clear();
                    daTacgia.Fill(dtTacgia);
                }
                else MessageBox.Show("Không được để trống tên tác giả");
            }
            else MessageBox.Show("Bạn phải chọn một hàng để sửa");
        }

        private void btnXoaTacgia_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                try
                {
                    string MaTacgia = dtTacgia.Rows[index][0].ToString();
                    string delete = $"Delete Tacgia where MaTG = '{MaTacgia}'";
                    cmd = new SqlCommand(delete, conn);
                    cmd.ExecuteNonQuery();
                    dtTacgia.Rows.Clear();
                    daTacgia.Fill(dtTacgia);
                    index = -1;
                    tbMaTacgia.Clear();
                    tbTenTacgia.Clear();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi"+ex.ToString());
                }
            }
            else MessageBox.Show("Bạn phải chọn một hàng để xóa");
        }

        private void dgSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if(index >= 0)
            {
                tbMaSach.Text = dtSach.Rows[index][0].ToString();
                tbMaloai1.Text = dtSach.Rows[index][1].ToString();
                tbMatacgia1.Text = dtSach.Rows[index][2].ToString();
                tbMaNXB1.Text = dtSach.Rows[index][3].ToString();
                tbTensach.Text = dtSach.Rows[index][4].ToString();
                tbDongia.Text = dtSach.Rows[index][5].ToString();
                tbSoluong.Text = dtSach.Rows[index][6].ToString();
            }
        }

        private void btnThemsach_Click(object sender, EventArgs e)
        {
            try
            {
                string newMaSach = tbMaSach.Text.Trim();
                string newMaLoai = tbMaloai1.Text.Trim();
                string newMatacgia = tbMatacgia1.Text.Trim();
                string newMaNXB = tbMaNXB1.Text.Trim();
                string newTensach = tbTensach.Text.Trim();
                int newDongia, newSoluong;

                if (string.IsNullOrEmpty(newMaSach) || string.IsNullOrEmpty(newMaLoai) ||
                string.IsNullOrEmpty(newMatacgia) || string.IsNullOrEmpty(newMaNXB) ||
                string.IsNullOrEmpty(newTensach) || !int.TryParse(tbDongia.Text.Trim(), out newDongia) ||
            !   int.TryParse(tbSoluong.Text.Trim(), out newSoluong) || newDongia <= 0 || newSoluong <= 0)
                {
                    MessageBox.Show("Hãy nhập đủ thông tin sách và đảm bảo giá và số lượng là số nguyên dương.");
                }
                else
                {
                    string add = $"Insert into SACH values({newMaSach},{newMaLoai},{newMatacgia},{newMaNXB},N'{newTensach}',{newDongia},{newSoluong})";
                    cmd = new SqlCommand(add, conn);
                    cmd.ExecuteNonQuery();
                    dtSach.Rows.Clear();
                    daSach.Fill(dtSach);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnXoasach_Click(object sender, EventArgs e)
        {

        }

        private void btnSuasach_Click(object sender, EventArgs e)
        {

        }
    }
}
