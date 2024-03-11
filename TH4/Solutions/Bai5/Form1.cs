using System;
using System.Windows.Forms.VisualStyles;

namespace Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Tạo danh sách 20 máy
            for (int i = 0; i < 20; i++)
            {
                // Tạo items cho listview
                ListViewItem item = new ListViewItem((i + 1).ToString());

                // Khởi tạo dữ liệu cho các cột
                item.SubItems.Add("Offline");
                item.SubItems.Add("None");
                item.SubItems.Add("0");
                item.SubItems.Add("0");

                // Thêm item vào các hàng trong listview
                lvDanhsachMay.Items.Add(item);
            }
        }

        private DateTime[] dateTimes = new DateTime[20];
        private bool[] notOccupied = Enumerable.Repeat(true, 20).ToArray();
        private void btnDatMay_Click(object sender, EventArgs e)
        {
            if (lvDanhsachMay.SelectedItems.Count > 0)
            {
                int sl = lvDanhsachMay.SelectedItems.Count;
                int index2 = lvDanhsachMay.SelectedItems[0].Index;
                while (sl > 0)
                {
                    if (notOccupied[index2])
                    {
                        if (lvDanhsachMay.Items[index2].SubItems[1].Text == "Offline")
                        {
                            lvDanhsachMay.Items[index2].SubItems[1].Text = "Online";
                            lvDanhsachMay.Items[index2].SubItems[2].Text = $"{DateTime.Now.ToShortTimeString()} {DateTime.Now.ToShortDateString()}";
                            dateTimes[index2] = DateTime.Now;
                            notOccupied[index2] = false;
                        }
                        index2++;
                        sl--;
                    }
                    else
                    {
                        MessageBox.Show("Máy đã được cho thuê");
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Chọn một máy để đặt");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            for (int i = 19; i >= 0; i--)
            {
                if (lvDanhsachMay.Items[i].SubItems[1].Text == "Online")
                {
                    int totalMinutes = (int)(DateTime.Now - dateTimes[i]).TotalMinutes;
                    lvDanhsachMay.Items[i].SubItems[3].Text = $"{totalMinutes}";
                    int thanhTien = 5000 * (totalMinutes / 60);
                    lvDanhsachMay.Items[i].SubItems[4].Text = $"{thanhTien}";
                }
            }
        }

        private void btnTraMay_Click(object sender, EventArgs e)
        {
            if (lvDanhsachMay.SelectedItems.Count == 1)
            {
                int selectedIndex = lvDanhsachMay.SelectedItems[0].Index;

                if (selectedIndex >= 0 && selectedIndex < dateTimes.Length)
                {
                    if (lvDanhsachMay.SelectedItems[0].SubItems[1].Text == "Online")
                    {
                        int totalMinutes = (int)(DateTime.Now - dateTimes[selectedIndex]).TotalMinutes;
                        int thanhTien = 5000 * (totalMinutes / 60);

                        DialogResult result = MessageBox.Show($"Tổng: {thanhTien}VND", "Bạn có muốn xác nhận trả máy", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                        if (result == DialogResult.OK)
                        {
                            lvDanhsachMay.Items[selectedIndex].SubItems[1].Text = "Offline";
                            lvDanhsachMay.Items[selectedIndex].SubItems[2].Text = "None";
                            lvDanhsachMay.Items[selectedIndex].SubItems[3].Text = "0";
                            lvDanhsachMay.Items[selectedIndex].SubItems[4].Text = "0";
                            notOccupied[selectedIndex] = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Máy đang Offline");
                    }
                }
                else
                {
                    MessageBox.Show("Index out of range");
                }
            }
            else
            {
                MessageBox.Show("Chỉ được trả tối đa một máy mỗi lần");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            // Thoát chương trình
            Environment.Exit(0);
        }
    }
}
