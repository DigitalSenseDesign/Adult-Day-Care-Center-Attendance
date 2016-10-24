using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Attendance
{
    public partial class MarkAttendance : Form
    {
        int i = 0;
        Dictionary<string, bool> Day = new Dictionary<string, bool>();
        static string todaysDate = DateTime.Now.DayOfWeek.ToString();
        List<ServiceUser> usersToday = new List<ServiceUser>();
        bool isDone;

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
            if (!isDone)
            {
                Mark(false);
            }
            else
            {
                MessageBox.Show("Marked all service users");
            }
        }
        private void Present_Click(object sender, EventArgs e)
        {
            if (!isDone)
            {
                Mark(true);
            }
            else
            {
                MessageBox.Show("Marked all service users");
            }
        }
        private void MainMenu_Click(object sender, EventArgs e)
        {
            MainMenu frm = new MainMenu();
            frm.Show();
            this.Hide();
        }

        private void Mark(bool isHere)
        {
            Data.AddMark(
                usersToday[i].SOSCareNumber,
                isHere
                );
            i++;
            LoadUsers();
        }
        void LoadUsers()
        {
            if (i > (usersToday.Count - 1))
            {
                i--;
                MessageBox.Show("Marked all service users");
                isDone = true;
                Clear();
            }
            else
            {
                SOSCareNumber.Text = usersToday[i].SOSCareNumber;
                FullName.Text      = usersToday[i].FirstName + " " + usersToday[i].LastName;
                Address.Text       = usersToday[i].Addess;
            }
        }
        void Clear()
        {
            SOSCareNumber.Text = "";
            FullName.Text = "";
            Address.Text = "";
        }
    }
}
