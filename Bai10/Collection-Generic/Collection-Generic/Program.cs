﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection_Generic
{
    class Program
    {
        public static int _ID = 0;
        public static Forum forum = new Forum();
        static void Menu()
        {
            Console.WriteLine("1. Create Post");
            Console.WriteLine("2. Update Post");
            Console.WriteLine("3. Remove Post");
            Console.WriteLine("4. Show Posts");
            Console.WriteLine("5. Search");
            Console.WriteLine("6. Rating");
            Console.WriteLine("7. Exit");
        }
        static void Main(string[] args)
        {
            int choice;
            Menu();
            while (true)
            {
                
                Console.WriteLine("Please select an item: ");
                choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        CreatePost();
                        break;
                    case 2:
                        Console.WriteLine("--Update Post--");
                        int id = ID();
                        Console.WriteLine("Enter new content: ");
                        string newContent = Console.ReadLine();
                        forum.Update(id, newContent);
                        break;
                    case 3:
                        int id2 = ID();
                        forum.Remove(id2);
                        break;
                    case 4:
                        forum.Show();
                        break;
                    case 5:
                        Search();
                        break;
                    case 6:
                        Rating();
                        break;
                    case 7:
                        Console.WriteLine("Exit");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Not found");
                        break;


                }    
            }    

        }

        public static void CreatePost()
        {
            Post post = new Post();
            Console.Write("Title: ");
            post.Title = Console.ReadLine();
            Console.Write("Author: ");
            post.Author = Console.ReadLine();
            Console.Write("Content: ");
            post.Content = Console.ReadLine();
            for (int i = 0; i < post.RateList.Length; i++)
            {
                Console.WriteLine($"Enter vote rate {i + 1}: ");
                string temp = Console.ReadLine();
                while (!Int32.TryParse(temp, out post.RateList[i]) || (post.RateList[i] < 1 || post.RateList[i] >5))
                {
                    Console.Write("Enter again: ");
                    temp = Console.ReadLine();
                }
            }
            post.ID = _ID;
            _ID++;
            forum.Add(post);
        }
        public static int ID()
        {
            Console.Write("Enter: ");
            int id = int.Parse(Console.ReadLine());
            while (id < 0)
            {
                Console.Write("Enter again ID:");
                id = int.Parse(Console.ReadLine());
            }
            return id;
        }
        public static void Search()
        {
            byte choice_search;
            Console.WriteLine("Search");
            Console.WriteLine("1. Search by Title");
            Console.WriteLine("2. Search by Author");
            choice_search = byte.Parse(Console.ReadLine());
            switch (choice_search)
            {
                case 1:
                    Console.Write("Enter Title search: ");
                    string title = Console.ReadLine();
                    forum.FindTitle(title);
                    break;
                case 2:
                    Console.Write("Enter Author search: ");
                    string author = Console.ReadLine();
                    forum.FindAuthor(author);
                    break;
                default:
                    Console.WriteLine("Not found");
                    break;
            }
        }
        public static void Rating()
        {
            Console.WriteLine("Rating by ID");
            int id = ID();
            int index = forum.FindId(id);
            if (index == -1)
            {
                Console.WriteLine("Invalid Post!");
            }
            else
            {
                Console.WriteLine("Result...");
                forum.posts[index].Display();
            }
        }
    }
}