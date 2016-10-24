namespace Attendance
{
    partial class ManageUsers
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
            this.MainMenu = new System.Windows.Forms.Button();
            this.EditUsers = new System.Windows.Forms.Button();
            this.AddUsers = new System.Windows.Forms.Button();
            this.DeleteUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Location = new System.Drawing.Point(12, 180);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(260, 50);
            this.MainMenu.TabIndex = 3;
            this.MainMenu.Text = "Main Menu";
            this.MainMenu.UseVisualStyleBackColor = true;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // EditUsers
            // 
            this.EditUsers.Location = new System.Drawing.Point(12, 68);
            this.EditUsers.Name = "EditUsers";
            this.EditUsers.Size = new System.Drawing.Size(260, 50);
            this.EditUsers.TabIndex = 1;
            this.EditUsers.Text = "Edit Users";
            this.EditUsers.UseVisualStyleBackColor = true;
            this.EditUsers.Click += new System.EventHandler(this.EditUsers_Click);
            // 
            // AddUsers
            // 
            this.AddUsers.Location = new System.Drawing.Point(12, 12);
            this.AddUsers.Name = "AddUsers";
            this.AddUsers.Size = new System.Drawing.Size(260, 50);
            this.AddUsers.TabIndex = 0;
            this.AddUsers.Text = "Add Users";
            this.AddUsers.UseVisualStyleBackColor = true;
            this.AddUsers.Click += new System.EventHandler(this.AddUsers_Click);
            // 
            // DeleteUsers
            // 
            this.DeleteUsers.Location = new System.Drawing.Point(12, 124);
            this.DeleteUsers.Name = "DeleteUsers";
            this.DeleteUsers.Size = new System.Drawing.Size(260, 50);
            this.DeleteUsers.TabIndex = 2;
            this.DeleteUsers.Text = "Delete Users";
            this.DeleteUsers.UseVisualStyleBackColor = true;
            this.DeleteUsers.Click += new System.EventHandler(this.DeleteUsers_Click);
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 238);
            this.Controls.Add(this.DeleteUsers);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.EditUsers);
            this.Controls.Add(this.AddUsers);
            this.Name = "ManageUsers";
            this.Text = "Manage Users";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.Button EditUsers;
        private System.Windows.Forms.Button AddUsers;
        private System.Windows.Forms.Button DeleteUsers;
    }
}