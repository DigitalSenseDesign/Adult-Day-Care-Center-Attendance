using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Attendance
{
    public partial class EditUsers : Form
    {
        public EditUsers()
        {
            InitializeComponent();
        }
        private void EditUsers_Load(object sender, EventArgs e)
        {
            DOB.Value = DateTime.Now;
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
        private void SOSCareNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateInfo();
        }
        void UpdateInfo()
        {
            FirstName.Text     = Data.ServiceUsers[SOSCareNumber.SelectedIndex].FirstName;
            LastName.Text      = Data.ServiceUsers[SOSCareNumber.SelectedIndex].LastName;
            DOB.Value          = Data.ServiceUsers[SOSCareNumber.SelectedIndex].DOB;
            Address.Text       = Data.ServiceUsers[SOSCareNumber.SelectedIndex].Addess;
            PostCode.Text      = Data.ServiceUsers[SOSCareNumber.SelectedIndex].PostCode;
            ProgramOfCare.Text = Data.ServiceUsers[SOSCareNumber.SelectedIndex].ProgramOfCare;
            Transport.Text     = Data.ServiceUsers[SOSCareNumber.SelectedIndex].Transport;

            Monday.Checked     = Data.ServiceUsers[SOSCareNumber.SelectedIndex].Monday;
            Tuesday.Checked    = Data.ServiceUsers[SOSCareNumber.SelectedIndex].Tuesday;
            Wednesday.Checked  = Data.ServiceUsers[SOSCareNumber.SelectedIndex].Wednesday;
            Thursday.Checked   = Data.ServiceUsers[SOSCareNumber.SelectedIndex].Thursday;
            Friday.Checked     = Data.ServiceUsers[SOSCareNumber.SelectedIndex].Friday;
        }
        private void ModifyRecord_Click(object sender, EventArgs e)
        {
            Data.EditUser(
                    SOSCareNumber.SelectedIndex,

                    SOSCareNumber.Text,
                    FirstName.Text,
                    LastName.Text,
                    DOB.Value,
                    Address.Text,
                    PostCode.Text,
                    ProgramOfCare.Text,
                    Transport.Text,

                    Monday.Checked,
                    Tuesday.Checked,
                    Wednesday.Checked,
                    Thursday.Checked,
                    Friday.Checked
                    );

            UpdateList();
        }
        bool ValidateInformation()
        {
        		bool isValid = true;
        		errorProvider1.Clear();
        
        		if (SOSCareNumber.Text == ""           ) { errorProvider1.SetError(SOSCareNumber, "Please set SOS Care Number"            ); isValid = false; }
        		if (FirstName.Text	   == ""           ) { errorProvider1.SetError(FirstName,	  "Please set First name"                 ); isValid = false; }
        		if (LastName.Text	   == ""           ) { errorProvider1.SetError(LastName,	  "Please set Last name"                  ); isValid = false; }
        		if (DOB.Value		   == DateTime.Now ) { errorProvider1.SetError(DOB,		      "Please set Date of Birth"	          ); isValid = false; }
        		if (DOB.Value		   >= DateTime.Now ) { errorProvider1.SetError(DOB,		      "Date of Birth cannot be a future date" ); isValid = false; }
        		if (Address.Text	   == ""           ) { errorProvider1.SetError(Address,	      "Please set Address"					  ); isValid = false; }
        		if (PostCode.Text      == ""           ) { errorProvider1.SetError(PostCode,	  "Please set Post Code"				  ); isValid = false; }
        		if (ProgramOfCare.Text == ""           ) { errorProvider1.SetError(ProgramOfCare, "Please set Program of Care"			  ); isValid = false; }
        		if (Transport.Text	   == ""           ) { errorProvider1.SetError(Transport,	  "Please set method of Transport"		  ); isValid = false; }
        
        		if (!Monday.Checked    &&
        		    !Tuesday.Checked   &&
        			!Wednesday.Checked &&
        			!Thursday.Checked  &&
        			!Friday.Checked)
        		{
        		    if (!Monday.Checked   ) { errorProvider1.SetError(Monday,    "Please select one or more days of attendance"); }
        		    if (!Tuesday.Checked  ) { errorProvider1.SetError(Tuesday,   "Please select one or more days of attendance"); }
        		    if (!Wednesday.Checked) { errorProvider1.SetError(Wednesday, "Please select one or more days of attendance"); }
        		    if (!Thursday.Checked ) { errorProvider1.SetError(Thursday,  "Please select one or more days of attendance"); }
        		    if (!Friday.Checked   ) { errorProvider1.SetError(Friday,	 "Please select one or more days of attendance"); }
        
        		    isValid = false;
        		}
        		return isValid;
        }
        private void MainMenu_Click(object sender, EventArgs e)
        {
            MainMenu frm = new MainMenu();
            frm.Show();
            this.Hide();
        }

        private void ReadOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
