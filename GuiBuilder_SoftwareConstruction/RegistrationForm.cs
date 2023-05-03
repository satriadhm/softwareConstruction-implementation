namespace GuiBuilder_week2
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.labelPassword.Text == "12345678")
            {
                this.labelRegistered.Text = "You are registered, Mr. " + this.labelUsername.Text;
            }
        }

        private void buttonRegister_Click_1(object sender, EventArgs e)
        {
            if (this.textBoxPassword.Text == "12345678")
            {
                this.labelRegistered.Text = "You are registered, Mr. " + this.textBoxUsername.Text;
                this.labelRegistered.Location = new Point(495, 377);
            }
        }
    }
}