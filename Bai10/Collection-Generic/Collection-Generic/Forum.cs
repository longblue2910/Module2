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
            for (int i = 0; i < posts.Count; i++)
            {
                posts[i].Display();
            }
        }

        #endregion
        #region FindAuthor
        public void FindAuthor(string author)
        {
            for (int i = 0; i < posts.Count; i++)
            {
                if (posts[i].Author == author)
                {
                    posts[i].Display();
                }
            }
        }
        #endregion

        #region FindContent
        public void FindTitle(string title)
        {
            for (int i = 0; i < posts.Count; i++)
            {
                if (posts[i].Title == title)
                {
                    posts[i].Display();
                }
            }
        }
        #endregion

        #region FindId
        public int FindId(int id)
        {
            for (int i = 0; i < posts.Count; i++)
            {
                if (posts[i].ID == id)
                {
                    return i;
                }
            }
            return -1;
        }
        #endregion

    }
}
