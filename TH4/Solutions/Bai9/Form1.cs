namespace Bai9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Xử lý sự kiện khi nút "Thêm" được nhấn
        private void btnThem_Click(object sender, EventArgs e)
        { 
            // Kiểm tra nếu các trường thông tin không được nhập đầy đủ
            if (tbHoten.Text == string.Empty || tbDienthoai.Text == string.Empty || tbDiachi.Text == string.Empty)
            {
                MessageBox.Show("Bạn phải điền đầy đủ thông tin");
            }
            else
            {
                // Thêm một ListViewItem mới vào ListView
                ListViewItem item = lvThongTin.Items.Add(tbHoten.Text.ToString());
                item.SubItems.Add(dtpNgaysinh.Value.ToShortDateString());
                item.SubItems.Add(tbDiachi.Text.ToString());
                item.SubItems.Add(tbDienthoai.Text.ToString());
            }
        }

        // Xử lý sự kiện khi nút "Xóa" được nhấn
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvThongTin.SelectedItems.Count > 0)
            {
                // Xóa các mục được chọn từ ListView
                for (int i = lvThongTin.SelectedItems.Count - 1; i >= 0; i--)
                {
                    lvThongTin.Items.Remove(lvThongTin.SelectedItems[i]);
                }
                // Xóa nội dung trong các textbox và đặt ngày sinh về ngày hôm nay
                tbHoten.Clear();
                tbDiachi.Clear();
                tbDienthoai.Clear();
                dtpNgaysinh.Value = DateTime.Today;
            }
            else
            {
                MessageBox.Show("Hãy chọn ít nhất một trường để xóa");
            }
        }

        // Xử lý sự kiện khi nút "Sửa" được nhấn
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvThongTin.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bạn phải chọn ít nhất một trường để sửa");
            }
            else
            {
                // Kiểm tra nếu các trường thông tin không được nhập đầy đủ
                if (tbHoten.Text == string.Empty || tbDienthoai.Text == string.Empty || tbDiachi.Text == string.Empty)
                {
                    MessageBox.Show("Bạn phải điền đầy đủ thông tin");
                }
                else
                {
                    // Sửa các giá trị của các mục được chọn trong ListView
                    for (int i = lvThongTin.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        lvThongTin.SelectedItems[i].SubItems[0].Text = tbHoten.Text;
                        lvThongTin.SelectedItems[i].SubItems[1].Text = dtpNgaysinh.Value.ToShortDateString();
                        lvThongTin.SelectedItems[i].SubItems[2].Text = tbDiachi.Text;
                        lvThongTin.SelectedItems[i].SubItems[3].Text = tbDienthoai.Text;
                    }
                }
            }
        }

        // Xử lý sự kiện khi các mục trong ListView được chọn
        private void lvThongTin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvThongTin.SelectedItems.Count > 0)
            {
                // Hiển thị thông tin của mục được chọn trong các textbox tương ứng
                tbHoten.Text = lvThongTin.SelectedItems[0].SubItems[0].Text;
                dtpNgaysinh.Text = lvThongTin.SelectedItems[0].SubItems[1].Text;
                tbDiachi.Text = lvThongTin.SelectedItems[0].SubItems[2].Text;
                tbDienthoai.Text = lvThongTin.SelectedItems[0].SubItems[3].Text;
            }
        }

        // Xử lý sự kiện khi nút "Thoát" được nhấn
        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Thoát chương trình
            Environment.Exit(0);
        }
    }
}
