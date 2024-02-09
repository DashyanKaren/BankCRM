using BankCRM.Models;
using BankCRM.Repository;

namespace CRMUI
{
    public partial class SIgnedIn : Form
    {
        public SIgnedIn()
        {
            InitializeComponent();
            ClientPanel.Visible = false;
            AdressPanel.Visible = false;
            BalancePanel.Visible = false;
            DocPanel.Visible = false;
            DelBtn.Visible = false;
            UpBtn.Visible = false;
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
            string conn = "Server=localhost\\MSSQLSERVER01;Database=master;Trusted_Connection=True;";
            DbManager dbManager = new DbManager(conn);
            GenericDAL genericDAL = new GenericDAL(dbManager);
            ClientsDto clientsDto = new ClientsDto();
            try
            {
              


                clientsDto.FirstName = FirstNameInput.Text;
                clientsDto.LastName = LastNameInput.Text;
                clientsDto.DateOfBirth = BirthInput.Value;
                clientsDto.Gender = GenderInput.Text;
                clientsDto.PassportNumber = PassportInput.Text;
                clientsDto.IDPassport = IdPassportInput.Text;
                clientsDto.PhoneNumber = PhoneNumberInput.Text;
                clientsDto.Email = EmailInput.Text;
                clientsDto.EmployerName = EmployerNameInput.Text;
                clientsDto.WorkPhoneNumber = WorkPhoneNumberInput.Text;
                clientsDto.JobTitle = JobTitleInput.Text;
                clientsDto.IsMaried = checkMarried.Checked;

                    
                
                genericDAL.AddEntity(clientsDto);   
                AdressPanel.Visible = !AdressPanel.Visible;
                ClientPanel.Visible = !ClientPanel.Visible;
            }
            catch (Exception)
            {

                throw;
            }
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
            DocPanel.Visible = true;
            BalancePanel.Visible = !BalancePanel.Visible;
        }
        private void btnUploadPDF_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
                openFileDialog.Title = "Select a PDF File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    string pdfPath = openFileDialog.FileName;


                }
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {
            BalancePanel.Visible = true;
            DocPanel.Visible = !DocPanel.Visible;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            BalancePanel.Visible = true;
            BalancePanel.Visible = true;
            BalancePanel.Visible = !AdressPanel.Visible;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DocPanel.Visible = true;
            AdressPanel.Visible = !AdressPanel.Visible;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdressPanel.Visible = true;
            DocPanel.Visible = !DocPanel.Visible;
        }

        private void btnUploadPDF_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
                openFileDialog.Title = "Select a PDF File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string pdfPath = openFileDialog.FileName;


                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void SIgnedIn_Load(object sender, EventArgs e)
        {

        }
    }
}