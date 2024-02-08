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
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(227, 21);
            label1.TabIndex = 0;
            label1.Text = "WHAT DO YOU WANT TO DO";
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
            // 
            // DelBtn
            // 
            DelBtn.AccessibleName = "DELBtn";
            DelBtn.AccessibleRole = AccessibleRole.TitleBar;
            DelBtn.BackColor = SystemColors.ControlText;
            DelBtn.FlatStyle = FlatStyle.Flat;
            DelBtn.Location = new Point(12, 142);
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
            GetBtn.Location = new Point(12, 224);
            GetBtn.Name = "GetBtn";
            GetBtn.Size = new Size(106, 23);
            GetBtn.TabIndex = 4;
            GetBtn.Text = "GET";
            GetBtn.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "CLIENT", "BALANCE", "ADDRESS", "DOCUMENTATION" });
            comboBox1.Location = new Point(12, 48);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(GetBtn);
            Controls.Add(UpBtn);
            Controls.Add(DelBtn);
            Controls.Add(AddBtn);
            Controls.Add(label1);
            ForeColor = Color.Cornsilk;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "BANKCRM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button AddBtn;
        private Button DelBtn;
        private Button UpBtn;
        private Button GetBtn;
        private ComboBox comboBox1;
    }
}