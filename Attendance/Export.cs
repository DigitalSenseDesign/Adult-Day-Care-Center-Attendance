using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Text;
using System.IO;

namespace Attendance
{
    public partial class Export : Form
    {
        List<string> lines = new List<string>();
        public Export()
        {
            InitializeComponent();
        }
        void UpdateServiceUserTable()
        {
            DataTable serviceUserDT = new DataTable("Service Users");

            serviceUserDT.Columns.Add(new DataColumn("SOSCareNumber"));
            serviceUserDT.Columns.Add(new DataColumn("FirstName"));
            serviceUserDT.Columns.Add(new DataColumn("LastName"));
            serviceUserDT.Columns.Add(new DataColumn("DOB"));
            serviceUserDT.Columns.Add(new DataColumn("Address"));
            serviceUserDT.Columns.Add(new DataColumn("PostCode"));
            serviceUserDT.Columns.Add(new DataColumn("ProgramOfCare"));
            serviceUserDT.Columns.Add(new DataColumn("Transport"));

            serviceUserDT.Columns.Add(new DataColumn("Monday"));
            serviceUserDT.Columns.Add(new DataColumn("Tuesday"));
            serviceUserDT.Columns.Add(new DataColumn("Wednesday"));
            serviceUserDT.Columns.Add(new DataColumn("Thursday"));
            serviceUserDT.Columns.Add(new DataColumn("Friday"));

            foreach (var ServiceUser in Data.ServiceUsers)
            {
                DataRow row;
                row = serviceUserDT.NewRow();

                row["SOSCareNumber"] = ServiceUser.SOSCareNumber;
                row["FirstName"]     = ServiceUser.FirstName;
                row["LastName"]      = ServiceUser.LastName;
                row["DOB"]           = ServiceUser.DOB.ToShortDateString();
                row["Address"]        = ServiceUser.Address;
                row["PostCode"]      = ServiceUser.PostCode;
                row["ProgramOfCare"] = ServiceUser.ProgramOfCare;
                row["Transport"]     = ServiceUser.Transport;

                row["Monday"]        = CommonCode.ParseBool(ServiceUser.Monday   , "Expected", "Not Expected");
                row["Tuesday"]       = CommonCode.ParseBool(ServiceUser.Tuesday  , "Expected", "Not Expected");
                row["Wednesday"]     = CommonCode.ParseBool(ServiceUser.Wednesday, "Expected", "Not Expected");
                row["Thursday"]      = CommonCode.ParseBool(ServiceUser.Thursday , "Expected", "Not Expected");
                row["Friday"]        = CommonCode.ParseBool(ServiceUser.Friday   , "Expected", "Not Expected");

                serviceUserDT.Rows.Add(row);
            }

            ServiceUserDGV.DataSource = serviceUserDT;
        }
        void UpdateAttendanceTable()
        {
            DataTable markDT = new DataTable("Service Users");

            markDT.Columns.Add(new DataColumn("Date"));
            markDT.Columns.Add(new DataColumn("ID"));
            markDT.Columns.Add(new DataColumn("Attendance"));

            foreach (var Mark in Data.Marks)
            {
                DataRow row;
                row = markDT.NewRow();

                row["Date"] = Mark.Date.ToShortDateString();
                row["ID"] = Mark.ID;
                row["Attendance"] = CommonCode.ParseBool(Mark.IsHere, "Attended", "Absent");

                markDT.Rows.Add(row);
            }

            MarkDGV.DataSource = markDT;
        }
        void ExportAllData_Click(object sender, EventArgs e)
        {
            DateTime firstDate = DateTime.MinValue;
            DateTime lastDate = DateTime.MaxValue;

            FindData(firstDate, lastDate);
            SaveFileLocation();
        }
        void ExportBetweenRange_Click(object sender, EventArgs e)
        {
            DateTime firstDate = FirstDate.Value;
            DateTime lastDate = LastDate.Value;

            FindData(firstDate, lastDate);
            bool isValid = ValidateAll();
            if (!isValid)
            {
                return;
            }
            SaveFileLocation();
        }
        void FindData(DateTime firstDate, DateTime lastDate)
        {
            var currentInfo =
                from u in Data.ServiceUsers
                from m in Data.Marks
                where u.SOSCareNumber == m.ID
                where m.Date > firstDate
                where m.Date < lastDate
                select new
                {
                    Date = m.Date.ToShortDateString(),

                    SOSCareNumber = m.ID,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    DOB = u.DOB.ToShortDateString(),
                    Address = u.Address,
                    PostCode = u.PostCode,
                    ProgramOfCare = u.ProgramOfCare,
                    Transport = u.Transport,

                    Monday = u.Monday,
                    Tuesday = u.Tuesday,
                    Wednesday = u.Wednesday,
                    Thursday = u.Thursday,
                    Friday = u.Friday,

                    Value = m.IsHere
                };
            foreach (var record in currentInfo)
            {
                lines.Add(
                    record.Date          + "," +

                    record.SOSCareNumber + "," +
                    record.FirstName     + "," +
                    record.LastName      + "," +
                    record.DOB           + "," +
                    record.Address       + "," +
                    record.PostCode      + "," +
                    record.ProgramOfCare + "," +
                    record.Transport     + "," +

                    record.Monday        + "," +
                    record.Tuesday       + "," +
                    record.Wednesday     + "," +
                    record.Thursday      + "," +
                    record.Friday        + "," +

                    CommonCode.ParseBool(record.Value, "Attended", "Absent")
               );
            }
            UpdateServiceUserTable();
            UpdateAttendanceTable();
        }
        void SaveFileLocation()
        {
            SaveFileDialog saveLocation = new SaveFileDialog();
            saveLocation.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            saveLocation.FilterIndex = 1;
            saveLocation.RestoreDirectory = true;
            saveLocation.DefaultExt = ".xml";
            saveLocation.FileName = "Export";

            if (saveLocation.ShowDialog() == DialogResult.OK)
            {
                XMLWrite(saveLocation);
            }
        }
        void XMLWrite(SaveFileDialog saveLocation)
        {
            XmlTextWriter BookWriter = new XmlTextWriter(saveLocation.FileName, Encoding.UTF8);
            BookWriter.Formatting = Formatting.Indented;

            BookWriter.WriteStartDocument();
            BookWriter.WriteStartElement("ServiceUsers");
            BookWriter.WriteWhitespace("\n");

            foreach (var line in lines)
            {
              String[] user = line.Split(',');

              BookWriter.WriteStartElement("ServiceUser");
              BookWriter.WriteWhitespace("\n");

	              BookWriter.WriteElementString("Date", user[0]);
	              BookWriter.WriteWhitespace("\n");

	              BookWriter.WriteElementString("SOSCareNumber", user[1]);
	              BookWriter.WriteWhitespace("\n");
	              BookWriter.WriteElementString("FirstName", user[2]);
	              BookWriter.WriteWhitespace("\n");
	              BookWriter.WriteElementString("LastName", user[3]);
	              BookWriter.WriteWhitespace("\n");
	              BookWriter.WriteElementString("DOB", user[4]);
	              BookWriter.WriteWhitespace("\n");
	              BookWriter.WriteElementString("Address", user[5]);
	              BookWriter.WriteWhitespace("\n");
	              BookWriter.WriteElementString("PostCode", user[6]);
	              BookWriter.WriteWhitespace("\n");
	              BookWriter.WriteElementString("ProgramOfCare", user[7]);
	              BookWriter.WriteWhitespace("\n");
	              BookWriter.WriteElementString("Transport", user[8]);
				  BookWriter.WriteWhitespace("\n");

	              BookWriter.WriteElementString("Monday", user[9]);
				  BookWriter.WriteWhitespace("\n");
	              BookWriter.WriteElementString("Tuesday", user[10]);
				  BookWriter.WriteWhitespace("\n");
	              BookWriter.WriteElementString("Wednesday", user[11]);
				  BookWriter.WriteWhitespace("\n");
	              BookWriter.WriteElementString("Thursday", user[12]);
				  BookWriter.WriteWhitespace("\n");
	              BookWriter.WriteElementString("Friday", user[13]);
	              BookWriter.WriteWhitespace("\n");

	              BookWriter.WriteElementString("Attendance", user[14]);
	              BookWriter.WriteWhitespace("\n");

              BookWriter.WriteEndElement();
              BookWriter.WriteWhitespace("\n");
            }
            BookWriter.WriteEndDocument();
            BookWriter.Close();

            lines.Clear();
        }
        void MainMenu_Click(object sender, EventArgs e)
        {
            MainMenu frm = new MainMenu();
            frm.Show();
            this.Hide();
        }
        void Export_Load(object sender, EventArgs e)
        {
            UpdateServiceUserTable();
            UpdateAttendanceTable();
        }
        void DateValidation_Click(object sender, EventArgs e)
        {
            ValidateDate();
        }
        bool ValidateAll()
        {
            bool isValid = true;
            isValid = ValidateDate();
            isValid = ValidateData();
            return isValid;
        }
        bool ValidateDate()
        {
            bool isValid = true;
            errorProvider1.Clear();
            if (FirstDate.Value > LastDate.Value)
            {
                errorProvider1.SetError(FirstDate, "Last Date cannot be before First Date");
                errorProvider1.SetError(LastDate,  "Last Date cannot be before First Date");
                isValid = false;
            }
            return isValid;
        }
        bool ValidateData()
        {
            bool isValid = true;
            errorProvider1.Clear();
            if (lines.Count < 1)
            {
                errorProvider1.SetError(ExportBetweenRange, "No data To Export");
                isValid = false;
            }
            return isValid;
        }
    }
}
