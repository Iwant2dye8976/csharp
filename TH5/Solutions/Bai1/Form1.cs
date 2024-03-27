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
        //Chuỗi kết nối CSDL
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
        //Ban Hang
        SqlDataAdapter daBanHang;
        DataTable dtBanHang;
        //Chỉ mục khi chọn vào datagrid view
        int index = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectionString);
            try
            {

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
            //Đổ dữ liệu vào bảng Bán Hàng
            string ttBanHang = "select HD.MaHD,HD.TenKhach,HD.SDT,ChitietHD.MaSach,ChitietHD.Soluong,ChitietHD.Giaban,HD.Tongtien from HD inner join ChitietHD on HD.MaHD = ChitietHD.MaHD";
            daBanHang = new SqlDataAdapter(ttBanHang, conn);
            dtBanHang = new DataTable();
            daBanHang.Fill(dtBanHang);
            dgBanHang.DataSource = dtBanHang;
            }
            finally
            {
                conn.Dispose();
            }
        }

        //Bắt sự kiện cho Tab control NXB
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
                    MessageBox.Show("Thêm thành công");
                    dtNXB.Rows.Clear();
                    daNXB.Fill(dtNXB);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: "+ex.ToString());
                }
            }
        }
        private void dgNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if(index >= 0)
            {
                tbMaNXB.Text = dtNXB.Rows[index][0].ToString().Trim();
                tbTenNXB.Text = dtNXB.Rows[index][1].ToString().Trim();
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
                    MessageBox.Show("Sửa thành công");
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
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: "+ex.ToString());
                }
            }
            else
                MessageBox.Show("Bạn phải chọn một hàng để xóa");

        }
        //Bắt sự kiện cho Tab control Loại Sách
        private void dgLoaiSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if(index >= 0)
            {
                tbMaLoaisach.Text = dtLoaiSach.Rows[index][0].ToString().Trim();
                tbTenLoaisach.Text = dtLoaiSach.Rows[index][1].ToString().Trim();
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
                MessageBox.Show("Thêm thành công");
                dtLoaiSach.Rows.Clear();
                daLoaiSach.Fill(dtLoaiSach);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: "+ex.ToString());
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
                    MessageBox.Show("Sửa thành công");
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
                    MessageBox.Show("Xóa thành công");
                    dtLoaiSach.Rows.Clear();
                    daLoaiSach.Fill(dtLoaiSach);
                    index = -1;
                    tbMaLoaisach.Clear();
                    tbTenLoaisach.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: "+ex.ToString());
                }
            }
            else MessageBox.Show("Bạn phải chọn một hàng để xóa");
        }

        //Bắt sự kiện cho Tab control Tác giả
        private void dgTacgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if(index >= 0)
            {
                tbMaTacgia.Text = dtTacgia.Rows[index][0].ToString().Trim();
                tbTenTacgia.Text = dtTacgia.Rows[index][1].ToString().Trim();
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
                    MessageBox.Show("Thêm thành công");
                    dtTacgia.Rows.Clear();
                    daTacgia.Fill(dtTacgia);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: "+ex.ToString());
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
                    MessageBox.Show("Sửa thành công");
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
                    MessageBox.Show("Xóa thành công");
                    dtTacgia.Rows.Clear();
                    daTacgia.Fill(dtTacgia);
                    index = -1;
                    tbMaTacgia.Clear();
                    tbTenTacgia.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi"+ex.ToString());
                }
            }
            else MessageBox.Show("Bạn phải chọn một hàng để xóa");
        }

        //Bắt sự kiện cho Tab control Sách
        private void dgSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if(index >= 0)
            {
                tbMaSach.Text = dtSach.Rows[index][0].ToString().Trim();
                tbMaloai1.Text = dtSach.Rows[index][1].ToString().Trim();
                tbMatacgia1.Text = dtSach.Rows[index][2].ToString().Trim();
                tbMaNXB1.Text = dtSach.Rows[index][3].ToString().Trim();
                tbTensach.Text = dtSach.Rows[index][4].ToString().Trim();
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
                int newDongia = int.Parse(tbDongia.Text);
                int newSoluong = int.Parse(tbSoluong.Text);

                if (string.IsNullOrEmpty(newMaSach) || string.IsNullOrEmpty(newMaLoai) ||
                string.IsNullOrEmpty(newMatacgia) || string.IsNullOrEmpty(newMaNXB) ||
                string.IsNullOrEmpty(newTensach) || newDongia <= 0 || newSoluong <= 0)
                {
                    MessageBox.Show("Hãy nhập đủ thông tin sách và đảm bảo giá và số lượng là số nguyên dương.");
                }
                else
                {
                    string add = $"Insert into SACH values({newMaSach},{newMaLoai},{newMatacgia},{newMaNXB},N'{newTensach}',{newDongia},{newSoluong})";
                    cmd = new SqlCommand(add, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công");
                    dtSach.Rows.Clear();
                    daSach.Fill(dtSach);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: "+ex.ToString());
            }
        }

        private void btnXoasach_Click(object sender, EventArgs e)
        {
            if(index >= 0)
            {
                try
                {
                    string MaSach = dtSach.Rows[index][0].ToString();
                    string delete = $"Delete SACH where MaSach = {MaSach}";
                    cmd = new SqlCommand(delete, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công");
                    dtSach.Clear();
                    daSach.Fill(dtSach);
                    index = -1;
                    tbDongia.Clear();
                    tbMaSach.Clear();
                    tbSoluong.Clear();
                    tbMatacgia1.Clear();
                    tbMaNXB1.Clear();
                    tbMaloai1.Clear();
                    tbTensach.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn một trường để xóa");
            }
        }

        private void btnSuasach_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                try
                {
                    string MaSach = dtSach.Rows[index][0].ToString();
                    string newMaLoai = tbMaloai1.Text.Trim();
                    string newMatacgia = tbMatacgia1.Text.Trim();
                    string newMaNXB = tbMaNXB1.Text.Trim();
                    string newTensach = tbTensach.Text.Trim();
                    int newDongia = int.Parse(tbDongia.Text);
                    int newSoluong = int.Parse(tbSoluong.Text);

                    if (string.IsNullOrEmpty(newMaLoai) || string.IsNullOrEmpty(newMatacgia) || string.IsNullOrEmpty(newMaNXB) ||
                    string.IsNullOrEmpty(newTensach) || newDongia <= 0 || newSoluong <= 0)
                    {
                        MessageBox.Show("Hãy nhập đủ thông tin sách và đảm bảo giá và số lượng là số nguyên dương.");
                    }
                    else
                    {
                        string update = $"Update SACH set MaLoai = {newMaLoai}, MaTG = {newMatacgia}, MaNXB = {newMaNXB}, TenSach = N'{newTensach}', Dongia = {newDongia}, Soluong = {newSoluong} where MaSach = {MaSach}";
                        cmd = new SqlCommand(update, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sửa thành công");
                        dtSach.Rows.Clear();
                        daSach.Fill(dtSach);
                        index = -1;
                        tbDongia.Clear();
                        tbMaSach.Clear();
                        tbSoluong.Clear();
                        tbMatacgia1.Clear();
                        tbMaNXB1.Clear();
                        tbMaloai1.Clear();
                        tbTensach.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.ToString());
                }
            }
            else MessageBox.Show("Phải chọn một trường để sửa");
        }

        //Bắt sự kiện cho Tab control Bán hàng
        private void dgBanHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if(index >= 0)
            {
                tbMaHD_BH.Text = dtBanHang.Rows[index][0].ToString().Trim();
                tbTenKhach_BH.Text = dtBanHang.Rows[index][1].ToString().Trim();
                tbSDT_BH.Text = dtBanHang.Rows[index][2].ToString().Trim();
                tbMaSach_BH.Text = dtBanHang.Rows[index][3].ToString().Trim();
                tbSoluong_BH.Text = dtBanHang.Rows[index][4].ToString();
                tbGiaban_BH.Text = dtBanHang.Rows[index][5].ToString();
                tbTongtien_BH.Text = (int.Parse(tbSoluong_BH.Text.ToString()) * int.Parse(tbGiaban_BH.Text.ToString())).ToString();
            }
        }

        private int TongTien = 0;
        private int newSoluong = 0;
        private int newGiaban = 0;

        private void tbSoluong_BH_Textchanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(tbSoluong_BH.Text) >= 0)
                {
                    newSoluong = Convert.ToInt32(tbSoluong_BH.Text);
                    TongTien = newGiaban * newSoluong;
                    tbTongtien_BH.Text = TongTien.ToString();
                }
            }
            catch (FormatException) { }
        }

        private void tbGiaban_BH_Textchanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(tbGiaban_BH.Text) >= 0)
                {
                    newGiaban = Convert.ToInt32(tbGiaban_BH.Text);
                    TongTien = newGiaban * newSoluong;
                    tbTongtien_BH.Text = TongTien.ToString();
                }
            }
            catch (FormatException){ }
        }
        private void btnThem_BH_Click(object sender, EventArgs e)
        {
            try
            {
                string newMaHD = tbMaHD_BH.Text.Trim();
                string newTenKhach = tbTenKhach_BH.Text.Trim();
                string newSDT = tbSDT_BH.Text.Trim();
                string newMaSach = tbMaHD_BH.Text.Trim();
                //int newSoluong = int.Parse(tbSoluong_BH.Text.Trim());
                //int newGiaban = int.Parse(tbGiaban_BH.Text.Trim());
                int newTongtien = Convert.ToInt32(tbTongtien_BH.Text);
                if (string.IsNullOrWhiteSpace(newMaHD) || string.IsNullOrWhiteSpace(newTenKhach) || string.IsNullOrWhiteSpace(newSDT)
                    || string.IsNullOrWhiteSpace(newMaSach) || newSoluong <= 0 || newGiaban <= 0)
                    MessageBox.Show("Hãy nhập đủ thông tin và đảm bảo giá và số lượng là số nguyên dương.");
                else
                {
                    string add_HD = $"Insert into HD values({newMaHD},N'{newTenKhach}',{newSDT},{TongTien})";
                    string add_ChitietHD = $"Insert into ChitietHD values({newMaHD},{newMaSach},{newSoluong},{newGiaban})";
                    cmd = new SqlCommand(add_HD, conn);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand(add_ChitietHD, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm hóa đơn thành công");
                    dtBanHang.Rows.Clear();
                    daBanHang.Fill(dtBanHang);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString());
            }
        }

        private void btnXoa_BH_Click(object sender, EventArgs e)
        {
            if(index >= 0)
            {
                try
                {
                    string MaHD = dtBanHang.Rows[index][0].ToString();
                    string delete = $"Delete ChitietHD where MaHD = {MaHD}";
                    string delete1 = $"Delete HD where MaHD = {MaHD}";
                    cmd = new SqlCommand(delete, conn);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand(delete1,conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công");
                    tbMaHD_BH.Clear();
                    tbTenKhach_BH.Clear();
                    tbSDT_BH.Clear();
                    tbMaSach_BH.Clear();
                    tbSoluong_BH.Clear();
                    tbGiaban_BH.Clear();
                    tbTongtien_BH.Clear();
                    dtBanHang.Rows.Clear();
                    daBanHang.Fill(dtBanHang);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.ToString());
                }
            }
            else { MessageBox.Show("Chọn một trường để xóa"); }
        }

        private void btnSua_HD_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                try
                {
                    string MaHD = dtBanHang.Rows[index][0].ToString();
                    string newTenkhach = tbTenKhach_BH.Text.Trim();
                    string newSdt = tbSDT_BH.Text.Trim();
                    string newMaSach = tbMaSach_BH.Text.Trim();
                    int newSoluong = int.Parse(tbSoluong_BH.Text.Trim());
                    int newGiaban = int.Parse(tbGiaban_BH.Text.Trim());
                    int TongTien = int.Parse(tbTongtien_BH.Text.Trim());
                    if (string.IsNullOrEmpty(newTenkhach) || string.IsNullOrEmpty(newSdt) || string.IsNullOrEmpty(newMaSach) ||
                    string.IsNullOrEmpty(newMaSach) || newSoluong <= 0 || newGiaban <= 0)
                    {
                        MessageBox.Show("Hãy nhập đủ thông tin sách và đảm bảo giá và số lượng là số nguyên dương.");
                    }
                    else
                    {
                        string update = $"Update HD set TenKhach = N'{newTenkhach}',SDT = {newSdt}, Tongtien = {TongTien} where MaHD = {MaHD}";
                        string update1 = $"Update ChitietHD set MaSach = {newMaSach}, SoLuong = {newSoluong}, Giaban = {newGiaban} where MaHD = {MaHD}";
                        cmd = new SqlCommand(update, conn);
                        cmd.ExecuteNonQuery();
                        cmd = new SqlCommand(update1, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Sửa thành công");
                        dtBanHang.Rows.Clear();
                        daBanHang.Fill(dtBanHang);
                        index = -1;
                        tbMaHD_BH.Clear();
                        tbTenKhach_BH.Clear();
                        tbSDT_BH.Clear();
                        tbMaSach_BH.Clear();
                        tbSoluong_BH.Clear();
                        tbGiaban_BH.Clear();
                        tbTongtien_BH.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.ToString());
                }
            }
            else MessageBox.Show("Phải chọn một trường để sửa");
        }
    }
}
