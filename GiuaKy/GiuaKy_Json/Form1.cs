using Newtonsoft.Json;
using System.Data;

namespace GiuaKy_Json
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string jsonstr;
        private string path = "QLDIEM.json";
        private DataTable dt;
        private int index = -1;
        private int STT = 1;
        private string newMaSV;
        private string newMonHoc;
        private double newDiem = 0;

        private void Load_Data()
        {
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    jsonstr = sr.ReadToEnd();
                    //MessageBox.Show(jsonstr); Bỏ qua cái này
                    if (jsonstr != "null" && jsonstr != "[]") //Kiểm tra file json có trống hay không
                    {
                        dt = JsonConvert.DeserializeObject<DataTable>(jsonstr);
                    }
                    else
                    {
                        dt = new DataTable();
                        dt.Columns.Add("STT");
                        dt.Columns.Add("Mã SV");
                        dt.Columns.Add("Họ tên");
                        dt.Columns.Add("Môn học");
                        dt.Columns.Add("Điểm");
                    }
                    for (STT = 1; STT <= dt.Rows.Count; STT++)
                    {
                        dt.Rows[STT-1][0] = STT;
                    }
                    dgDiem.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy file .json, chương trình đã khởi tạo file json mới.\nVui lòng khởi động lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Save_File()
        {
            jsonstr = JsonConvert.SerializeObject(dt);
            File.WriteAllText(path, jsonstr);
        }

        private void Clear_()
        {
            cbMaSV.ResetText();
            cbMonHoc.ResetText();
            tbDiem.Clear();
            index = -1;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Load_Data();
        }
        private void dgDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if(index >= 0 && index < dgDiem.Rows.Count)
            {
                cbMaSV.Text = dt.Rows[index][1].ToString().Trim();
                cbMonHoc.Text = dt.Rows[index][3].ToString().Trim();
                tbDiem.Text = dt.Rows[index][4].ToString().Trim();
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(index >= 0 && index < dgDiem.Rows.Count)
            {
                dt.Rows[index][1] = cbMaSV.SelectedItem.ToString().Trim();
                dt.Rows[index][3] = cbMonHoc.SelectedItem.ToString().Trim();
                dt.Rows[index][4] = double.Parse(tbDiem.Text.Trim());
                MessageBox.Show("Cập nhật thành công");
                Save_File();
                Clear_();
                Load_Data();
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear_();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                newMaSV = cbMaSV.SelectedItem.ToString();
                newMonHoc = cbMonHoc.SelectedItem.ToString();
                newDiem = double.Parse(tbDiem.Text.Trim());
                if (newDiem < 0 || newDiem > 10)
                    MessageBox.Show("Điểm vừa nhập không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    dt.Rows.Add(STT, newMaSV, "Si Tạ", newMonHoc, newDiem);
                    Save_File();
                    MessageBox.Show("Thêm thành công");
                    Load_Data();
                    Clear_();
                }

            }
            catch (NullReferenceException) 
            {
                MessageBox.Show("Điểm ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(FormatException)
            {
                MessageBox.Show("Điểm vừa nhập không đúng định dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(index >= 0 && index < dt.Rows.Count)
            {
                dt.Rows[index].Delete();
                Save_File();
                MessageBox.Show("Xóa thành công");
                Clear_();
                Load_Data();
            }
            else
            {
                MessageBox.Show("Chọn một dòng để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save_File();
        }
    }
}
