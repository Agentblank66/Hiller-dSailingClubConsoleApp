﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSailingClubClassLibrary
{
    public class BlogDict
    {
        private Dictionary<int, Blog> Blogs = new Dictionary<int, Blog>();
        

        public void AddBlogPost(Blog blog)
        {
            Blogs.TryAdd(blog.Id, blog);
        }

        public void UpdateBlogPost(Blog blog,int id, string titel, string text)
        {
            if (Blogs.ContainsKey(id))
            {
                blog.Titel = titel;
                blog.Text = text;
            }
        }

        public Blog? GetBlogPost(int id)
        {
            if (Blogs.ContainsKey(id))
            {
                return Blogs[id];

            }
            return null;
        }

        public bool DeleteBlogPost(int id)
        {
            return Blogs.Remove(id);
        }

        public string SearchBlog(string keyWord)
        {
            var result = new List<Blog>();

            // Search through each blog in the dictionary
            foreach (var blog in Blogs.Values)
            {
                // Check if the Title or Text contains the keyword (case-insensitive)
                if (blog.Titel.IndexOf(keyWord, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    blog.Text.IndexOf(keyWord, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    result.Add(blog);
                }
            }
            if (result.Count > 0) { 
                string resultString = string.Join(", ", result);
                return resultString; // Return the list of matching blogs
            } else
            {
                return "Der blev ikke fundet noget";
            } 
        }
    }
}
