using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collection_Generic
{
    class Forum
    {
        public SortedList<int, Post> posts { get; set; }
        static int count = 0;
        public Forum()
        {
            posts = new SortedList<int, Post>();
        }
        public void Add(Post post)
        {
            posts.Add(post.ID, post);
        }
        public void Update(int id, string new_Content)
        { 
            int pos = FindId(id);
            if (pos >= 0)
            {
                posts[pos].Content = new_Content;
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
        #region Remove

        public void Remove(int id)
        {
            posts.Remove(id);
        }
        #endregion
        #region Show
        public void Show()
        {
            if (posts.Count != 0)
            {
                foreach (var temp in posts.Keys)
                {
                    posts[temp].Display();
                }
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
        #endregion

        #region FindAuthor
        public void FindAuthor(string author)
        {
            foreach (var temp in posts.Keys)
            {
                if (posts[temp].Author == author)
                {
                    posts[temp].Display();
                }
            }
        }
        #endregion

        #region FindContent
        public void FindTitle(string title)
        {
            foreach (var temp in posts.Keys)
            {
                if (posts[temp].Title == title)
                {
                    posts[temp].Display();
                }
            }
        }
        #endregion

        #region FindId
        public int FindId(int id)
        {
            foreach (var temp in posts.Keys)
            {
                if (posts[temp].ID == id)
                {
                    return id;
                }
            }
            return -1;
        }
        #endregion

    }
}
