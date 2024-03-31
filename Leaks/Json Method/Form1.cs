using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace Bai1
{
    public partial class Form1 : Form
    {
        private int index = -1;
        public Form1()
        {
            InitializeComponent();
        }

        string jsonstr;
        string path = "SinhVien.json";
        private DataTable dt;

        private void Form1_Load(object sender, EventArgs e)
        {
            //dt = new DataTable();
            //dt.Columns.Add("Mã sinh viên");
            //dt.Columns.Add("Tên sinh viên");
            //dt.Columns.Add("Ngày sinh", typeof(DateTime));
            //dt.Columns.Add("Địa chỉ");
            Load_Data();
        }
        //Load dữ liệu từ file json
        private void Load_Data()
        {
            if (File.Exists(path)) //Kiểm tra file json có tồn tại không
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
                        // If JSON string is empty, create a new DataTable with columns
                        dt = new DataTable();
                        dt.Columns.Add("Mã sinh viên");
                        dt.Columns.Add("Tên sinh viên");
                        dt.Columns.Add("Ngày sinh", typeof(DateTime));
                        dt.Columns.Add("Địa chỉ");
                    }
                    dgSinhVien.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Không thể mở file .json", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Chuyển đổi DataTable sang chuỗi json và lưu
        private void SaveFile()
        {
            jsonstr = JsonConvert.SerializeObject(dt);
            File.WriteAllText(path, jsonstr);
        }
        //Bắt sự kiện khi click vào DataGridView
        private void dgSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                tbMaSV.Text = dt.Rows[index][0].ToString();
                tbTenSV.Text = dt.Rows[index][1].ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(dt.Rows[index][2]);
                tbDiaChi.Text = dt.Rows[index][3].ToString();
            }
        }
        //Xóa các ô text box sau khi thực hiện Thêm, Sửa, Xóa
        private void _Clear_()
        {
            index = -1;
            tbMaSV.Clear();
            tbTenSV.Clear();
            dtpNgaySinh.Value = DateTime.Now.Date;
            tbDiaChi.Clear();
            tbTimKiem.Clear();
        }

        //Bắt sự kiện cho Button Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            string NewMaSV = tbMaSV.Text.Trim();
            string NewTenSV = tbTenSV.Text.Trim();
            string NewDiaChi = tbDiaChi.Text.Trim();
            if (!string.IsNullOrWhiteSpace(NewMaSV) && !string.IsNullOrWhiteSpace(NewTenSV) && !string.IsNullOrWhiteSpace(NewDiaChi))
            {
                dt.Rows.Add(tbMaSV.Text.Trim(), tbTenSV.Text.Trim(), dtpNgaySinh.Value.ToShortDateString(), tbDiaChi.Text.Trim());
                SaveFile();
                MessageBox.Show("Thêm thành công", "Done");
                _Clear_();
                Load_Data();
            }
            else
            {
                MessageBox.Show("Hãy điền đủ thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Bắt sự kiện cho Button Lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                dt.Rows[index][0] = tbMaSV.Text.Trim();
                dt.Rows[index][1] = tbTenSV.Text.Trim();
                dt.Rows[index][2] = dtpNgaySinh.Value.ToShortDateString();
                dt.Rows[index][3] = tbDiaChi.Text.Trim();
                SaveFile();
                MessageBox.Show("Lưu thành công", "Done");
                _Clear_();
                Load_Data();
            }
            else
            {
                MessageBox.Show("Chọn một dòng để sửa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Bắt sự kiện cho Button Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                dt.Rows[index].Delete();
                SaveFile();
                MessageBox.Show("Xóa thành công", "Done");
                _Clear_();
                Load_Data();
            }
            else
            {
                MessageBox.Show("Chọn một dòng để xóa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Bắt sự kiện khi nhập chữ vào TextBox Tìm Kiếm
        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {
            string toFindStr = tbTimKiem.Text.Trim().ToLower();
            DataView dv = new DataView(dt);
            DataTable filteredTable = dt.Clone();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][1].ToString().ToLower().Contains(toFindStr))
                {
                    filteredTable.ImportRow(dt.Rows[i]);
                }
            }
            dgSinhVien.DataSource = filteredTable;
        }
        //Bắt sự kiện đóng Form
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(jsonstr) && jsonstr != "[]")
            {
                SaveFile();
            }
        }
    }
}
