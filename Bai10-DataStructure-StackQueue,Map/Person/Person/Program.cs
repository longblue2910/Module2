using System;
using System.Collections;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrPerson = new ArrayList();

            arrPerson.Add(new Person("Quang ngdd", 12));
            arrPerson.Add(new Person("Quang nl", 13));
            // In thử danh sách Person ban đầu ra.
            Console.WriteLine("Danh sach Person ban dau: ");
            foreach (Person item in arrPerson)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
    #region Class Person
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
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
            return $"Name : {name} , Age : {age} ";
        }
    }
    #endregion
   
}
