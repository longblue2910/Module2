using System;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Studen Long = new Studen(1,"T. Long", "Hà Nội", 30 );
            Studen Page = new Studen();
            Page.SetId(2);
            Page.SetName("Tr. Page");
            Page.SetAddress("America");
            Page.SetAge(21);

            Console.WriteLine(Long.ToString());
            Console.WriteLine(Page.ToString());
            Console.Read();
        }
    }
}
