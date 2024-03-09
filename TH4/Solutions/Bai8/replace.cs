namespace Bai8
{
    public partial class replace : Form
    {
        public string TextToFind { get; private set; }
        public string TextToReplaceWith { get; private set; }
        public replace()
        {
            InitializeComponent();
        }
        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (txtbFilter.Text != string.Empty)
            {
                TextToFind = txtbFilter.Text;
                TextToReplaceWith = txtbReplace.Text;
                this.DialogResult = DialogResult.OK; // Set the dialog result to OK
                this.Close(); // Close the form
            }
            else
            {
                MessageBox.Show("Không được bỏ trống Filter");
            }
        }
    }
}
