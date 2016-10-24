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
    public partial class DeleteUsers : Form
    {
        public DeleteUsers()
        {
            InitializeComponent();
        }
        private void SOSCareNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateName();
        }
        private void DeleteUsers_Load(object sender, EventArgs e)
        {
            UpdateList();
        }
        void UpdateList()
        {
            SOSCareNumber.Items.Clear();
            foreach (var ServiceUser in Data.ServiceUsers)
            {
                SOSCareNumber.Items.Add(ServiceUser.SOSCareNumber);
            }
        }
        void UpdateName()
        {
            FirstName.Text = Data.ServiceUsers[SOSCareNumber.SelectedIndex].FirstName;
            LastName.Text = Data.ServiceUsers[SOSCareNumber.SelectedIndex].LastName;
        }
        private void SOSCareNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void DeleteRecord_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you wish to delete the current record?", "Delete Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Data.ServiceUsers.RemoveAt(SOSCareNumber.SelectedIndex);
                MessageBox.Show("Record Deleted");

                UpdateList();
                if (SOSCareNumber.Items.Count > 0)
                {
                    SOSCareNumber.SelectedIndex = 0;
                    UpdateName();
                }
                else
                {
                    MessageBox.Show("No users left to display. Returning to Main Menu");
                    MainMenu frm = new MainMenu();
                    frm.Show();
                    this.Hide();
                }
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
