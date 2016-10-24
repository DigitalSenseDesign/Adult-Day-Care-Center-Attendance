namespace Attendance
{
    partial class MainMenu
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
            this.Quit = new System.Windows.Forms.Button();
            this.Attendance = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.Button();
            this.ManageUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(12, 180);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(260, 50);
            this.Quit.TabIndex = 3;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Attendance
            // 
            this.Attendance.Location = new System.Drawing.Point(12, 68);
            this.Attendance.Name = "Attendance";
            this.Attendance.Size = new System.Drawing.Size(260, 50);
            this.Attendance.TabIndex = 1;
            this.Attendance.Text = "Attendance";
            this.Attendance.UseVisualStyleBackColor = true;
            this.Attendance.Click += new System.EventHandler(this.Attendance_Click);
            // 
            // Data
            // 
            this.Data.Location = new System.Drawing.Point(12, 124);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(260, 50);
            this.Data.TabIndex = 2;
            this.Data.Text = "Data";
            this.Data.UseVisualStyleBackColor = true;
            this.Data.Click += new System.EventHandler(this.Data_Click);
            // 
            // ManageUsers
            // 
            this.ManageUsers.Location = new System.Drawing.Point(12, 12);
            this.ManageUsers.Name = "ManageUsers";
            this.ManageUsers.Size = new System.Drawing.Size(260, 50);
            this.ManageUsers.TabIndex = 0;
            this.ManageUsers.Text = "ManageUsers";
            this.ManageUsers.UseVisualStyleBackColor = true;
            this.ManageUsers.Click += new System.EventHandler(this.ManageUsers_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 238);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Attendance);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.ManageUsers);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Button Attendance;
        private System.Windows.Forms.Button Data;
        private System.Windows.Forms.Button ManageUsers;
    }
}

