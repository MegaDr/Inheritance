using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pemrograman10
{
    public class Teacher
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string TeacherId { get; set; }
        public string Subject { get; set; }

        public Teacher(string Name, int Age, string TeacherId, string Subject)
        {
            this.Name = Name;
            this.Age = Age;
            this.TeacherId = TeacherId;
            this.Subject = Subject;

        }
        public void GetNameAndAge()
        {
            Console.WriteLine("The peraon has name : {0} and age : {1} teacherId : {2} Subject : {3}", Name, Age, TeacherId, Subject);
        }
    }
}
