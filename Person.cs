using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pemrograman10
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void GetNameAndAge()
        {
            Console.WriteLine("The peraon has name : {0} and age {1}", Name, Age);
        }

        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        
    }
}
