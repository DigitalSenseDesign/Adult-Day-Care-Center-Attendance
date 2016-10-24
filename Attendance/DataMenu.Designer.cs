namespace Attendance
{
    partial class DataMenu
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
            this.Export = new System.Windows.Forms.Button();
            this.Import = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.Button();
            this.DeleteAllData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(12, 68);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(260, 50);
            this.Export.TabIndex = 1;
            this.Export.Text = "Export Data";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Import
            // 
            this.Import.Location = new System.Drawing.Point(12, 12);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(260, 50);
            this.Import.TabIndex = 0;
            this.Import.Text = "Import Data";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
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
            // DeleteAllData
            // 
            this.DeleteAllData.Location = new System.Drawing.Point(12, 124);
            this.DeleteAllData.Name = "DeleteAllData";
            this.DeleteAllData.Size = new System.Drawing.Size(260, 50);
            this.DeleteAllData.TabIndex = 2;
            this.DeleteAllData.Text = "Erase All Data";
            this.DeleteAllData.UseVisualStyleBackColor = true;
            this.DeleteAllData.Click += new System.EventHandler(this.cmdDeleteAll_Click);
            // 
            // DataMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 243);
            this.Controls.Add(this.DeleteAllData);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.Export);
            this.Name = "DataMenu";
            this.Text = "Data Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.Button DeleteAllData;
    }
}