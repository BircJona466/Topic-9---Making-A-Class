using System;
using System.Collections.Generic;
using System.Text;

namespace Topic_9___Making_A_Class
{
    class Student
    {
        private static Random generator = new Random();
        //Defining Variables
        private string _firstname;
        private string _lastname;
        private int _studentNumber;
        private string _email;


        public Student(string firstName, string lastName)
        {
            //Instance variables, fields initialized here

            _firstname = firstName;
            _lastname = lastName;
            _studentNumber = generator.Next(100,1000);
            GenerateEmail();
        }
        //Controlling What Can Be Controlled In The Main Form
        public string FirstName
        {
            get
            {
                return _firstname;
            }
            set
            {
                _firstname = value;
                //Change Email everytime names change
                GenerateEmail();
            }

        }

        public string LastName
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
                //Change Email everytime names change
                GenerateEmail();
            }
        }
        public int StudentNumber
        {
                get
            {
                return _studentNumber;
            }
        }
        //Allowing you to call _email
        public string Email
        {
            get
            {
                return _email;
            }
            
        }

        // Simplify Console.WriteLine(class);
        public override string ToString()
        {
            return _firstname + " " + _lastname;
        }
        
        //Making a method that generates _email
        private void GenerateEmail()
        {
            //First 3 letters of First Name, First 3 Letters of the Last Name, Student Number, @ICS4U.ca
            _email = _firstname.Substring(0, 3) + _lastname.Substring(0, 3) + _studentNumber + "@ICS4U.ca";


        }




    }
}
