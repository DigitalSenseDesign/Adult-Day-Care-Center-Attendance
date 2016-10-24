namespace Attendance
{
    partial class ImportData
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
            this.FileLocation = new System.Windows.Forms.TextBox();
            this.SetFileLocation = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Import = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Location : ";
            // 
            // FileLocation
            // 
            this.FileLocation.Location = new System.Drawing.Point(95, 12);
            this.FileLocation.Name = "FileLocation";
            this.FileLocation.Size = new System.Drawing.Size(328, 20);
            this.FileLocation.TabIndex = 0;
            // 
            // SetFileLocation
            // 
            this.SetFileLocation.Location = new System.Drawing.Point(429, 12);
            this.SetFileLocation.Name = "SetFileLocation";
            this.SetFileLocation.Size = new System.Drawing.Size(100, 40);
            this.SetFileLocation.TabIndex = 1;
            this.SetFileLocation.Text = "Set File Location";
            this.SetFileLocation.UseVisualStyleBackColor = true;
            this.SetFileLocation.Click += new System.EventHandler(this.cmdSetFileLocation_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(16, 58);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(513, 363);
            this.dataGridView.TabIndex = 2;
            // 
            // Import
            // 
            this.Import.Location = new System.Drawing.Point(323, 427);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(100, 40);
            this.Import.TabIndex = 2;
            this.Import.Text = "Import Data";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.cmdImport_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Location = new System.Drawing.Point(429, 427);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(100, 40);
            this.MainMenu.TabIndex = 3;
            this.MainMenu.Text = "Main Menu";
            this.MainMenu.UseVisualStyleBackColor = true;
            this.MainMenu.Click += new System.EventHandler(this.cmdMainMenu_Click);
            // 
            // ImportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 479);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.SetFileLocation);
            this.Controls.Add(this.FileLocation);
            this.Controls.Add(this.label1);
            this.Name = "ImportData";
            this.Text = "Import Data";
            this.Load += new System.EventHandler(this.Import_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FileLocation;
        private System.Windows.Forms.Button SetFileLocation;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.Button MainMenu;
    }
}