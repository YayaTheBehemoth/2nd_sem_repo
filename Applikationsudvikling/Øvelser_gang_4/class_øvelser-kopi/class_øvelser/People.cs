using System;
using System.Globalization;

namespace class_øvelser
{
    public class People
    {
      
        protected string _firstName;
        protected string _lastName;
        protected string _middleName;
        protected string _cprNo;

        public People(string f, string l, string m, string c)
        {
            _firstName = f;
            _lastName = l;
            _middleName = m;
            _cprNo = c;

        }
        public People(string c)
        {
            _cprNo = c;
        }

        public string GetName()
        {
            string fullName = $"{_firstName}{_middleName}{_lastName}";
            return fullName;
        }
        public string getGender()
        {
            string gender;
            if ((int.Parse(_cprNo.Substring(9)) % 2) == 0)
            {
                gender = "woman";
            }
            else
            {
                gender = "man";
            }
            return gender;
        }
        public DateTime getBday()
        {
            DateTime Bday;
            Bday = DateTime.ParseExact(_cprNo.Substring(0, 6),"ddmmyy", CultureInfo.InvariantCulture);
           
            return Bday;
        }
        public Double getAge()
        {
            DateTime Bday;
            Bday = DateTime.ParseExact(_cprNo.Substring(0, 6),"ddmmyy", CultureInfo.InvariantCulture);
            DateTime today = DateTime.Now;
            double age = ((today - Bday).TotalDays);
            age = age / 365;
            return age;
        }
        public string firstname
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string lastname
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string middlename
        {
            get { return _middleName; }
            set { _middleName = value; }
        }
        public string cprno
        {
            get { return _cprNo; }
            set { _cprNo = value; }
        }
    }
}
