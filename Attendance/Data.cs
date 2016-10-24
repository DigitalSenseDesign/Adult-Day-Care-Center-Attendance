using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Attendance
{
    class Data
    {
        static public List<ServiceUser> ServiceUsers = new List<ServiceUser>();
        static public List<Mark> Marks = new List<Mark>();

        static public void AddUser(
            string SOSCareNumber,
            string FirstName,
            string LastName,
            DateTime DOB,
            string Address,
            string PostCode,
            string ProgramOfCare,
            string Transport,

            bool isMonday,
            bool isTuesday,
            bool isWednesday,
            bool isThursday,
            bool isFriday)
        {
            ServiceUsers.Add(new ServiceUser
                (SOSCareNumber,
                 FirstName,
                 LastName,
                 DOB,
                 Address,
                 PostCode,
                 ProgramOfCare,
                 Transport,

                 isMonday,
                 isTuesday,
                 isWednesday,
                 isThursday,
                 isFriday
                 ));
        }
        static public void EditUser(
            int      i,
                     
            string   SOSCareNumber,
            string   FirstName,
            string   LastName,
            DateTime DOB,
            string   Address,
            string   PostCode,
            string   ProgramOfCare,
            string   Transport,

            bool     isMonday,
            bool     isTuesday,
            bool     isWednesday,
            bool     isThursday,
            bool     isFriday
            )
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to modify the record?", "Modify record", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                Data.ServiceUsers[i].SOSCareNumber = SOSCareNumber;
                Data.ServiceUsers[i].FirstName     = FirstName    ;
                Data.ServiceUsers[i].LastName      = LastName     ;
                Data.ServiceUsers[i].DOB           = DOB          ;
                Data.ServiceUsers[i].Addess        = Address      ;
                Data.ServiceUsers[i].PostCode      = PostCode     ;
                Data.ServiceUsers[i].ProgramOfCare = ProgramOfCare;
                Data.ServiceUsers[i].Transport     = Transport    ;

                Data.ServiceUsers[i].Monday        = isMonday     ;
                Data.ServiceUsers[i].Tuesday       = isTuesday    ;
                Data.ServiceUsers[i].Wednesday     = isWednesday  ;
                Data.ServiceUsers[i].Thursday      = isThursday   ;
                Data.ServiceUsers[i].Friday        = isFriday     ;
            }
        }
        static public bool HasData()
        {
            bool hasData = false;

            if (Data.ServiceUsers.Count > 0)
            {
                hasData = true;
            }

            return hasData;
        }
        static public ServiceUser GetUser(int i)
        {
            ServiceUser temp = new ServiceUser();

            temp.SOSCareNumber = Data.ServiceUsers[i].SOSCareNumber;
            temp.FirstName     = Data.ServiceUsers[i].FirstName    ;
            temp.LastName      = Data.ServiceUsers[i].LastName     ;
            temp.DOB           = Data.ServiceUsers[i].DOB          ;
            temp.Addess        = Data.ServiceUsers[i].Addess       ;
            temp.PostCode      = Data.ServiceUsers[i].PostCode     ;
            temp.ProgramOfCare = Data.ServiceUsers[i].ProgramOfCare;
            temp.Transport     = Data.ServiceUsers[i].Transport    ;

            temp.Monday        = Data.ServiceUsers[i].Monday       ;
            temp.Tuesday       = Data.ServiceUsers[i].Tuesday      ;
            temp.Wednesday     = Data.ServiceUsers[i].Wednesday    ;
            temp.Thursday      = Data.ServiceUsers[i].Thursday     ;
            temp.Friday        = Data.ServiceUsers[i].Friday       ;

            return temp;
        }
        static public void RemoveUser(int i)
        {
            Data.ServiceUsers.RemoveAt(i);
        }
        static public void AddMark(string SOSCareNumber, bool isHere)
        {
            Data.Marks.Add(new Mark
            {
                Date = DateTime.Today,
                ID = SOSCareNumber,
                IsHere = isHere
            });
        }
        static public void SaveAllData()
        {
            try
            {
                string UserPath = AppDomain.CurrentDomain.BaseDirectory + @"IO\ServiceUser.XML";
                string MarkPath = AppDomain.CurrentDomain.BaseDirectory + @"IO\Mark.XML";

                File.Create(UserPath).Close();
                File.Create(MarkPath).Close();

                SaveServiceUsers(UserPath);
                SaveMarks(MarkPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        static public void LoadAllData()
        {
            try
            {
                string UserPath = AppDomain.CurrentDomain.BaseDirectory + @"IO\ServiceUser.XML";
                string MarkPath = AppDomain.CurrentDomain.BaseDirectory + @"IO\Mark.XML";

                if (!File.Exists(UserPath))
                {
                    File.WriteAllText(UserPath, "<?xml version=\"1.0\" encoding=\"utf-8\"?>\n<ServiceUsers>\n</ServiceUsers>");
                }
                if (!File.Exists(MarkPath))
                {
                    File.WriteAllText(MarkPath, "<?xml version=\"1.0\" encoding=\"utf-8\"?>\n<Marks>\n</Marks>");
                }

                LoadServiceUsers(UserPath);
                LoadMarks(MarkPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        static public void SaveServiceUsers(string Path)
        {
            //Create list to hold data to be written
            List<string> lines = new List<string>();

            //Add each of the service users to the lines array
            foreach (var ServiceUser in ServiceUsers)
            {
                lines.Add(
                    ServiceUser.SOSCareNumber + "," +
                    ServiceUser.FirstName + "," +
                    ServiceUser.LastName + "," +
                    ServiceUser.DOB + "," +
                    ServiceUser.Addess + "," +
                    ServiceUser.PostCode + "," +
                    ServiceUser.ProgramOfCare + "," +
                    ServiceUser.Transport + "," +

                    ServiceUser.Monday + "," +
                    ServiceUser.Tuesday + "," +
                    ServiceUser.Wednesday + "," +
                    ServiceUser.Thursday + "," +
                    ServiceUser.Friday
                    );
            }

            XmlTextWriter BookWriter = new XmlTextWriter(Path, Encoding.UTF8);
            BookWriter.Formatting = Formatting.Indented;
            BookWriter.Indentation = 4;

            BookWriter.WriteStartDocument();
            BookWriter.WriteStartElement("ServiceUsers");
            BookWriter.WriteWhitespace("\n");

            //For each line in lines write data to the file
            foreach (var line in lines)
            {
                String[] user = line.Split(',');

                BookWriter.WriteStartElement("ServiceUser");
                BookWriter.WriteWhitespace("\n");

                BookWriter.WriteElementString("SOSCareNumber", user[0]);
                BookWriter.WriteWhitespace("\n");
                BookWriter.WriteElementString("FirstName", user[1]);
                BookWriter.WriteWhitespace("\n");
                BookWriter.WriteElementString("LastName", user[2]);
                BookWriter.WriteWhitespace("\n");
                BookWriter.WriteElementString("DOB", user[3]);
                BookWriter.WriteWhitespace("\n");
                BookWriter.WriteElementString("Address", user[4]);
                BookWriter.WriteWhitespace("\n");
                BookWriter.WriteElementString("PostCode", user[5]);
                BookWriter.WriteWhitespace("\n");
                BookWriter.WriteElementString("ProgramOfCare", user[6]);
                BookWriter.WriteWhitespace("\n");
                BookWriter.WriteElementString("Transport", user[7]);
                BookWriter.WriteWhitespace("\n");

                BookWriter.WriteElementString("Monday", user[8]);
                BookWriter.WriteWhitespace("\n");
                BookWriter.WriteElementString("Tuesday", user[9]);
                BookWriter.WriteWhitespace("\n");
                BookWriter.WriteElementString("Wednesday", user[10]);
                BookWriter.WriteWhitespace("\n");
                BookWriter.WriteElementString("Thursday", user[11]);
                BookWriter.WriteWhitespace("\n");
                BookWriter.WriteElementString("Friday", user[12]);
                BookWriter.WriteWhitespace("\n");

                BookWriter.WriteEndElement();
                BookWriter.WriteWhitespace("\n");
            }
            BookWriter.WriteEndDocument();
            BookWriter.Close();

            lines.Clear();
        }
        static public void LoadServiceUsers(string Path)
        {
            List<string> lines = new List<string>();

            XmlTextReader txtin = new XmlTextReader(Path);

            while (txtin.Read())
            {
                switch (txtin.NodeType)
                {
                    case XmlNodeType.Text:
                        lines.Add("" + txtin.Value);
                        break;
                }
            }

            int index = 0;
            int count = 13;

            while (index < (lines.Count))
            {
                List<string> temp = lines.GetRange(index, count);
                Data.ServiceUsers.Add(new ServiceUser
                (/*SOSCareNumber*/                    temp[0],
                 /*FirstName*/                        temp[1],
                 /*LastName*/                         temp[2],
                 /*DOB*/           Convert.ToDateTime(temp[3]),
                 /*Address*/                          temp[4],
                 /*PostCode*/                         temp[5],
                 /*ProgramOfCare*/                    temp[6],
                 /*Transport*/                        temp[7],

                 /*Monday*/         Convert.ToBoolean(temp[8]),
                 /*Tuesday*/        Convert.ToBoolean(temp[9]),
                 /*Wednesday*/      Convert.ToBoolean(temp[10]),
                 /*Thursday*/       Convert.ToBoolean(temp[11]),
                 /*Friday*/         Convert.ToBoolean(temp[12])
                ));
                index += count;
            }
            txtin.Close();

            lines.Clear();
            
        }
        static public void SaveMarks(string Path)
        {
            List<string> lines = new List<string>();

            foreach (var Mark in Marks)
            {
                lines.Add(
                    Mark.Date + "," +
                    Mark.ID + "," +
                    Mark.IsHere
                    );
            }

            XmlTextWriter XMLTextWriterMarks = new XmlTextWriter(Path, Encoding.UTF8);
            XMLTextWriterMarks.Formatting = Formatting.Indented;
            XMLTextWriterMarks.Indentation = 4;

            XMLTextWriterMarks.WriteStartDocument();
            XMLTextWriterMarks.WriteStartElement("Marks");
            XMLTextWriterMarks.WriteWhitespace("\n");

            foreach (var line in lines)
            {
                String[] Mark = line.Split(',');

                XMLTextWriterMarks.WriteStartElement("Mark");
                XMLTextWriterMarks.WriteWhitespace("\n");

                XMLTextWriterMarks.WriteElementString("Date",   Mark[0]);
                XMLTextWriterMarks.WriteWhitespace("\n");
                XMLTextWriterMarks.WriteElementString("ID",     Mark[1]);
                XMLTextWriterMarks.WriteWhitespace("\n");
                XMLTextWriterMarks.WriteElementString("IsHere", Mark[2]);
                XMLTextWriterMarks.WriteWhitespace("\n");

                XMLTextWriterMarks.WriteEndElement();
                XMLTextWriterMarks.WriteWhitespace("\n");
            }
            XMLTextWriterMarks.WriteEndDocument();
            XMLTextWriterMarks.Close();

            lines.Clear();
        }
        static public void LoadMarks(string Path)
        {
            List<string> lines = new List<string>();

            XmlTextReader XMLTextWriter = new XmlTextReader(Path);

            while (XMLTextWriter.Read())
            {
                switch (XMLTextWriter.NodeType)
                {
                    case XmlNodeType.Text:
                        lines.Add("" + XMLTextWriter.Value);
                        break;
                }
            }

            int index = 0;
            int count = 3;

            while (index < (lines.Count))
            {
                List<string> temp = lines.GetRange(index, count);
                Data.Marks.Add(new Mark
                (/*Date*/   Convert.ToDateTime(temp[0]),
                 /*ID*/                        temp[1],
                 /*IsHere*/ Convert.ToBoolean( temp[2])
                ));
                index += count;
            }
            XMLTextWriter.Close();

            lines.Clear();
        }
    }
}