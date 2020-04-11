using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pemrograman10
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Mega", 20);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Rian", 30, "190302", "Informatika");
            teacher.GetNameAndAge();

            student Student = new student("Dwirani", 17, "10506", "mega@gmail.com");
            Student.GetNameAndAge();

            Console.ReadKey();
        }
    }
}
