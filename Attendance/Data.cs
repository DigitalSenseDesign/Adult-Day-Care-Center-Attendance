using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Linq;
using System.Data;
using System.Xml.Linq;

namespace Attendance
{
    class Data
    {
        public static List<ServiceUser> ServiceUsers = new List<ServiceUser>();
        public static List<Mark>        Marks        = new List<Mark>();

        static string UserPath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), @"ServiceUsers.XML");
        static string MarkPath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), @"Marks.XML");

        static public void AddUser(
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
            bool     isFriday)
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
        static public bool HasData()
        {
            bool hasData = false;

            if (Data.ServiceUsers.Count > 0)
            {
                hasData = true;
            }

            return hasData;
        }
        static public void SaveAllData()
        {
            try
            {
                SaveServiceUsers();
                SaveMarks();
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
                if (!File.Exists(UserPath))
                {
                    XDocument xDocument = new XDocument(new XElement("ServiceUsers"));
                    xDocument.Save("ServiceUsers.xml");
                }
                else
                {
                    LoadServiceUsers();
                }
                if (!File.Exists(MarkPath))
                {
                    XDocument xDocument = new XDocument(new XElement("Marks"));
                    xDocument.Save("Marks.xml");
                }
                else
                {
                    LoadMarks();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        static public void SaveServiceUsers()
        {
            XDocument xDocument = new XDocument(new XElement("ServiceUsers",
            from serviceUser in Data.ServiceUsers
            select new XElement("ServiceUser",

                new XElement("SOSCareNumber", serviceUser.SOSCareNumber),
                new XElement("FirstName"    , serviceUser.FirstName),
                new XElement("LastName"     , serviceUser.LastName),
                new XElement("DOB"          , serviceUser.DOB.ToShortDateString()),
                new XElement("Address"      , serviceUser.Address),
                new XElement("PostCode"     , serviceUser.PostCode),
                new XElement("ProgramOfCare", serviceUser.ProgramOfCare),
                new XElement("Transport"    , serviceUser.Transport),

                new XElement("Monday"       , serviceUser.Monday),
                new XElement("Tuesday"      , serviceUser.Tuesday),
                new XElement("Wednesday"    , serviceUser.Wednesday),
                new XElement("Thursday"     , serviceUser.Thursday),
                new XElement("Friday"       , serviceUser.Friday)
                )
            ));
            xDocument.Save("ServiceUsers.xml");
        }
        static public void SaveMarks()
        {
            XDocument xDocument = new XDocument(new XElement("Marks",
            from mark in Data.Marks
            select new XElement("Mark",

                new XElement("Date",   mark.Date.ToShortDateString()),
                new XElement("ID",     mark.ID),
                new XElement("IsHere", mark.IsHere)
                )
            ));
            xDocument.Save("Marks.xml");
        }
        static public void LoadServiceUsers()
        {
            /* Createsa an XDoccument and loads the entire XML doccument into memory and creates an enumerable 
             * XElement and sets it to the XDoccument elements */
            XDocument doc = XDocument.Load(UserPath);
            IEnumerable<XElement> xelement = doc.Elements();

            // Uses LINQ statements to find the children of the Product elements
            var serviceUsers = doc.Descendants("ServiceUser")
                                  .Elements()
                                  .Select(e => e.Value);

            // Puts the results of the LINQ statement to the lines list
            List<string> lines = serviceUsers.ToList();

            while (0 < (lines.Count))
            {
                List<string> temp = lines.GetRange(0, 13);
                Data.ServiceUsers.Add(new ServiceUser
                (/*SOSCareNumber*/                    temp[0]  ,
                 /*FirstName*/                        temp[1]  ,
                 /*LastName*/                         temp[2]  ,
                 /*DOB*/           Convert.ToDateTime(temp[3] ),
                 /*Address*/                          temp[4]  ,
                 /*PostCode*/                         temp[5]  ,
                 /*ProgramOfCare*/                    temp[6]  ,
                 /*Transport*/                        temp[7]  ,

                 /*Monday*/         Convert.ToBoolean(temp[8] ),
                 /*Tuesday*/        Convert.ToBoolean(temp[9] ),
                 /*Wednesday*/      Convert.ToBoolean(temp[10]),
                 /*Thursday*/       Convert.ToBoolean(temp[11]),
                 /*Friday*/         Convert.ToBoolean(temp[12])
                ));
                lines.RemoveRange(0, 13);
            }
            lines.Clear();
        }
        static public void LoadMarks()
        {
            /* Createsa an XDoccument and loads the entire XML doccument into memory and creates an enumerable 
             * XElement and sets it to the XDoccument elements 
             */
            XDocument doc = XDocument.Load(MarkPath);
            IEnumerable<XElement> xelement = doc.Elements();

            // Uses LINQ statements to find the children of the Product elements
            var marks = doc.Descendants("Mark")
                           .Elements()
                           .Select(e => e.Value);
          
            List<string> lines = marks.ToList();

            while (0 < (lines.Count))
            {
                List<string> temp = lines.GetRange(0, 3);
                Data.Marks.Add(new Mark
                (/*Date*/   Convert.ToDateTime(temp[0]),
                 /*ID*/                        temp[1],
                 /*IsHere*/ Convert.ToBoolean(temp[2])
                ));
                lines.RemoveRange(0, 3);
            }

            lines.Clear();
        }
    }
}