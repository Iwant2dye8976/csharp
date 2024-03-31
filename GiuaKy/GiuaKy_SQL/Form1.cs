using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
namespace Slq_Method
{
    public partial class Form1 : Form
    {
        private string connectionStr = @"Data Source=DESKTOP-NN2JUAV\SQLEXPRESS;Initial Catalog=QLDIEM;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }
        private SqlDataAdapter da;
        private DataTable dt = new DataTable("Diem");
        private int index = -1;
        //private int STT = 0;
        private string newMaSV;
        private string newMonHoc;
        private float newDiem;
        private bool hasColums = false;
        private void Load_Data()
        {
            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                conn.Open();
                if (!hasColums)
                {
                    dt.Columns.Add("STT"); //Tránh việc mỗi lần load data sẽ tạo thêm một cột STT mới
                    hasColums = true;
                }
                string fill = "SELECT MaSV as N'Mã SV', HoTen as N'Họ Tên', MonHoc as N'Môn học', Diem as 'Điểm'  FROM DIEM";
                da = new SqlDataAdapter(fill, conn);
                dt.Rows.Clear();
                da.Fill(dt);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["STT"] = i + 1; //Đánh số thứ tự cho các hàng
                }
                dgDiem.DataSource = dt;
            }
        }

        private void Clear_()
        {
            cbMaSV.ResetText(); //Reset làm combobox trắng
            cbMonHoc.ResetText();
            tbDiem.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Load_Data();
        }
        private void dgDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0 && index < dt.Rows.Count)
            {
                cbMaSV.Text = dt.Rows[index][1].ToString().Trim();
                cbMonHoc.Text = dt.Rows[index][3].ToString().Trim();
                tbDiem.Text = dt.Rows[index][4].ToString().Trim();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(index >= 0 && index < dt.Rows.Count)
            {
                try
                {
                    string newMaSV = cbMaSV.SelectedItem.ToString();
                    string newMonHoc = cbMonHoc.SelectedItem.ToString();
                    double newDiem = double.Parse(tbDiem.Text.Trim());
                    //MessageBox.Show(newMaSV + newMonHoc + newDiem.ToString //Chỗ này ko cần quan tâm
                    if ((newDiem >= 0 && newDiem <= 10) && !string.IsNullOrWhiteSpace(Convert.ToString(newDiem)))
                    {
                        string Update = $"UPDATE DIEM SET MaSV = @MaSV, MonHoc = @MonHoc, Diem = @Diem WHERE MaSV = {newMaSV}";
                        using (SqlConnection conn = new SqlConnection(connectionStr))
                        {

                            conn.Open();
                            using (SqlCommand cmd = new SqlCommand(Update, conn))
                            {
                                cmd.Parameters.AddWithValue("@MaSV", newMaSV);
                                cmd.Parameters.AddWithValue("@MonHoc", newMonHoc);
                                cmd.Parameters.AddWithValue("@Diem", newDiem);
                                cmd.ExecuteNonQuery();
                            }
                            MessageBox.Show("Cập nhật thành công");
                            Load_Data();
                            Clear_();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Điểm nhập vào phải >=0 và <= 10", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Lỗi định dạng điểm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbDiem.Focus();
                }
                catch (NullReferenceException) //Bắt ngoại lệ khi điền vớ vẩn vào combobox . K hiểu sao lại ko đc
                {
                    MessageBox.Show("Mã sinh viên hoặc môn học không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clear_();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            newMaSV = cbMaSV.SelectedItem.ToString();
            newMonHoc = cbMonHoc.SelectedItem.ToString();
            float.Parse(tbDiem.Text.Trim());
            if ( (newDiem >= 0 && newDiem <= 10) && !string.IsNullOrWhiteSpace(Convert.ToString(newDiem)))
            {
                try
                {
                    string Insert = $"INSERT INTO DIEM (MaSV,MonHoc,Diem) VALUES (@MaSV,@MonHoc,@Diem)";
                    using (SqlConnection conn = new SqlConnection(connectionStr))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(Insert, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaSV", newMaSV);
                            cmd.Parameters.AddWithValue("@MonHoc", newMonHoc);
                            cmd.Parameters.AddWithValue("@Diem", newDiem);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Thêm thành công");
                        Load_Data();
                        Clear_();
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) // 2627 là mã lỗi của việc trùng lặp khóa chính thật là vãi l
                        MessageBox.Show("Trùng lặp khóa chính(Mã SV), hãy chọn giá trị khác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Lỗi định dạng điểm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbDiem.Focus();
                }
            }
            else
            {
                MessageBox.Show("Điểm nhập vào phải >=0 và <= 10","Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(index >= 0 && index <= dt.Rows.Count) 
            {
                newMaSV = cbMaSV.SelectedItem.ToString();
                string delete = "DELETE DIEM WHERE MaSV = @MaSV";
                using (SqlConnection conn = new SqlConnection(connectionStr))
                {
                    using (SqlCommand cmd = new SqlCommand(delete, conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@MaSV", newMaSV);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công");
                    }
                }
                Clear_();
                Load_Data();
            }
        }
    }
}
