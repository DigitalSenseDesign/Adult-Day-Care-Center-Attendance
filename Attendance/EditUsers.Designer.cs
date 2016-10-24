namespace Attendance
{
    partial class EditUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ModifyRecord = new System.Windows.Forms.Button();
            this.ProgramOfCare = new System.Windows.Forms.ComboBox();
            this.Transport = new System.Windows.Forms.ComboBox();
            this.DOB = new System.Windows.Forms.DateTimePicker();
            this.Friday = new System.Windows.Forms.CheckBox();
            this.Thursday = new System.Windows.Forms.CheckBox();
            this.Wednesday = new System.Windows.Forms.CheckBox();
            this.Tuesday = new System.Windows.Forms.CheckBox();
            this.Monday = new System.Windows.Forms.CheckBox();
            this.PostCode = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MainMenu = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.SOSCareNumber = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ModifyRecord
            // 
            this.ModifyRecord.Location = new System.Drawing.Point(15, 349);
            this.ModifyRecord.Name = "ModifyRecord";
            this.ModifyRecord.Size = new System.Drawing.Size(247, 40);
            this.ModifyRecord.TabIndex = 13;
            this.ModifyRecord.Text = "Modify Record";
            this.ModifyRecord.UseVisualStyleBackColor = true;
            this.ModifyRecord.Click += new System.EventHandler(this.ModifyRecord_Click);
            // 
            // ProgramOfCare
            // 
            this.ProgramOfCare.FormattingEnabled = true;
            this.ProgramOfCare.Items.AddRange(new object[] {
            "PD - Physical Disability",
            "OP - Old Person",
            "MH - Mental Health",
            "MHOP - Mental Health Old Person",
            "D - Dementia",
            "LD - Learning Disability"});
            this.ProgramOfCare.Location = new System.Drawing.Point(112, 162);
            this.ProgramOfCare.Name = "ProgramOfCare";
            this.ProgramOfCare.Size = new System.Drawing.Size(150, 21);
            this.ProgramOfCare.TabIndex = 6;
            this.ProgramOfCare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReadOnly_KeyPress);
            // 
            // Transport
            // 
            this.Transport.FormattingEnabled = true;
            this.Transport.Items.AddRange(new object[] {
            "MINIBUS",
            "TAXI",
            "OWN"});
            this.Transport.Location = new System.Drawing.Point(112, 188);
            this.Transport.Name = "Transport";
            this.Transport.Size = new System.Drawing.Size(150, 21);
            this.Transport.TabIndex = 7;
            this.Transport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReadOnly_KeyPress);
            // 
            // DOB
            // 
            this.DOB.Location = new System.Drawing.Point(112, 84);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(150, 20);
            this.DOB.TabIndex = 3;
            // 
            // Friday
            // 
            this.Friday.Location = new System.Drawing.Point(187, 318);
            this.Friday.Name = "Friday";
            this.Friday.Size = new System.Drawing.Size(75, 20);
            this.Friday.TabIndex = 12;
            this.Friday.UseVisualStyleBackColor = true;
            // 
            // Thursday
            // 
            this.Thursday.Location = new System.Drawing.Point(187, 292);
            this.Thursday.Name = "Thursday";
            this.Thursday.Size = new System.Drawing.Size(75, 20);
            this.Thursday.TabIndex = 11;
            this.Thursday.UseVisualStyleBackColor = true;
            // 
            // Wednesday
            // 
            this.Wednesday.Location = new System.Drawing.Point(187, 266);
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.Size = new System.Drawing.Size(75, 20);
            this.Wednesday.TabIndex = 10;
            this.Wednesday.UseVisualStyleBackColor = true;
            // 
            // Tuesday
            // 
            this.Tuesday.Location = new System.Drawing.Point(187, 240);
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.Size = new System.Drawing.Size(75, 20);
            this.Tuesday.TabIndex = 9;
            this.Tuesday.UseVisualStyleBackColor = true;
            // 
            // Monday
            // 
            this.Monday.Location = new System.Drawing.Point(187, 215);
            this.Monday.Name = "Monday";
            this.Monday.Size = new System.Drawing.Size(75, 20);
            this.Monday.TabIndex = 8;
            this.Monday.UseVisualStyleBackColor = true;
            // 
            // PostCode
            // 
            this.PostCode.Location = new System.Drawing.Point(112, 136);
            this.PostCode.Name = "PostCode";
            this.PostCode.Size = new System.Drawing.Size(150, 20);
            this.PostCode.TabIndex = 5;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(112, 58);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(150, 20);
            this.LastName.TabIndex = 2;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(112, 110);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(150, 20);
            this.Address.TabIndex = 4;
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(112, 32);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(150, 20);
            this.FirstName.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 109;
            this.label10.Text = "SOS Care Number";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 296);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 108;
            this.label13.Text = "Thursday";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 321);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 107;
            this.label12.Text = "Friday";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 106;
            this.label11.Text = "Tuesday";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 105;
            this.label9.Text = "Wednesday";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 104;
            this.label8.Text = "Monday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 103;
            this.label7.Text = "Transport";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 102;
            this.label6.Text = "Program Of Care";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 101;
            this.label5.Text = "Post Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 100;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 99;
            this.label3.Text = "Date Of Birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 98;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 97;
            this.label1.Text = "First Name";
            // 
            // MainMenu
            // 
            this.MainMenu.Location = new System.Drawing.Point(15, 395);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(247, 40);
            this.MainMenu.TabIndex = 14;
            this.MainMenu.Text = "Main Menu";
            this.MainMenu.UseVisualStyleBackColor = true;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SOSCareNumber
            // 
            this.SOSCareNumber.FormattingEnabled = true;
            this.SOSCareNumber.Location = new System.Drawing.Point(113, 6);
            this.SOSCareNumber.Name = "SOSCareNumber";
            this.SOSCareNumber.Size = new System.Drawing.Size(149, 21);
            this.SOSCareNumber.TabIndex = 0;
            this.SOSCareNumber.SelectedIndexChanged += new System.EventHandler(this.SOSCareNumber_SelectedIndexChanged);
            // 
            // EditUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 442);
            this.Controls.Add(this.SOSCareNumber);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.ModifyRecord);
            this.Controls.Add(this.ProgramOfCare);
            this.Controls.Add(this.Transport);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.Friday);
            this.Controls.Add(this.Thursday);
            this.Controls.Add(this.Wednesday);
            this.Controls.Add(this.Tuesday);
            this.Controls.Add(this.Monday);
            this.Controls.Add(this.PostCode);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditUsers";
            this.Text = "Edit Users";
            this.Load += new System.EventHandler(this.EditUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ModifyRecord;
        private System.Windows.Forms.ComboBox ProgramOfCare;
        private System.Windows.Forms.ComboBox Transport;
        private System.Windows.Forms.DateTimePicker DOB;
        private System.Windows.Forms.CheckBox Friday;
        private System.Windows.Forms.CheckBox Thursday;
        private System.Windows.Forms.CheckBox Wednesday;
        private System.Windows.Forms.CheckBox Tuesday;
        private System.Windows.Forms.CheckBox Monday;
        private System.Windows.Forms.TextBox PostCode;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox SOSCareNumber;
    }
}