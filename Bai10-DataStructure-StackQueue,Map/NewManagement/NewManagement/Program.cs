﻿using System;
using System.Collections.Generic;

namespace NewManagement
{
    class Program
    {
        public static List<News> newList = new List<News>();
        public static int increment = 0;

        static void Main(string[] args)
        {
            InsertNews();
            InsertNews();
            ViewListNews();
            AverageRate();
            ViewListNews();
        }

       

        public static void InsertNews()
        {
            increment++;
            var news = new News();
            news.Id = increment;
            Console.WriteLine("Title: ");
            news.Title = Console.ReadLine();
            Console.Write("Publish date: ");
            news.PublishDate = Console.ReadLine();
            Console.Write("Author: ");
            news.Author = Console.ReadLine();
            Console.Write("Content: ");
            news.Content = Console.ReadLine();

            for (int i = 0; i < news.RateList.Length; i++)
            {
                Console.Write($"Rate {i + 1}: ");
                news.RateList[i] = int.Parse(Console.ReadLine());
            }
            newList.Add(news);
        }
        public static void ViewListNews()
        {
            Console.WriteLine($"Id\tTitle\tPublish Date\tAuthor\tContent\tAverageRate");
            foreach (var news in newList)
            {
                news.Display();
            }
        }

        public static void AverageRate()
        {
            foreach (var news in newList)
            {
                news.Calculate();
            }
        }
    }
}
