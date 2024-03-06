using System.Configuration;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> Prime = new List<int>();
        public bool isPrime(int x)
        {
            if (x <= 1)
                return false;
            else
                if (x == 2) return true;
            else
                    if (x % 2 == 0) return false;
            else for (int i = 3; i <= Math.Sqrt(x); i++)
                {
                    if (x % i == 0) return false;
                }
            return true;
        }
        public void Primes(List<int> Prime, int N)
        {
            for (int i = 1; i < N; i+=1)
            {
                if (isPrime(i))
                    Prime.Add(i);
            }
        }
        static bool isSoChinhPhuong(int y)
        {
            int temp = (int)Math.Sqrt(y);
            if (Math.Pow(temp, 2) == Math.Pow(Math.Sqrt(y), 2))
                return true;
            else return false;
        }
        static bool IsPerfectNumber(int number)
        {
            int sum = 0;

            // Calculate the sum of proper divisors
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }

            // Check if the sum of proper divisors equals the number
            return sum == number;
        }
        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtNum.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Không nhập đúng định dạng số nguyên");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Số nhập vào quá lớn");
            }
        }
        private void txtNum_Leave(object sender, EventArgs e)
        {
            int so = Convert.ToInt32(txtNum.Text);
            if (0 >= so || 1000 <= so)
            {
                txtNum.Focus();
                MessageBox.Show("Số nhập vào phải thỏa mãn 0 < Number < 1000");
            }

        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNum.Text);
            lblPrime.Text = "Các số nguyên tố nhỏ hơn n:";
            lblCP.Text = "Các số chính phương nhỏ hơn n:";
            lblPerfectnum.Text = "Các số hoàn chỉnh nhỏ hơn n:";
            //Kiểm tra số nguyên tố
            Primes(Prime, num);
            foreach(var nums in Prime)
            {
                lblPrime.Text += " " + nums;
            }
            //Kiểm tra số chính phương
            for(int i = 1;i < num; i++)
            {
                if(isSoChinhPhuong(i))
                    lblCP.Text += " " + i;
            }
            //Kiểm tra số hoàn hảo
            for(int i = 1;i < num; i++)
            {
                if(IsPerfectNumber(i))
                    lblPerfectnum.Text += " " + i;
            }
        }
    }
}
