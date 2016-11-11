using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Attendance
{
    public partial class MarkAttendance : Form
    {
        int i = 0;
        Dictionary<string, bool> day = new Dictionary<string, bool>();
        static string todaysDate = DateTime.Now.DayOfWeek.ToString();
        List<ServiceUser> usersToday = new List<ServiceUser>();

        public MarkAttendance()
        {
            InitializeComponent();
        }
        private void MarkAttendance_Load(object sender, EventArgs e)
        {
            PopulateList();
            LoadUsers();
        }
        void PopulateList()
        {
            string today = DateTime.Now.DayOfWeek.ToString();
            switch (today)
            {
                case "Monday":
                    usersToday = Data.ServiceUsers.FindAll(s => s.Monday == true);
                    break;
                case "Tuesday":
                    usersToday = Data.ServiceUsers.FindAll(s => s.Tuesday == true);
                    break;
                case "Wednesday":
                    usersToday = Data.ServiceUsers.FindAll(s => s.Wednesday == true);
                    break;
                case "Thursday":
                    usersToday = Data.ServiceUsers.FindAll(s => s.Thursday == true);
                    break;
                case "Friday":
                    usersToday = Data.ServiceUsers.FindAll(s => s.Friday == true);
                    break;
            }
        }
        private void ReadOnly_KeyDown(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            return;
        }
        private void Absent_Click(object sender, EventArgs e)
        {
            Mark(false);
        }
        private void Present_Click(object sender, EventArgs e)
        {
            Mark(true);
        }
        private void Mark(bool isHere)
        {
            Data.Marks.Add(new Mark
            {
                Date   = DateTime.Today,
                ID     = usersToday[i].SOSCareNumber,
                IsHere = isHere});
            i++;
            LoadUsers();
        }
        void LoadUsers()
        {
            if (i > (usersToday.Count - 1))
            {
                i--;
                MessageBox.Show("Marked all service users");
                MainMenu();
            }
            else
            {
                SOSCareNumber.Text = usersToday[i].SOSCareNumber;
                FullName.Text      = usersToday[i].FirstName + " " + usersToday[i].LastName;
                Address.Text       = usersToday[i].Address;
            }
        }
        private void MainMenu_Click(object sender, EventArgs e)
        {
            MainMenu();
        }
        void MainMenu()
        {
            MainMenu frm = new MainMenu();
            frm.Show();
            this.Hide();
        }
    }
}
