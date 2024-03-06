using static System.Net.Mime.MediaTypeNames;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public class HoanDoi
        {
            int a, b;
            public HoanDoi(int ta, int tb)
            {
                a = ta;
                b = tb;
            }
            public void HoanVi(ref int a, ref int b) //Truyền tham chiếu
            {
                int temp = a;
                a = b;
                b = temp;
            }
        }

        public bool IsEmpty() //Kiểm tra trường dữ liệu a,b có đang trống
        {
            if(txta.Text.Length == 0 || txtb.Text.Length == 0)
                return true;
            return false;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if(!IsEmpty() ) 
                {
                    int a = Convert.ToInt32(txta.Text);
                    int b = Convert.ToInt32(txtb.Text);
                    HoanDoi DS = new HoanDoi(a, b);
                    DS.HoanVi(ref a, ref b);
                    txta.Text = a.ToString();
                    txtb.Text = b.ToString();
                }
                else
                {
                    MessageBox.Show("Không được để trống a, b");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Phải nhập a,b là kiểu số nguyên");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txta.Clear();
            txtb.Clear();
            txta.Focus();//Dịch chuyển con trỏ đến hộp txta
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);//Thoát chương trình
        }
    }
}
