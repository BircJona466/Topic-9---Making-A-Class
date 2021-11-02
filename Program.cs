using System;
using System.Collections.Generic;

namespace Topic_9___Making_A_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Student person = new Student("Robert", "Ross");
            Console.WriteLine(person.FirstName);
            //Changing First Name Value
            person.FirstName = "Bobert";
            Console.WriteLine(person.FirstName);
            Console.WriteLine("");
            Console.WriteLine(person.LastName);
            //Changing Last Name Value
            person.LastName = "Boss";
            Console.WriteLine(person.LastName);
            Console.WriteLine("");
            Console.WriteLine(person.StudentNumber);
            Console.WriteLine("");
            // Printing Class Manually
            Console.WriteLine(person.FirstName + " " + person.LastName + " " + person.StudentNumber);
            Console.WriteLine("");
            //Simplified Class Print
            Console.WriteLine(person);
            Console.WriteLine("");
            //Printing Email
            Console.WriteLine(person.Email);
            Console.WriteLine("");
            Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("");

            List<Student> students = new List<Student>();

            students.Add(new Student("Bob", "Ross"));

            Console.WriteLine("How many students are in your class?");
            Console.WriteLine("Please Enter a number..");
            int classNumber = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < classNumber; i++)
            {
                Console.WriteLine("Please enter the student's first name..");
                string firstname = Console.ReadLine();
                Console.WriteLine("Please enter the student's last name..;");
                string lastname = Console.ReadLine();
                students.Add(new Student(firstname, lastname));
                Console.WriteLine(students[i + 1]);
                Console.WriteLine("Thank You.");
                
                Console.WriteLine("");

            }
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i]);
        
            }
            Console.WriteLine("There are " + students.Count + " students in your class.");
        }
        
    }

}
