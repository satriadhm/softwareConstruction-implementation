namespace modul3_1302213015
{
    
    public partial class Addition_Calc : Form
    {
        int finalRes = 0;
        public Addition_Calc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.result.Text += "1";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            this.result.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            this.result.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            this.result.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            this.result.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.result.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.result.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.result.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.result.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        { 
            this.result.Text += "0";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            int sum = int.Parse(this.result.Text);
            finalRes = finalRes + sum;
            this.result.Text = "";
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            int sum = int.Parse(this.result.Text);
            finalRes = finalRes + sum;
            this.result.Text = finalRes.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.result.Text = "";
            finalRes = 0;   
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            this.result.Text += "0";
        }
    }
}