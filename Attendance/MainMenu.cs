using System;
using System.Windows.Forms;

namespace Attendance
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            if(global::Attendance.Data.ServiceUsers.Count == 0)
            {
                global::Attendance.Data.LoadAllData();
            }
        }
        private void ManageUsers_Click(object sender, EventArgs e)
        {
            ManageUsers frm = new ManageUsers();
            frm.Show();
            this.Hide();
        }
        private void Attendance_Click(object sender, EventArgs e)
        {
            if (global::Attendance.Data.HasData())
            {
                MarkAttendance frm = new MarkAttendance();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("No users recorded. Returning to Main Menu.");
            }
        }
        private void Data_Click(object sender, EventArgs e)
        {
            DataMenu frm = new DataMenu();
            frm.Show();
            this.Hide();
        }
        private void Quit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you wish to quit?", "Quit", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                global::Attendance.Data.SaveAllData();
                Application.Exit();
            }
        }
    }
}
