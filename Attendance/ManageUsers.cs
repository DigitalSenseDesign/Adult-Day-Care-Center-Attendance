using System;
using System.Windows.Forms;

namespace Attendance
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }
        private void AddUsers_Click(object sender, EventArgs e)
        {
            AddUsers frm = new AddUsers();
            frm.Show();
            this.Hide();
        }
        private void EditUsers_Click(object sender, EventArgs e)
        {
            if (Data.HasData())
            {
                EditUsers frm = new EditUsers();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No users recorded. Returning to Main Menu.");
            }
        }
        private void DeleteUsers_Click(object sender, EventArgs e)
        {
            if (Data.HasData())
            {
                DeleteUsers frm = new DeleteUsers();
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
