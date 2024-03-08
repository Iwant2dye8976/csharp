using System.Diagnostics;

namespace Bai8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
    a    }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                rTextBox.Font = fontDialog.Font;
            }
        }
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            string selectedText = rTextBox.SelectedText;
            if (colorDialog.ShowDialog(this) == DialogResult.OK)
            {
                if (selectedText != string.Empty)
                {
                    rTextBox.SelectionColor = colorDialog.Color;
                }
                else
                {
                    rTextBox.ForeColor = colorDialog.Color;
                }
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedText = rTextBox.SelectedText;
            if (selectedText != string.Empty)
            {
                Clipboard.SetText(selectedText);
                rTextBox.Text = rTextBox.Text.Remove(rTextBox.SelectionStart, rTextBox.SelectionLength);
            }
            else return;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedText = rTextBox.SelectedText;
            if (selectedText.Length != 0)
            {
                Clipboard.SetText(selectedText);
            }
            else return;
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                int cursorPosition = rTextBox.SelectionStart;
                rTextBox.Text = rTextBox.Text.Insert(cursorPosition, Clipboard.GetText());
                rTextBox.SelectionStart = cursorPosition + Clipboard.GetText().Length;
            }
        }
        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form repalceForm = new Form();
            repalceForm.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;

                try
                {
                    // Lấy nội dung từ TextBox
                    string content = rTextBox.Text;

                    // Ghi nội dung vào file
                    File.WriteAllText(fileName, content);

                    MessageBox.Show("File đã được lưu thành công.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu file: " + ex.Message);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;

                try
                {
                    // Đọc nội dung từ file
                    string content = File.ReadAllText(fileName);

                    // Hiển thị nội dung trong TextBox (assumed textBox1 is your TextBox control)
                    rTextBox.Text = content;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi mở file: " + ex.Message);
                }
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "https://www.youtube.com/watch?v=uHgt8giw1LY"; // Thay thế URL của bạn ở đây

            try
            {
                // Mở URL trong trình duyệt mặc định
                Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở URL. Lỗi: " + ex.Message);
            }
        }

        private void rTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true; // Ngăn không cho phím Tab thực hiện hành động mặc định của nó
                int cursorPosition = rTextBox.SelectionStart;
                rTextBox.Text = rTextBox.Text.Insert(cursorPosition, "\t"); // Chèn một tab vào vị trí con trỏ
                rTextBox.SelectionStart = cursorPosition + 1; // Đặt lại vị trí con trỏ sau tab vừa được chèn vào
            }
        }
    }
}
