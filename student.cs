using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pemrograman10
{
    public class student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string StudentId { get; set; }
        public string Email { get; set; }

        public student(string Name, int Age, string StudentId, string Email)
        {
            this.Name = Name;
            this.Age = Age;
            this.StudentId = StudentId;
            this.Email = Email;
        }

        public void GetNameAndAge()
        {
            Console.WriteLine("The peraon has name : {0} and age : {1} studentId : {2} email : {3}", Name, Age, StudentId, Email);
        }
    }
}
