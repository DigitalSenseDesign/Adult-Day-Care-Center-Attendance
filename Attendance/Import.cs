using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Data;

namespace Attendance
{
    public partial class ImportData : Form
    {
        List<string> lines = new List<string>();
        
        public ImportData()
        {
            InitializeComponent();
        }
        private void cmdSetFileLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            OpenFileDialog.FilterIndex = 1;
            OpenFileDialog.RestoreDirectory = true;
            OpenFileDialog.DefaultExt = ".xml";
            OpenFileDialog.FileName = "Export";

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileLocation.Text = OpenFileDialog.FileName;
                XMLRead(OpenFileDialog);
                Import.Enabled = true;
            }
        }
        void XMLRead(OpenFileDialog OpenFileDialog)
        {
            XmlTextReader txtin = new XmlTextReader(OpenFileDialog.FileName);

            while (txtin.Read())
            {
                switch (txtin.NodeType)
                {
                    case XmlNodeType.Text:
                        lines.Add("" + txtin.Value);
                        break;
                }
            }
            DataSet dataSet = new DataSet();
            DataView dataView;
            dataSet.ReadXml(OpenFileDialog.FileName, XmlReadMode.InferSchema);
            dataView = dataSet.Tables[0].DefaultView;

            dataGridView.DataSource = dataView;
            dataGridView.Refresh();
        }
        void PopulateServiceUsers()
        {
            int index = 0;
            int count = 15;

            while(index < (lines.Count()))
            {
                List<string> temp = lines.GetRange(index, count);
                Data.ServiceUsers.Add(new ServiceUser
                (/*SOSCareNumber*/                    temp[1],
                 /*FirstName*/                        temp[2],
                 /*LastName*/                         temp[3],
                 /*DOB*/           Convert.ToDateTime(temp[4]),
                 /*Address*/                          temp[5],
                 /*PostCode*/                         temp[6],
                 /*ProgramOfCare*/                    temp[7],
                 /*Transport*/                        temp[8],

                 /*Monday*/         Convert.ToBoolean(temp[9]),
                 /*Tuesday*/        Convert.ToBoolean(temp[10]),
                 /*Wednesday*/      Convert.ToBoolean(temp[11]),
                 /*Thursday*/       Convert.ToBoolean(temp[12]),
                 /*Friday*/         Convert.ToBoolean(temp[13])
                ));
                index += count;
            }
        }

        private void cmdImport_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to overwrite service users?", "Modify record", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                PopulateServiceUsers();
                Import.Enabled = false;
            }
        }

        private void cmdMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu frm = new MainMenu();
            frm.Show();
            this.Hide();
        }

        private void Import_Load(object sender, EventArgs e)
        {
            Import.Enabled = false;
        }
    }
}
