namespace Attendance
{
    partial class MarkAttendance
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SOSCareNumber = new System.Windows.Forms.TextBox();
            this.FullName = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.Absent = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.Button();
            this.Present = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SOS Care Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Full Name";
            // 
            // SOSCareNumber
            // 
            this.SOSCareNumber.Location = new System.Drawing.Point(112, 12);
            this.SOSCareNumber.Name = "SOSCareNumber";
            this.SOSCareNumber.Size = new System.Drawing.Size(143, 20);
            this.SOSCareNumber.TabIndex = 0;
            this.SOSCareNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReadOnly_KeyDown);
            // 
            // FullName
            // 
            this.FullName.Location = new System.Drawing.Point(112, 38);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(143, 20);
            this.FullName.TabIndex = 1;
            this.FullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReadOnly_KeyDown);
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(112, 64);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(143, 20);
            this.Address.TabIndex = 2;
            this.Address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReadOnly_KeyDown);
            // 
            // Absent
            // 
            this.Absent.Location = new System.Drawing.Point(15, 90);
            this.Absent.Name = "Absent";
            this.Absent.Size = new System.Drawing.Size(115, 25);
            this.Absent.TabIndex = 3;
            this.Absent.Text = "Absent";
            this.Absent.UseVisualStyleBackColor = true;
            this.Absent.Click += new System.EventHandler(this.Absent_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Location = new System.Drawing.Point(15, 121);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(240, 25);
            this.MainMenu.TabIndex = 5;
            this.MainMenu.Text = "Main Menu";
            this.MainMenu.UseVisualStyleBackColor = true;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // Present
            // 
            this.Present.Location = new System.Drawing.Point(140, 90);
            this.Present.Name = "Present";
            this.Present.Size = new System.Drawing.Size(115, 25);
            this.Present.TabIndex = 4;
            this.Present.Text = "Present";
            this.Present.UseVisualStyleBackColor = true;
            this.Present.Click += new System.EventHandler(this.Present_Click);
            // 
            // MarkAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 154);
            this.Controls.Add(this.Present);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.Absent);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.SOSCareNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MarkAttendance";
            this.Text = "Mark Attendance";
            this.Load += new System.EventHandler(this.MarkAttendance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SOSCareNumber;
        private System.Windows.Forms.TextBox FullName;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Button Absent;
        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.Button Present;
    }
}