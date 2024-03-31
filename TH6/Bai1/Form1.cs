using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int index = -1;
        private string jsonstr;
        private string newMaSV, newHoTen, newGioiTinh, newNgaySinh, newNoiSinh, newKhoa, newLop;
        private DataTable dt;
        private string path = @"QLSV.json";
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
                        dt.Columns.Add("Mã SV");
                        dt.Columns.Add("Họ tên");
                        dt.Columns.Add("Ngày sinh");
                        dt.Columns.Add("Giới tính");
                        dt.Columns.Add("Quê quán");
                        dt.Columns.Add("Khoa");
                        dt.Columns.Add("Lớp");
                    }
                }
                dgSV.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không thể mở file .json", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Save_File()
        {
            jsonstr = JsonConvert.SerializeObject(dt);
            File.WriteAllText(path, jsonstr);
        }

        private string Update_gioiTinh()
        {
            if (rbNam.Checked || rbNu.Checked)
                if(rbNam.Checked)
                    return rbNam.Text.Trim();

                else
                    return rbNu.Text.Trim();
            else
                return null;
        }

        private void Clear__()
        {
            tbHoTen.Clear();
            tbMaSV.Clear();
            cbNoiSinh.SelectedIndex = -1;
            cbKhoa.SelectedIndex = -1;
            cbLop.SelectedIndex = -1;
            dtpNgaySinh.Value = DateTime.Now;
            rbNam.Checked = false;
            rbNu.Checked = false;
            index = -1;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbNoiSinh.SelectedItem != null && cbKhoa.SelectedItem != null && cbLop.SelectedItem != null)
                {
                    newMaSV = tbMaSV.Text.Trim();
                    newHoTen = tbHoTen.Text.Trim();
                    newNgaySinh = dtpNgaySinh.Value.ToShortDateString();
                    newGioiTinh = Update_gioiTinh();
                    newNoiSinh = cbNoiSinh.SelectedItem.ToString();
                    newKhoa = cbKhoa.SelectedItem.ToString();
                    newLop = cbLop.SelectedItem.ToString();
                    if (string.IsNullOrWhiteSpace(newMaSV) || string.IsNullOrWhiteSpace(newHoTen) || string.IsNullOrWhiteSpace(newGioiTinh))
                        MessageBox.Show("Hãy điền đầy đủ thông tin");
                    else
                    {
                        dt.Rows.Add(newMaSV, newHoTen, newNgaySinh, newGioiTinh, newNoiSinh, newKhoa, newLop);
                        Save_File();
                        Load_Data();
                        Clear__();
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn đầy đủ các mục");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi không xác định");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                if (cbNoiSinh.SelectedItem != null && cbKhoa.SelectedItem != null && cbLop.SelectedItem != null)
                {
                    dt.Rows[index]["Mã SV"] = tbMaSV.Text.Trim();
                    dt.Rows[index]["Họ tên"] = tbHoTen.Text.Trim();
                    dt.Rows[index]["Giới tính"] = Update_gioiTinh();
                    dt.Rows[index]["Ngày sinh"] = dtpNgaySinh.Value.ToShortDateString();
                    dt.Rows[index]["Quê quán"] = cbNoiSinh.SelectedItem.ToString();
                    dt.Rows[index]["Khoa"] = cbKhoa.SelectedItem.ToString();
                    dt.Rows[index]["Lớp"] = cbLop.SelectedItem.ToString();
                    if (string.IsNullOrWhiteSpace(tbMaSV.Text) || string.IsNullOrWhiteSpace(tbHoTen.Text) || string.IsNullOrWhiteSpace(Update_gioiTinh()))
                        MessageBox.Show("Hãy điền đầy đủ thông tin");
                    else
                    {
                        Save_File();
                        Load_Data();
                    }
                    Clear__();
                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                dt.Rows.RemoveAt(index);
                Save_File();
                Clear__();
            }
        }

        private void dgSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                tbMaSV.Text = dt.Rows[index]["Mã SV"].ToString();
                tbHoTen.Text = dt.Rows[index]["Họ tên"].ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(dt.Rows[index]["Ngày sinh"].ToString());
                cbNoiSinh.Text = dt.Rows[index]["Quê quán"].ToString();
                cbKhoa.Text = dt.Rows[index]["Khoa"].ToString();
                cbLop.Text = dt.Rows[index]["Lớp"].ToString();
                newGioiTinh = dt.Rows[index]["Giới tính"].ToString();
                switch (newGioiTinh)
                {
                    case "Nam": rbNam.Checked = true; break;
                    case "Nữ": rbNu.Checked = true; break;
                }
            }
            else
            {
                Clear__();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save_File();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Clear__();
        }
    }
}
