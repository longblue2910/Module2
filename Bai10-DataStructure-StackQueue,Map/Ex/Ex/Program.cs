using System;
using System.Collections;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrPerson = new ArrayList();

            arrPerson.Add(new Person("Quang cđ" , 20));
            arrPerson.Add(new Person("Quang nl", 19));
            arrPerson.Add(new Person("Quang nnc", 21));

            Console.WriteLine();
            Console.WriteLine("Danh sách học sinh ban đầu : ");
            foreach (Person item in arrPerson)
            {
                Console.WriteLine(item.ToString());
            }    

            
        }
    }
    public class SortPerson : IComparer
    {
        public int Compare (object x, object y)
        {
            Person p1 = y as Person;
        }
    }
}
