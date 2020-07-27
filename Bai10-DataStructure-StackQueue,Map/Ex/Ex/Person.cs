using System;
using System.Collections.Generic;
using System.Text;

namespace Ex
{
    class Person
    {
        private string name { get; set; }
        private int age { get; set; }
       

        public string Name
        {
            get { return name ; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public override string ToString()
        {
            return "Name " + name + " | Age " + age;
        }
    }
}
