using System;

namespace Attendance
{
    class ServiceUser
    {
        private string   sosCareNumber;
        private string   firstName;
        private string   lastName;
        private DateTime dob;
        private string   addess;
        private string   postCode;
        private string   programOfCare;
        private string   transport;

        private bool     monday;
        private bool     tuesday;
        private bool     wednesday;
        private bool     thursday;
        private bool     friday;

        public string SOSCareNumber
        {
            get { return sosCareNumber; }
            set { sosCareNumber = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public DateTime DOB
        {
            get { return dob; }
            set { dob = value; }
        }
        public string Addess
        {
            get { return addess; }
            set { addess = value; }
        }
        public string PostCode
        {
            get { return postCode; }
            set { postCode = value; }
        }
        public string ProgramOfCare
        {
            get { return programOfCare; }
            set { programOfCare = value; }
        }
        public string Transport
        {
            get { return transport; }
            set { transport = value; }
        }
        public bool Monday
        {
            get { return monday; }
            set { monday = value; }
        }
        public bool Tuesday
        {
            get { return tuesday; }
            set { tuesday = value; }
        }
        public bool Wednesday
        {
            get { return wednesday; }
            set { wednesday = value; }
        }
        public bool Thursday
        {
            get { return thursday; }
            set { thursday = value; }
        }
        public bool Friday
        {
            get { return friday; }
            set { friday = value; }
        }

        public ServiceUser()
        {
            SOSCareNumber = "";
            FirstName     = "";
            LastName      = "";
            DOB           = DateTime.Now;
            Addess        = "";
            PostCode      = "";
            ProgramOfCare = "";
            Transport     = "";

            Monday        = false;
            Tuesday       = false;
            Wednesday     = false;
            Thursday      = false;
            Friday        = false;
        }

        public ServiceUser(
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
            bool isFriday
            )
        {
            this.SOSCareNumber = SOSCareNumber;
            this.FirstName     = FirstName;
            this.LastName      = LastName;
            this.DOB           = DOB;
            this.Addess        = Address;
            this.PostCode      = PostCode;
            this.ProgramOfCare = ProgramOfCare;
            this.Transport     = Transport;

            this.Monday        = isMonday;
            this.Tuesday       = isTuesday;
            this.Wednesday     = isWednesday;
            this.Thursday      = isThursday;
            this.Friday        = isFriday;
        }
    }
}
