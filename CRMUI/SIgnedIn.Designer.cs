namespace CRMUI
{
    partial class SIgnedIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SIgnedIn));
            label1 = new Label();
            AddBtn = new Button();
            DelBtn = new Button();
            UpBtn = new Button();
            GetBtn = new Button();
            OPTION = new ComboBox();
            ClientPanel = new Panel();
            AdressPanel = new Panel();
            button1 = new Button();
            label15 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label26 = new Label();
            label27 = new Label();
            button2 = new Button();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            toAddressBtn = new Button();
            WorkPhoneNumberInput = new TextBox();
            JobTitleInput = new TextBox();
            EmployerNameInput = new TextBox();
            EmailInput = new TextBox();
            PhoneNumberInput = new TextBox();
            IdPassportInput = new TextBox();
            PassportInput = new TextBox();
            GenderInput = new ComboBox();
            BirthInput = new DateTimePicker();
            LastNameInput = new TextBox();
            FirstNameInput = new TextBox();
            BalancePanel = new Panel();
            DocPanel = new Panel();
            label19 = new Label();
            btnUploadPDF = new Button();
            comboBox3 = new ComboBox();
            button7 = new Button();
            label17 = new Label();
            label18 = new Label();
            FileNamelbl = new Label();
            button8 = new Button();
            textBox1 = new TextBox();
            button5 = new Button();
            CurrencyBox = new ComboBox();
            button3 = new Button();
            label16 = new Label();
            label20 = new Label();
            label24 = new Label();
            button4 = new Button();
            BalanceText = new TextBox();
            button6 = new Button();
            checkMarried = new CheckBox();
            ClientPanel.SuspendLayout();
            AdressPanel.SuspendLayout();
            BalancePanel.SuspendLayout();
            DocPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(238, 21);
            label1.TabIndex = 0;
            label1.Text = "WHAT DO YOU WANT TO DO ?";
            // 
            // AddBtn
            // 
            AddBtn.AccessibleName = "AddBtn";
            AddBtn.AccessibleRole = AccessibleRole.TitleBar;
            AddBtn.BackColor = SystemColors.ControlText;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Location = new Point(12, 102);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(106, 23);
            AddBtn.TabIndex = 1;
            AddBtn.Text = "ADD";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // DelBtn
            // 
            DelBtn.AccessibleName = "DELBtn";
            DelBtn.AccessibleRole = AccessibleRole.TitleBar;
            DelBtn.BackColor = SystemColors.ControlText;
            DelBtn.FlatStyle = FlatStyle.Flat;
            DelBtn.Location = new Point(12, 219);
            DelBtn.Name = "DelBtn";
            DelBtn.Size = new Size(106, 23);
            DelBtn.TabIndex = 2;
            DelBtn.Text = "DELETE ";
            DelBtn.UseVisualStyleBackColor = false;
            // 
            // UpBtn
            // 
            UpBtn.AccessibleName = "UpBtn";
            UpBtn.AccessibleRole = AccessibleRole.TitleBar;
            UpBtn.BackColor = SystemColors.ControlText;
            UpBtn.FlatStyle = FlatStyle.Flat;
            UpBtn.Location = new Point(12, 184);
            UpBtn.Name = "UpBtn";
            UpBtn.Size = new Size(106, 23);
            UpBtn.TabIndex = 3;
            UpBtn.Text = "UPDATE ";
            UpBtn.UseVisualStyleBackColor = false;
            // 
            // GetBtn
            // 
            GetBtn.AccessibleName = "GetBtn";
            GetBtn.AccessibleRole = AccessibleRole.TitleBar;
            GetBtn.BackColor = SystemColors.ControlText;
            GetBtn.FlatStyle = FlatStyle.Flat;
            GetBtn.Location = new Point(12, 140);
            GetBtn.Name = "GetBtn";
            GetBtn.Size = new Size(106, 23);
            GetBtn.TabIndex = 4;
            GetBtn.Text = "GET";
            GetBtn.UseVisualStyleBackColor = false;
            // 
            // OPTION
            // 
            OPTION.FormattingEnabled = true;
            OPTION.Items.AddRange(new object[] { "CLIENT" });
            OPTION.Location = new Point(12, 48);
            OPTION.Name = "OPTION";
            OPTION.Size = new Size(133, 23);
            OPTION.TabIndex = 5;
            // 
            // ClientPanel
            // 
            ClientPanel.BackColor = Color.CornflowerBlue;
            ClientPanel.Controls.Add(DocPanel);
            ClientPanel.Controls.Add(BalancePanel);
            ClientPanel.Controls.Add(checkMarried);
            ClientPanel.Controls.Add(AdressPanel);
            ClientPanel.Controls.Add(label14);
            ClientPanel.Controls.Add(label13);
            ClientPanel.Controls.Add(label12);
            ClientPanel.Controls.Add(label11);
            ClientPanel.Controls.Add(label10);
            ClientPanel.Controls.Add(label9);
            ClientPanel.Controls.Add(label8);
            ClientPanel.Controls.Add(label7);
            ClientPanel.Controls.Add(label6);
            ClientPanel.Controls.Add(label5);
            ClientPanel.Controls.Add(label4);
            ClientPanel.Controls.Add(label3);
            ClientPanel.Controls.Add(label2);
            ClientPanel.Controls.Add(toAddressBtn);
            ClientPanel.Controls.Add(WorkPhoneNumberInput);
            ClientPanel.Controls.Add(JobTitleInput);
            ClientPanel.Controls.Add(EmployerNameInput);
            ClientPanel.Controls.Add(EmailInput);
            ClientPanel.Controls.Add(PhoneNumberInput);
            ClientPanel.Controls.Add(IdPassportInput);
            ClientPanel.Controls.Add(PassportInput);
            ClientPanel.Controls.Add(GenderInput);
            ClientPanel.Controls.Add(BirthInput);
            ClientPanel.Controls.Add(LastNameInput);
            ClientPanel.Controls.Add(FirstNameInput);
            ClientPanel.Location = new Point(245, 12);
            ClientPanel.Name = "ClientPanel";
            ClientPanel.Size = new Size(543, 438);
            ClientPanel.TabIndex = 6;
            // 
            // AdressPanel
            // 
            AdressPanel.BackColor = Color.CornflowerBlue;
            AdressPanel.Controls.Add(button1);
            AdressPanel.Controls.Add(label15);
            AdressPanel.Controls.Add(label21);
            AdressPanel.Controls.Add(label22);
            AdressPanel.Controls.Add(label23);
            AdressPanel.Controls.Add(label26);
            AdressPanel.Controls.Add(label27);
            AdressPanel.Controls.Add(button2);
            AdressPanel.Controls.Add(textBox5);
            AdressPanel.Controls.Add(textBox6);
            AdressPanel.Controls.Add(textBox7);
            AdressPanel.Controls.Add(textBox8);
            AdressPanel.Controls.Add(textBox9);
            AdressPanel.Location = new Point(0, 3);
            AdressPanel.Name = "AdressPanel";
            AdressPanel.Size = new Size(543, 435);
            AdressPanel.TabIndex = 30;
            // 
            // button1
            // 
            button1.BackColor = Color.Chartreuse;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkBlue;
            button1.Location = new Point(98, 274);
            button1.Name = "button1";
            button1.Size = new Size(92, 26);
            button1.TabIndex = 30;
            button1.Text = "PREVIOUS";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.DarkGreen;
            label15.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.DarkGoldenrod;
            label15.Location = new Point(130, 0);
            label15.Name = "label15";
            label15.Size = new Size(251, 32);
            label15.TabIndex = 29;
            label15.Text = "ADD INFORMATION ";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.Cornsilk;
            label21.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label21.ForeColor = Color.Crimson;
            label21.Location = new Point(10, 190);
            label21.Name = "label21";
            label21.Size = new Size(42, 17);
            label21.TabIndex = 23;
            label21.Text = "TITLE";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Cornsilk;
            label22.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.Crimson;
            label22.Location = new Point(10, 159);
            label22.Name = "label22";
            label22.Size = new Size(69, 17);
            label22.TabIndex = 22;
            label22.Text = "BUILDING";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = Color.Cornsilk;
            label23.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label23.ForeColor = Color.Crimson;
            label23.Location = new Point(10, 128);
            label23.Name = "label23";
            label23.Size = new Size(53, 17);
            label23.TabIndex = 21;
            label23.Text = "STREET";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.BackColor = Color.Cornsilk;
            label26.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label26.ForeColor = Color.Crimson;
            label26.Location = new Point(10, 92);
            label26.Name = "label26";
            label26.Size = new Size(36, 17);
            label26.TabIndex = 18;
            label26.Text = "CITY";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.BackColor = Color.Cornsilk;
            label27.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label27.ForeColor = Color.Crimson;
            label27.Location = new Point(10, 60);
            label27.Name = "label27";
            label27.Size = new Size(69, 17);
            label27.TabIndex = 17;
            label27.Text = "COUNTRY";
            // 
            // button2
            // 
            button2.BackColor = Color.Chartreuse;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkBlue;
            button2.Location = new Point(346, 274);
            button2.Name = "button2";
            button2.Size = new Size(99, 26);
            button2.TabIndex = 16;
            button2.Text = "NEXT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(99, 189);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(346, 23);
            textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(98, 158);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(347, 23);
            textBox6.TabIndex = 9;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(98, 122);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(347, 23);
            textBox7.TabIndex = 8;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(98, 89);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(347, 23);
            textBox8.TabIndex = 1;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(99, 60);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(347, 23);
            textBox9.TabIndex = 0;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.DarkGreen;
            label14.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.DarkGoldenrod;
            label14.Location = new Point(130, 0);
            label14.Name = "label14";
            label14.Size = new Size(251, 32);
            label14.TabIndex = 29;
            label14.Text = "ADD INFORMATION ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Cornsilk;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Crimson;
            label13.Location = new Point(8, 379);
            label13.Name = "label13";
            label13.Size = new Size(96, 17);
            label13.TabIndex = 28;
            label13.Text = "WORK PHONE";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Cornsilk;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Crimson;
            label12.Location = new Point(10, 350);
            label12.Name = "label12";
            label12.Size = new Size(70, 17);
            label12.TabIndex = 27;
            label12.Text = "JOB TITLE";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Cornsilk;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Crimson;
            label11.Location = new Point(10, 321);
            label11.Name = "label11";
            label11.Size = new Size(90, 17);
            label11.TabIndex = 26;
            label11.Text = "WORK PLACE";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Cornsilk;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Crimson;
            label10.Location = new Point(8, 293);
            label10.Name = "label10";
            label10.Size = new Size(116, 17);
            label10.TabIndex = 25;
            label10.Text = "MARRIED STATUS";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Cornsilk;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Crimson;
            label9.Location = new Point(10, 263);
            label9.Name = "label9";
            label9.Size = new Size(47, 17);
            label9.TabIndex = 24;
            label9.Text = "EMAIL";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Cornsilk;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Crimson;
            label8.Location = new Point(10, 235);
            label8.Name = "label8";
            label8.Size = new Size(53, 17);
            label8.TabIndex = 23;
            label8.Text = "PHONE";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Cornsilk;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Crimson;
            label7.Location = new Point(10, 206);
            label7.Name = "label7";
            label7.Size = new Size(90, 17);
            label7.TabIndex = 22;
            label7.Text = "ID PASSPORT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Cornsilk;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Crimson;
            label6.Location = new Point(10, 178);
            label6.Name = "label6";
            label6.Size = new Size(65, 17);
            label6.TabIndex = 21;
            label6.Text = "PASPORT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Cornsilk;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Crimson;
            label5.Location = new Point(10, 147);
            label5.Name = "label5";
            label5.Size = new Size(59, 17);
            label5.TabIndex = 20;
            label5.Text = "GENDER";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Cornsilk;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(10, 118);
            label4.Name = "label4";
            label4.Size = new Size(83, 17);
            label4.TabIndex = 19;
            label4.Text = "BIRTH DATE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Cornsilk;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(10, 89);
            label3.Name = "label3";
            label3.Size = new Size(81, 17);
            label3.TabIndex = 18;
            label3.Text = "LAST NAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Cornsilk;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(10, 60);
            label2.Name = "label2";
            label2.Size = new Size(84, 17);
            label2.TabIndex = 17;
            label2.Text = "FIRST NAME";
            // 
            // toAddressBtn
            // 
            toAddressBtn.BackColor = Color.Chartreuse;
            toAddressBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            toAddressBtn.ForeColor = Color.DarkBlue;
            toAddressBtn.Location = new Point(453, 400);
            toAddressBtn.Name = "toAddressBtn";
            toAddressBtn.Size = new Size(75, 26);
            toAddressBtn.TabIndex = 16;
            toAddressBtn.Text = "NEXT";
            toAddressBtn.UseVisualStyleBackColor = false;
            toAddressBtn.Click += button1_Click;
            // 
            // WorkPhoneNumberInput
            // 
            WorkPhoneNumberInput.Location = new Point(130, 379);
            WorkPhoneNumberInput.Name = "WorkPhoneNumberInput";
            WorkPhoneNumberInput.Size = new Size(315, 23);
            WorkPhoneNumberInput.TabIndex = 15;
            // 
            // JobTitleInput
            // 
            JobTitleInput.Location = new Point(106, 350);
            JobTitleInput.Name = "JobTitleInput";
            JobTitleInput.Size = new Size(339, 23);
            JobTitleInput.TabIndex = 14;
            // 
            // EmployerNameInput
            // 
            EmployerNameInput.Location = new Point(106, 321);
            EmployerNameInput.Name = "EmployerNameInput";
            EmployerNameInput.Size = new Size(339, 23);
            EmployerNameInput.TabIndex = 13;
            // 
            // EmailInput
            // 
            EmailInput.Location = new Point(98, 263);
            EmailInput.Name = "EmailInput";
            EmailInput.Size = new Size(347, 23);
            EmailInput.TabIndex = 11;
            // 
            // PhoneNumberInput
            // 
            PhoneNumberInput.Location = new Point(130, 234);
            PhoneNumberInput.Name = "PhoneNumberInput";
            PhoneNumberInput.Size = new Size(315, 23);
            PhoneNumberInput.TabIndex = 10;
            // 
            // IdPassportInput
            // 
            IdPassportInput.Location = new Point(130, 205);
            IdPassportInput.Name = "IdPassportInput";
            IdPassportInput.Size = new Size(315, 23);
            IdPassportInput.TabIndex = 9;
            // 
            // PassportInput
            // 
            PassportInput.Location = new Point(130, 176);
            PassportInput.Name = "PassportInput";
            PassportInput.Size = new Size(316, 23);
            PassportInput.TabIndex = 8;
            // 
            // GenderInput
            // 
            GenderInput.FormattingEnabled = true;
            GenderInput.Items.AddRange(new object[] { "MALE", "FEMALE" });
            GenderInput.Location = new Point(133, 147);
            GenderInput.Name = "GenderInput";
            GenderInput.Size = new Size(111, 23);
            GenderInput.TabIndex = 7;
            // 
            // BirthInput
            // 
            BirthInput.Location = new Point(98, 118);
            BirthInput.Name = "BirthInput";
            BirthInput.Size = new Size(347, 23);
            BirthInput.TabIndex = 2;
            // 
            // LastNameInput
            // 
            LastNameInput.Location = new Point(98, 89);
            LastNameInput.Name = "LastNameInput";
            LastNameInput.Size = new Size(347, 23);
            LastNameInput.TabIndex = 1;
            // 
            // FirstNameInput
            // 
            FirstNameInput.AcceptsReturn = true;
            FirstNameInput.Location = new Point(99, 60);
            FirstNameInput.Name = "FirstNameInput";
            FirstNameInput.Size = new Size(347, 23);
            FirstNameInput.TabIndex = 0;
            // 
            // BalancePanel
            // 
            BalancePanel.BackColor = Color.CornflowerBlue;
            BalancePanel.Controls.Add(button5);
            BalancePanel.Controls.Add(CurrencyBox);
            BalancePanel.Controls.Add(button3);
            BalancePanel.Controls.Add(label16);
            BalancePanel.Controls.Add(label20);
            BalancePanel.Controls.Add(label24);
            BalancePanel.Controls.Add(button4);
            BalancePanel.Controls.Add(BalanceText);
            BalancePanel.Location = new Point(3, 3);
            BalancePanel.Name = "BalancePanel";
            BalancePanel.Size = new Size(543, 435);
            BalancePanel.TabIndex = 31;
            // 
            // DocPanel
            // 
            DocPanel.BackColor = Color.CornflowerBlue;
            DocPanel.Controls.Add(label19);
            DocPanel.Controls.Add(btnUploadPDF);
            DocPanel.Controls.Add(comboBox3);
            DocPanel.Controls.Add(button7);
            DocPanel.Controls.Add(label17);
            DocPanel.Controls.Add(label18);
            DocPanel.Controls.Add(FileNamelbl);
            DocPanel.Controls.Add(button8);
            DocPanel.Controls.Add(textBox1);
            DocPanel.Location = new Point(3, 3);
            DocPanel.Name = "DocPanel";
            DocPanel.Size = new Size(543, 435);
            DocPanel.TabIndex = 32;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Cornsilk;
            label19.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.Crimson;
            label19.Location = new Point(12, 159);
            label19.Name = "label19";
            label19.Size = new Size(159, 20);
            label19.TabIndex = 33;
            label19.Text = "UPLOAD DOCUMENT";
            label19.Click += label19_Click;
            // 
            // btnUploadPDF
            // 
            btnUploadPDF.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnUploadPDF.ForeColor = Color.DarkBlue;
            btnUploadPDF.Location = new Point(201, 118);
            btnUploadPDF.Name = "btnUploadPDF";
            btnUploadPDF.Size = new Size(108, 26);
            btnUploadPDF.TabIndex = 32;
            btnUploadPDF.Text = "Upload (PDF)";
            btnUploadPDF.UseVisualStyleBackColor = true;
            btnUploadPDF.Click += btnUploadPDF_Click_1;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "PASSPORT", "ID CARD", "SOCIAL CARD", "OTHER" });
            comboBox3.Location = new Point(201, 156);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(108, 23);
            comboBox3.TabIndex = 7;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // button7
            // 
            button7.BackColor = Color.Chartreuse;
            button7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.DarkBlue;
            button7.Location = new Point(12, 382);
            button7.Name = "button7";
            button7.Size = new Size(92, 26);
            button7.TabIndex = 30;
            button7.Text = "PREVIOUS";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.DarkGreen;
            label17.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.DarkGoldenrod;
            label17.Location = new Point(130, 0);
            label17.Name = "label17";
            label17.Size = new Size(251, 32);
            label17.TabIndex = 29;
            label17.Text = "ADD INFORMATION ";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Cornsilk;
            label18.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.Crimson;
            label18.Location = new Point(12, 120);
            label18.Name = "label18";
            label18.Size = new Size(159, 20);
            label18.TabIndex = 18;
            label18.Text = "UPLOAD DOCUMENT";
            // 
            // FileNamelbl
            // 
            FileNamelbl.AutoSize = true;
            FileNamelbl.BackColor = Color.Cornsilk;
            FileNamelbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            FileNamelbl.ForeColor = Color.Crimson;
            FileNamelbl.Location = new Point(12, 90);
            FileNamelbl.Name = "FileNamelbl";
            FileNamelbl.Size = new Size(128, 20);
            FileNamelbl.TabIndex = 17;
            FileNamelbl.Text = "Document Name";
            // 
            // button8
            // 
            button8.BackColor = Color.Chartreuse;
            button8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.DarkBlue;
            button8.Location = new Point(407, 382);
            button8.Name = "button8";
            button8.Size = new Size(99, 26);
            button8.TabIndex = 16;
            button8.Text = "NEXT";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(160, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(149, 23);
            textBox1.TabIndex = 0;
            // 
            // button5
            // 
            button5.BackColor = Color.Chocolate;
            button5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.DarkBlue;
            button5.Location = new Point(138, 201);
            button5.Name = "button5";
            button5.Size = new Size(232, 26);
            button5.TabIndex = 31;
            button5.Text = "ADD ANOTHER CURRENCY";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // CurrencyBox
            // 
            CurrencyBox.FormattingEnabled = true;
            CurrencyBox.Items.AddRange(new object[] { "AMD", "USD", "EUR", "RUR", "CRYPTO" });
            CurrencyBox.Location = new Point(168, 119);
            CurrencyBox.Name = "CurrencyBox";
            CurrencyBox.Size = new Size(86, 23);
            CurrencyBox.TabIndex = 7;
            // 
            // button3
            // 
            button3.BackColor = Color.Chartreuse;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.DarkBlue;
            button3.Location = new Point(34, 266);
            button3.Name = "button3";
            button3.Size = new Size(92, 26);
            button3.TabIndex = 30;
            button3.Text = "PREVIOUS";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.DarkGreen;
            label16.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.DarkGoldenrod;
            label16.Location = new Point(106, -2);
            label16.Name = "label16";
            label16.Size = new Size(251, 32);
            label16.TabIndex = 29;
            label16.Text = "ADD INFORMATION ";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Cornsilk;
            label20.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.Crimson;
            label20.Location = new Point(12, 120);
            label20.Name = "label20";
            label20.Size = new Size(149, 20);
            label20.TabIndex = 18;
            label20.Text = "CHOOSE CURRENCY";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.BackColor = Color.Cornsilk;
            label24.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label24.ForeColor = Color.Crimson;
            label24.Location = new Point(12, 164);
            label24.Name = "label24";
            label24.Size = new Size(150, 20);
            label24.TabIndex = 17;
            label24.Text = "BALANCE AMOUNT";
            // 
            // button4
            // 
            button4.BackColor = Color.Chartreuse;
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.DarkBlue;
            button4.Location = new Point(339, 266);
            button4.Name = "button4";
            button4.Size = new Size(99, 26);
            button4.TabIndex = 16;
            button4.Text = "SAVE";
            button4.UseVisualStyleBackColor = false;
            // 
            // BalanceText
            // 
            BalanceText.Location = new Point(168, 164);
            BalanceText.Name = "BalanceText";
            BalanceText.Size = new Size(327, 23);
            BalanceText.TabIndex = 0;
            // 
            // button6
            // 
            button6.BackColor = Color.Crimson;
            button6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.DarkOrange;
            button6.Location = new Point(12, 412);
            button6.Name = "button6";
            button6.Size = new Size(92, 26);
            button6.TabIndex = 32;
            button6.Text = "LOG  OUT";
            button6.UseVisualStyleBackColor = false;
            // 
            // checkMarried
            // 
            checkMarried.AutoSize = true;
            checkMarried.BackColor = Color.DarkBlue;
            checkMarried.Location = new Point(130, 292);
            checkMarried.Name = "checkMarried";
            checkMarried.Size = new Size(111, 19);
            checkMarried.TabIndex = 31;
            checkMarried.Text = "check if married";
            checkMarried.UseVisualStyleBackColor = false;
            // 
            // SIgnedIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(ClientPanel);
            Controls.Add(OPTION);
            Controls.Add(GetBtn);
            Controls.Add(UpBtn);
            Controls.Add(DelBtn);
            Controls.Add(AddBtn);
            Controls.Add(label1);
            ForeColor = Color.Cornsilk;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SIgnedIn";
            Text = "BANKCRM";
            Load += SIgnedIn_Load;
            ClientPanel.ResumeLayout(false);
            ClientPanel.PerformLayout();
            AdressPanel.ResumeLayout(false);
            AdressPanel.PerformLayout();
            BalancePanel.ResumeLayout(false);
            BalancePanel.PerformLayout();
            DocPanel.ResumeLayout(false);
            DocPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button AddBtn;
        private Button DelBtn;
        private Button UpBtn;
        private Button GetBtn;
        private ComboBox OPTION;
        private Panel ClientPanel;
        private TextBox LastName;
        private TextBox FirstName;
        private TextBox WorkPhoneNumber;
        private TextBox JobTitle;
        private TextBox EmployerName;
        private ComboBox IsMaried;
        private TextBox Email;
        private TextBox PhoneNumber;
        private TextBox IdPassport;
        private TextBox Passport;
        private ComboBox comboBox2;
        private DateTimePicker Birth;
        private Button toAddressBtn;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label14;
        private Panel AdressPanel;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label26;
        private Label label27;
        private Button button2;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private Label label15;
        private Button button1;
        private Panel BalancePanel;
        private Button button3;
        private Label label16;
        private Label label20;
        private Label label24;
        private Button button4;
        private TextBox BalanceText;
        private ComboBox CurrencyBox;
        private Button button5;
        private Panel DocPanel;
        private ComboBox comboBox3;
        private Button button7;
        private Label label17;
        private Label label18;
        private Label FileNamelbl;
        private Button button8;
        private TextBox textBox1;
        private Button btnUploadPDF;
        private Label label19;
        private Button button6;
        private ComboBox BirthDate;
        private TextBox WorkPhoneNumberInput;
        private TextBox JobTitleInput;
        private TextBox EmployerNameInput;
        private TextBox EmailInput;
        private TextBox PhoneNumberInput;
        private TextBox IdPassportInput;
        private TextBox PassportInput;
        private ComboBox GenderInput;
        private DateTimePicker BirthInput;
        private TextBox LastNameInput;
        private TextBox FirstNameInput;
        private CheckBox checkMarried;
    }
}