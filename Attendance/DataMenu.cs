using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance
{
    public partial class DataMenu : Form
    {
        public DataMenu()
        {
            InitializeComponent();
        }
        private void Import_Click(object sender, EventArgs e)
        {
            ImportData frm = new ImportData();
            frm.Show();
            this.Hide();
        }
        private void Export_Click(object sender, EventArgs e)
        {
            if (Data.HasData())
            {
                Export frm = new Export();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No users recorded. Returning to Main Menu.");
            }
        }
        private void cmdDeleteAll_Click(object sender, EventArgs e)
        {
            if (Data.HasData())
            {
                DeleteAll frm = new DeleteAll();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No users recorded. Returning to Main Menu.");
            }
        }
        private void MainMenu_Click(object sender, EventArgs e)
        {
            MainMenu frm = new MainMenu();
            frm.Show();
            this.Hide();
        }
    }
}
