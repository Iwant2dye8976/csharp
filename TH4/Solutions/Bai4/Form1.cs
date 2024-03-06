using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void backColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ColorDialog BackGroundc = new ColorDialog();
                if (BackGroundc.ShowDialog() == DialogResult.OK)
                {
                    this.BackColor = BackGroundc.Color;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void backImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog newImg = new OpenFileDialog();
                newImg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                newImg.Title = "Select Image File";
                if (newImg.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn của tập tin ảnh được chọn
                    string selectedImagePath = newImg.FileName;

                    // Hiển thị ảnh
                    this.BackgroundImage = Image.FromFile(selectedImagePath);
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void fopntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FontDialog fontDialog = new FontDialog();
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    mSTool.Font = fontDialog.Font;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
