namespace Attendance
{
    partial class Export
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
            this.FirstDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LastDate = new System.Windows.Forms.DateTimePicker();
            this.ExportBetweenRange = new System.Windows.Forms.Button();
            this.ExportAll = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.Button();
            this.ServiceUserDGV = new System.Windows.Forms.DataGridView();
            this.MarkDGV = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceUserDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarkDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstDate
            // 
            this.FirstDate.Location = new System.Drawing.Point(84, 12);
            this.FirstDate.Name = "FirstDate";
            this.FirstDate.Size = new System.Drawing.Size(131, 20);
            this.FirstDate.TabIndex = 0;
            this.FirstDate.ValueChanged += new System.EventHandler(this.DateValidation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Second Date";
            // 
            // LastDate
            // 
            this.LastDate.Location = new System.Drawing.Point(331, 12);
            this.LastDate.Name = "LastDate";
            this.LastDate.Size = new System.Drawing.Size(131, 20);
            this.LastDate.TabIndex = 1;
            this.LastDate.ValueChanged += new System.EventHandler(this.DateValidation_Click);
            // 
            // ExportBetweenRange
            // 
            this.ExportBetweenRange.Location = new System.Drawing.Point(12, 250);
            this.ExportBetweenRange.Name = "ExportBetweenRange";
            this.ExportBetweenRange.Size = new System.Drawing.Size(225, 50);
            this.ExportBetweenRange.TabIndex = 2;
            this.ExportBetweenRange.Text = "Data Between Dates";
            this.ExportBetweenRange.UseVisualStyleBackColor = true;
            this.ExportBetweenRange.Click += new System.EventHandler(this.ExportBetweenRange_Click);
            // 
            // ExportAll
            // 
            this.ExportAll.Location = new System.Drawing.Point(257, 250);
            this.ExportAll.Name = "ExportAll";
            this.ExportAll.Size = new System.Drawing.Size(235, 50);
            this.ExportAll.TabIndex = 3;
            this.ExportAll.Text = "All Data";
            this.ExportAll.UseVisualStyleBackColor = true;
            this.ExportAll.Click += new System.EventHandler(this.ExportAllData_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Location = new System.Drawing.Point(257, 306);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(235, 50);
            this.MainMenu.TabIndex = 4;
            this.MainMenu.Text = "Main Menu";
            this.MainMenu.UseVisualStyleBackColor = true;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // ServiceUserDGV
            // 
            this.ServiceUserDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceUserDGV.Location = new System.Drawing.Point(12, 38);
            this.ServiceUserDGV.Name = "ServiceUserDGV";
            this.ServiceUserDGV.Size = new System.Drawing.Size(480, 100);
            this.ServiceUserDGV.TabIndex = 7;
            // 
            // MarkDGV
            // 
            this.MarkDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MarkDGV.Location = new System.Drawing.Point(12, 144);
            this.MarkDGV.Name = "MarkDGV";
            this.MarkDGV.Size = new System.Drawing.Size(480, 100);
            this.MarkDGV.TabIndex = 8;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 365);
            this.Controls.Add(this.MarkDGV);
            this.Controls.Add(this.ServiceUserDGV);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.ExportAll);
            this.Controls.Add(this.ExportBetweenRange);
            this.Controls.Add(this.LastDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstDate);
            this.Name = "Export";
            this.Text = "Export Data";
            this.Load += new System.EventHandler(this.Export_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceUserDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarkDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker FirstDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker LastDate;
        private System.Windows.Forms.Button ExportBetweenRange;
        private System.Windows.Forms.Button ExportAll;
        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.DataGridView ServiceUserDGV;
        private System.Windows.Forms.DataGridView MarkDGV;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}