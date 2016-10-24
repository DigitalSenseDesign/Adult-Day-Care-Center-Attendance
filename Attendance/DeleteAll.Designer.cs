namespace Attendance
{
    partial class DeleteAll
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
            this.SecurityPassword = new System.Windows.Forms.TextBox();
            this.Erase = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "WARNING. Clicking the button below will erase all data within the program. To do " +
    "this. Type \"Erase All Data\" in the text box and then select the button \"Erase Al" +
    "l Data\".";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SecurityPassword
            // 
            this.SecurityPassword.Location = new System.Drawing.Point(12, 51);
            this.SecurityPassword.Name = "SecurityPassword";
            this.SecurityPassword.Size = new System.Drawing.Size(260, 20);
            this.SecurityPassword.TabIndex = 0;
            this.SecurityPassword.TextChanged += new System.EventHandler(this.securityPass_TextChanged);
            // 
            // Erase
            // 
            this.Erase.Location = new System.Drawing.Point(12, 77);
            this.Erase.Name = "Erase";
            this.Erase.Size = new System.Drawing.Size(260, 40);
            this.Erase.TabIndex = 1;
            this.Erase.Text = "Erase All Data";
            this.Erase.UseVisualStyleBackColor = true;
            this.Erase.Click += new System.EventHandler(this.cmdErase_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Location = new System.Drawing.Point(12, 123);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(260, 40);
            this.MainMenu.TabIndex = 2;
            this.MainMenu.Text = "Main Menu";
            this.MainMenu.UseVisualStyleBackColor = true;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // DeleteAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 173);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.Erase);
            this.Controls.Add(this.SecurityPassword);
            this.Controls.Add(this.label1);
            this.Name = "DeleteAll";
            this.Text = "Delete All Data";
            this.Load += new System.EventHandler(this.DeleteAll_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SecurityPassword;
        private System.Windows.Forms.Button Erase;
        private System.Windows.Forms.Button MainMenu;
    }
}