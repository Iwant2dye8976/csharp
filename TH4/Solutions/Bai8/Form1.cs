using System.Diagnostics;
using System.Text;

namespace Bai8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }
        private bool isSaved = false;
        private bool isSave_As = false;
        private string filePath = string.Empty;
        private bool CheckIfModified()
        {
            string newContent = rTextBox.Text.ToString();
            if (newContent == oldContent)
                return isSaved = true;
            return isSaved = false;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CheckIfModified();
            if ((!isSave_As || !isSaved) && !string.IsNullOrEmpty(filePath))
            {
                // Nếu không lưu trước đó, hiển thị hộp thoại hoặc thực hiện các hành động cần thiết
                DialogResult result = MessageBox.Show("Bạn chưa lưu công việc. Bạn có muốn lưu trước khi thoát không?",
                                                        "Cảnh báo",
                                                        MessageBoxButtons.YesNoCancel,
                                                        MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Thực hiện hành động lưu trước khi thoát
                    saveToolStripMenuItem_Click(sender, e);
                }
                else if (result == DialogResult.Cancel)
                {
                    // Hủy việc đóng form
                    e.Cancel = true;
                }
            }
            else
            {
                if (rTextBox.Text.Length > 0)
                {
                    DialogResult result = MessageBox.Show("Bạn chưa lưu công việc. Bạn có muốn lưu trước khi thoát không?",
                                                        "Cảnh báo",
                                                        MessageBoxButtons.YesNoCancel,
                                                        MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        // Thực hiện hành động lưu trước khi thoát
                        saveToolStripMenuItem_Click(sender, e);
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        // Hủy việc đóng form
                        e.Cancel = true;
                    }
                }
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckIfModified();
            savefile saveDialog = new savefile();
            string state = saveDialog.ShowDialog().ToString();
            if (!isSave_As)
            {
                switch (state)
                {
                    case "OK": saveasToolStripMenuItem_Click(sender, e); break;
                    case "Cancel": break;
                    case "None": break;
                    default: Environment.Exit(0); break; //Thoát ứng dụng

                }
            }
            else
            {
                if (!isSaved)
                {
                    switch (state)
                    {
                        case "OK": saveToolStripMenuItem_Click(sender, e); break;
                        case "Cancel": break;
                        case "None": break;
                        default: Environment.Exit(0); break; //Thoát ứng dụng
                    }
                }
            }
        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                rTextBox.Font = fontDialog.Font; // Thiết lập font chữ cho RichTextBox
            }
            // Bug: Mất hết màu đã chỉnh khi thay đổi font chữ :((
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            string selectedText = rTextBox.SelectedText;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                if (selectedText != string.Empty)
                {
                    rTextBox.SelectionColor = colorDialog.Color; // Thiết lập màu cho văn bản được chọn
                }
                else
                {
                    rTextBox.ForeColor = colorDialog.Color; // Thiết lập màu cho văn bản
                }
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedText = rTextBox.SelectedText;
            if (selectedText != string.Empty)
            {
                Clipboard.SetText(selectedText); // Sao chép văn bản được chọn vào Clipboard
                rTextBox.Text = rTextBox.Text.Remove(rTextBox.SelectionStart, rTextBox.SelectionLength); // Xóa văn bản được chọn từ RichTextBox
            }
            else return;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedText = rTextBox.SelectedText;
            if (selectedText.Length != 0)
            {
                Clipboard.SetText(selectedText); // Sao chép văn bản được chọn vào Clipboard
            }
            else return;
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                // Vị trí hiện tại của con trỏ văn bản
                int cursorPosition = rTextBox.SelectionStart;

                // Chèn căn bản từ Clipboard vào vị trí của con trỏ văn bản
                rTextBox.Text = rTextBox.Text.Insert(cursorPosition, Clipboard.GetText());
                rTextBox.SelectionStart = cursorPosition + Clipboard.GetText().Length;
            }
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var replaceDialog = new replace())
            {
                if (replaceDialog.ShowDialog() == DialogResult.OK)
                {
                    string textToFind = replaceDialog.TextToFind;
                    string textToReplaceWith = replaceDialog.TextToReplaceWith;
                    int length = textToFind.Length;

                    // Sử dụng StringBuilder để xây dựng văn bản mới một cách hiệu quả
                    StringBuilder newTextBuilder = new StringBuilder();

                    // Đặt vị trí quét ở đầu văn bản
                    int currentIndex = 0;

                    // Quét tới khi hết văn bản
                    while (currentIndex < rTextBox.Text.Length)
                    {
                        // Kiểm tra xem TextToFind có tồn tại từ vị trí hiện tại hay không
                        int indexOfTextToFind = rTextBox.Text.IndexOf(textToFind, currentIndex);

                        if (indexOfTextToFind == -1)
                        {
                            // Nếu không tìm thấy TextToFind từ vị trí hiện tại về sau,
                            // thêm đoạn text còn lại và thoát khỏi vòng lặp
                            newTextBuilder.Append(rTextBox.Text.Substring(currentIndex));
                            break;
                        }

                        // Thêm đoạn text (trước vị trí tìm thấy TextToFind) vào newTextBuilder
                        newTextBuilder.Append(rTextBox.Text.Substring(currentIndex, indexOfTextToFind - currentIndex));

                        // Thêm vào đoạn text đã được thay thế
                        newTextBuilder.Append(textToReplaceWith);

                        // Di chuyển con trỏ đến vị trí mới = độ dài của TextToFind 
                        currentIndex = indexOfTextToFind + length;
                    }

                    // Thay thế văn bản cũ bằng văn bản mới
                    rTextBox.Text = newTextBuilder.ToString();
                }
            }
        }

        private void saveasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;

                try
                {
                    // Get the text from RichTextBox
                    string content = rTextBox.Text;

                    // Write the content to the file
                    File.WriteAllText(filePath, content);

                    MessageBox.Show("File đã được lưu thành công."); // Notify successful save
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu file: " + ex.Message); // Notify save error
                }
            }
            //else
            //{
            //    MessageBox.Show(DialogResult.ToString());
            //}
            isSave_As = true;
        }

        private string oldContent = string.Empty;
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string curentText = rTextBox.Text.ToString();
            if ((isSave_As || isSaved) || string.IsNullOrEmpty(curentText))
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Text Files (*.txt)|*.txt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    try
                    {
                        // Đọc nội dung từ file
                        string content = File.ReadAllText(filePath);
                        oldContent = content;
                        // Hiển thị nội dung trong RichTextBox
                        rTextBox.Text = content;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi mở file: " + ex.Message); // Thông báo lỗi khi mở file
                    }
                }
                isSave_As = true;
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn chưa lưu công việc. Bạn có muốn lưu trước khi tạo file mới không?",
                                                        "Cảnh báo",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (!isSave_As)
                    {
                        saveasToolStripMenuItem_Click(sender, e);
                    }
                    else
                    {
                        saveToolStripMenuItem_Click(sender, e);
                    }
                    openToolStripMenuItem_Click(sender, e);
                }
                else
                {
                    rTextBox.Clear();
                    openToolStripMenuItem_Click(sender, e);
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
                MessageBox.Show("Không thể mở URL. Lỗi: " + ex.Message); // Thông báo lỗi không thể mở URL
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if a file has been saved previously using Save As
            if (isSave_As && !string.IsNullOrEmpty(filePath))
            {
                try
                {
                    // Get the new text from RichTextBox
                    string newText = rTextBox.Text;

                    // Write the new text to the file
                    File.WriteAllText(filePath, newText);

                    MessageBox.Show("File đã được cập nhật thành công.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật file: " + ex.Message);
                }
            }
            else
            {
                // If the file hasn't been saved previously, prompt the user to use Save As
                saveasToolStripMenuItem_Click(sender, e);
            }
            isSaved = true;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if((!isSave_As || !isSaved) && rTextBox.Text.Length > 0)
            {
                DialogResult result = MessageBox.Show("Bạn chưa lưu công việc. Bạn có muốn lưu trước khi tạo file mới không?",
                                                        "Cảnh báo",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (!isSave_As)
                    {
                        saveasToolStripMenuItem_Click(sender, e);
                    }
                    else
                    {
                        saveToolStripMenuItem_Click(sender, e);
                    }
                }
                else rTextBox.Clear();
            }
        }
    }
}
