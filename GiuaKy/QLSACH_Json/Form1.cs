using Microsoft.Win32;
using Newtonsoft.Json;
using System.Data;
using System.Drawing.Printing;

namespace QLSACH_Json
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string jsonstr;
        private string path = @"QLSACH.json";
        private DataTable dt;
        private int index = -1;
        //private int index2 = -1;
        private string newMaSach;
        private string newTenSach;
        private string newTacGia;
        private string newNgonNgu;
        private string newTheLoai;
        private void Load_Data()
        {
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    jsonstr = sr.ReadToEnd();
                    if (jsonstr != "null" && jsonstr != "[]")
                    {
                        dt = JsonConvert.DeserializeObject<DataTable>(jsonstr);
                    }
                    else
                    {
                        dt = new DataTable();
                        dt.Columns.Add("Mã sách");
                        dt.Columns.Add("Tên sách");
                        dt.Columns.Add("Tác giả");
                        dt.Columns.Add("Ngôn ngữ");
                        dt.Columns.Add("Thể loại");
                    }
                    dgSach.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Không thể mở file .json.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Đã khởi tạo file .json, vui lòng khởi động lại<3", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //private void Clear__()
        //{
        //    tbMaSach.Clear();
        //    tbTacGia.Clear();
        //    tbTenSach.Clear();
        //    tbTimKiem.Clear();
        //    cbNgonNgu.SelectedIndex = 0;
        //    rbGiaoTrinh.Select();
        //    tbMaSach.Focus();
        //    index = -1;
        //}
        private void Clear__1()
        {
            tbMaSach.Clear();
            tbTacGia.Clear();
            tbTenSach.Clear();
            tbTimKiem.Clear();
            cbNgonNgu.ResetText();
            //rbGiaoTrinh.Select();
            tbMaSach.Focus();
            index = -1;
        }

        private void Save_File()
        {
            jsonstr = JsonConvert.SerializeObject(dt);
            File.WriteAllText(path, jsonstr);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void gbTheLoai_Enter(object sender, EventArgs e)
        {
            if (rbGiaoTrinh.Checked)
                newTheLoai = rbGiaoTrinh.Text.ToString();
            else
            {
                if (rbTapChi.Checked)
                    newTheLoai = rbTapChi.Text.ToString();
                else
                {
                    if (rbSChuyenKhao.Checked)
                        newTheLoai = rbSChuyenKhao.Text.ToString();
                    else
                        newTheLoai = rbSThamKhao.Text.ToString();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear__1();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            newMaSach = tbMaSach.Text.Trim();
            newTenSach = tbTenSach.Text.Trim();
            newTacGia = tbTacGia.Text.Trim();
            newNgonNgu = cbNgonNgu.SelectedItem.ToString();
            if (string.IsNullOrWhiteSpace(newMaSach) || string.IsNullOrWhiteSpace(newTenSach) || string.IsNullOrWhiteSpace(newTacGia) || string.IsNullOrWhiteSpace(newNgonNgu))
                MessageBox.Show("Hãy nhập đủ thông tin sách", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                dt.Rows.Add(newMaSach, newTenSach, newTacGia, newNgonNgu, newTheLoai);
                Save_File();
                MessageBox.Show("Thêm thành công");
                Clear__1();
                Load_Data();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (index >= 0 && index < dt.Rows.Count)
            {
                if (string.IsNullOrWhiteSpace(tbMaSach.Text) || string.IsNullOrWhiteSpace(tbTenSach.Text) || string.IsNullOrWhiteSpace(tbTacGia.Text) || string.IsNullOrWhiteSpace(newNgonNgu))
                    MessageBox.Show("Hãy nhập đủ thông tin sách", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    dt.Rows[index]["Mã sách"] = tbMaSach.Text.Trim();
                    dt.Rows[index]["Tên sách"] = tbTenSach.Text.Trim();
                    dt.Rows[index]["Tác giả"] = tbTacGia.Text.Trim();
                    dt.Rows[index]["Ngôn ngữ"] = cbNgonNgu.SelectedItem.ToString();
                    gbTheLoai_Enter(sender, e);
                    dt.Rows[index]["Thể loại"] = newTheLoai;
                    Save_File();
                    MessageBox.Show("Sửa thành công");
                    Load_Data();
                    Clear__1();
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn một dòng để sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                dt.Rows.RemoveAt(index);
                Save_File();
                MessageBox.Show("Xóa thành công");
                Clear__1();
                Load_Data();
            }
            MessageBox.Show("Hãy chọn một dòng để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                tbMaSach.Text = dt.Rows[index]["Mã sách"].ToString();
                tbTenSach.Text = dt.Rows[index]["Tên sách"].ToString();
                tbTacGia.Text = dt.Rows[index]["Tác giả"].ToString();
                cbNgonNgu.Text = dt.Rows[index]["Ngôn ngữ"].ToString();
                newTheLoai = dt.Rows[index]["Thể loại"].ToString();

                // Kiểm tra loại sách và chọn RadioButton tương ứng
                switch (newTheLoai)
                {
                    case "Giáo trình":
                        rbGiaoTrinh.Checked = true;
                        break;
                    case "Tạp chí":
                        rbTapChi.Checked = true;
                        break;
                    case "Sách chuyên khảo":
                        rbSChuyenKhao.Checked = true;
                        break;
                    case "Sách tham khảo":
                        rbSThamKhao.Checked = true;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Clear__1();
            }
        }

        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {
            DataTable dt1 = dt.Clone();
            string tofind = tbTimKiem.Text.Trim().ToLower();
            foreach (DataRow row in dt.Rows)
            {
                if (row["Mã sách"].ToString().ToLower().Contains(tofind) || row["Tên sách"].ToString().ToLower().Contains(tofind))
                {
                    dt1.ImportRow(row);
                }
            }
            dgSach.DataSource = dt1;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save_File();
        }
    }
}
