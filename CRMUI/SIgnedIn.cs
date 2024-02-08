namespace CRMUI
{
    public partial class SIgnedIn : Form
    {
        public SIgnedIn()
        {
            InitializeComponent();
            ClientPanel.Visible = false;
            AdressPanel.Visible = false;
            toAddressBtn.Click += button1_Click;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            if (OPTION.SelectedItem == "CLIENT")
            {
                ClientPanel.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AdressPanel.Visible = !AdressPanel.Visible;
            ClientPanel.Visible = !ClientPanel.Visible;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ClientPanel.Visible = true;
            AdressPanel.Visible = !AdressPanel.Visible;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdressPanel.Visible = true;
            BalancePanel.Visible = !BalancePanel.Visible;
        }
    }
}