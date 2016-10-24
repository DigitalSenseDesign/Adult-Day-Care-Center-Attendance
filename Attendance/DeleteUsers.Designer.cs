namespace Attendance
{
    partial class DeleteUsers
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
            this.cmdMainMenu = new System.Windows.Forms.Button();
            this.DeleteRecord = new System.Windows.Forms.Button();
            this.LastName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.SOSCareNumber = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdMainMenu
            // 
            this.cmdMainMenu.Location = new System.Drawing.Point(15, 130);
            this.cmdMainMenu.Name = "cmdMainMenu";
            this.cmdMainMenu.Size = new System.Drawing.Size(247, 40);
            this.cmdMainMenu.TabIndex = 4;
            this.cmdMainMenu.Text = "Main Menu";
            this.cmdMainMenu.UseVisualStyleBackColor = true;
            this.cmdMainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // DeleteRecord
            // 
            this.DeleteRecord.Location = new System.Drawing.Point(15, 84);
            this.DeleteRecord.Name = "DeleteRecord";
            this.DeleteRecord.Size = new System.Drawing.Size(247, 40);
            this.DeleteRecord.TabIndex = 3;
            this.DeleteRecord.Text = "Delete Record";
            this.DeleteRecord.UseVisualStyleBackColor = true;
            this.DeleteRecord.Click += new System.EventHandler(this.DeleteRecord_Click);
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(112, 58);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(150, 20);
            this.LastName.TabIndex = 2;
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(111, 32);
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
            this.label10.TabIndex = 140;
            this.label10.Text = "SOS Care Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 129;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 128;
            this.label1.Text = "First Name";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SOSCareNumber
            // 
            this.SOSCareNumber.FormattingEnabled = true;
            this.SOSCareNumber.Location = new System.Drawing.Point(112, 6);
            this.SOSCareNumber.Name = "SOSCareNumber";
            this.SOSCareNumber.Size = new System.Drawing.Size(149, 21);
            this.SOSCareNumber.TabIndex = 0;
            this.SOSCareNumber.SelectedIndexChanged += new System.EventHandler(this.SOSCareNumber_SelectedIndexChanged);
            this.SOSCareNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SOSCareNumber_KeyPress);
            // 
            // DeleteUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 180);
            this.Controls.Add(this.SOSCareNumber);
            this.Controls.Add(this.cmdMainMenu);
            this.Controls.Add(this.DeleteRecord);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DeleteUsers";
            this.Text = "Delete Users";
            this.Load += new System.EventHandler(this.DeleteUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdMainMenu;
        private System.Windows.Forms.Button DeleteRecord;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox SOSCareNumber;
    }
}