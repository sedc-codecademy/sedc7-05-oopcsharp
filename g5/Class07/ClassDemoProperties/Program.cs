using System;

namespace ClassDemoProperties
{
    public class Person
    {
        #region Getter/Setter
        private string _firstName;

        public string GetFirstName()
        {
            return _firstName;
        }

        public void SetFirstName(string firstName)
        {
            _firstName = firstName;
        }
        #endregion

        #region Properties with backing fields
        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        #endregion

        #region Auto-implemented properties
        public DateTime Birthdate { get; set; }
        #endregion
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}