using System;
using System.Collections.Generic;
using System.Text;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
             // create a document object 
            Document theDoc = new Document("Test Document");

            // Ép kiểu để có thể gọi IStorable.Read() 
            IStorable isDoc = theDoc as IStorable;
            if (isDoc != null)
            {
                isDoc.Read();
            }

            // Ép kiểu để có thể gọi ITalk.Read() 
            ITalk itDoc = theDoc as ITalk;
            if (itDoc != null)
            {
                itDoc.Read();
            }
            theDoc.Read();
            theDoc.Talk();
        }
    }
    interface IStorable
    {
        void Read();
        void Write();
    }
    interface ITalk
    {
        void Read();
        void Talk();
    }
    public class Document : IStorable, ITalk
    {
        // document constructor 
        public Document(string s)
        {
            Console.WriteLine("Creating document with: {0}", s);
        }
        // tạo read của IStorable 
        public virtual void Read()
        {
            Console.WriteLine("Implementing IStorable.Read");
        }
        public void Write()
        {
            Console.WriteLine("Implementing IStorable.Write");
        }

        // cài đặt phương thức Read của ITalk 
        void ITalk.Read()
        {
            Console.WriteLine("Implementing ITalk.Read");
        }
        public void Talk()
        {
            Console.WriteLine("Implementing ITalk.Talk");
        }
    } 
}
