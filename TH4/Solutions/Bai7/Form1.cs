namespace Bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double result = 0;
        string operationPerformed = string.Empty;
        private void btn_Click(object sender, EventArgs e)
        {
            if(txtbOutput.Text == "0" || entervalue)
            {
                txtbOutput.Text = string.Empty;
            }
            Button button =(Button)sender;
            txtbOutput.Text += button.Text;
        }
        private void operator_Click(object sender, EventArgs e)
        {
            if(result !=0) btnEqual.PerformClick();
            else result = double.Parse(txtbOutput.Text);
            Control clickedOperator = (Control)sender;
            operationPerformed = clickedOperator.Text;
            if(txtbOutput.Text != "0")
            {
                txtbTemp.Text = $"{result}{operationPerformed}";
                txtbOutput.Text = string.Empty;
            }

        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            txtbTemp.Text = $"{txtbTemp.Text}{txtbOutput.Text}=";
            if(txtbOutput.Text != string.Empty&&operationPerformed != string.Empty) 
            {
                if(txtbOutput.Text == "0") txtbTemp.Text = string.Empty;
                switch(operationPerformed)
                {
                    case "+":
                        txtbOutput.Text = (result + double.Parse(txtbOutput.Text)).ToString();
                        break;
                    case "-":
                        txtbOutput.Text = (result - double.Parse(txtbOutput.Text)).ToString();
                        break;
                    case "x":
                        txtbOutput.Text = (result * double.Parse(txtbOutput.Text)).ToString();
                        break;
                    case "/":
                        txtbOutput.Text = (result / double.Parse(txtbOutput.Text)).ToString();
                        break;
                }
                result = double.Parse(txtbOutput.Text);
                operationPerformed = string.Empty;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbTemp.Text =string.Empty;
            txtbOutput.Text = "0";
            result = 0;
            operationPerformed = "";
        }
    }
}
