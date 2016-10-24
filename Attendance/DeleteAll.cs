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
    public partial class DeleteAll : Form
    {
        public DeleteAll()
        {
            InitializeComponent();
        }

        private void securityPass_TextChanged(object sender, EventArgs e)
        {
            if(SecurityPassword.Text == "Erase All Data")
            {
                Erase.Enabled = true;
            }
        }

        private void cmdErase_Click(object sender, EventArgs e)
        {
            Data.ServiceUsers.Clear();
            Data.Marks.Clear();

            Data.SaveAllData();

            Clear();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            MainMenu frm = new MainMenu();
            frm.Show();
            this.Hide();
        }

        private void DeleteAll_Load(object sender, EventArgs e)
        {
            Erase.Enabled = false;
        }
        private void Clear()
        {
            SecurityPassword.Text = "";
            Erase.Enabled = false;
        }
    }
}
