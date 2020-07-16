using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_Generic
{
    class Post : IPost
    {
        public static int number = 0;

        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        float averagerate;
        public float Averagerate
        {
            get { return averagerate; }
        }
        public Post()
        {
            ID = number++;
        }
        

        public void Display()
        {
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Content: " + Content);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Averate rate: " + averagerate);
        }

        public int[] RateList = new int[3];
        public int this [int index]
        {
            get { return RateList[index]; }
            set { RateList[index] = value; }
        }
        public void CalculatorRate()
        {
            averagerate = (float)(RateList[0] + RateList[1] + RateList[2]) / 3;
        }
    }
}
