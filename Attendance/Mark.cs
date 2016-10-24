using System;

namespace Attendance
{
    class Mark
    {
        private DateTime date;
        private string id;
        private bool isHere;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public bool IsHere
        {
            get { return isHere; }
            set { isHere = value; }
        }

        public Mark()
        {
            Date = DateTime.Now;
            ID = "";
            IsHere = false;
        }

        public Mark(
            DateTime Date,
            string ID,
            bool IsHere
            )
        {
            this.Date = Date;
            this.ID = ID;
            this.IsHere = IsHere;
        }
    }
}
