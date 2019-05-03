using System;
using System.Text;

namespace practice1
{
    class Person
    {
        private string _LastName;
        private string _FirstName;
        private string _MiddleName;
        private string _Addr1;
        private string _City;
        private string _State;
        private string _Zip;
        private string _Phone;

        public void Semi()
        {
            Console.WriteLine(_LastName);
        }
        public string LastName
        {
            get
            {
                return _LastName;
            }

            set
            {
                _LastName = value;
            }
        }

        public string MailingLabel()
        {
            StringBuilder myStringBuilder = new StringBuilder() ;

            myStringBuilder.AppendLine(_FirstName + " " + _LastName);
            myStringBuilder.AppendLine(_Addr1);
            myStringBuilder.AppendLine(_City +", " +_State +" " + _Zip);
            myStringBuilder.AppendLine(_Phone);

            return myStringBuilder.ToString();

        }
        

        public string City
        {
            get
            {
                return _City;
            }
            set
            {
                _City = value;
            }
        }

        public string MiddleName
        {
            get { return _MiddleName; }
            set
            {
                _MiddleName = value;
            }
        }
        public string Addr1
        {
            get { return _Addr1; }
            set
            {
                _Addr1 = value;
            }
        }
        public string State
        {
            get { return _State; }
            set
            {
                _State = value;
            }
        }
        public string Zip
        {
            get { return _Zip; }
            set
            {
                _Zip = value;
            }
        }

        public string FirstName
        {
            get { return _FirstName; }
            set
            {
                _FirstName = value;
            }
        }

        public string Phone1
        {
            get { return _Phone; }
            set
            {
                _Phone = value;
            }
        }
    }
}
