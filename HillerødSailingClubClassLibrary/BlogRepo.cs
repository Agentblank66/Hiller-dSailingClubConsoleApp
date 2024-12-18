using HillerødSialingClub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSailingClubClassLibrary
{
    public class BlogRepo
    {
        private Dictionary<int, Blog> Blogs = new Dictionary<int, Blog>();
        

        public void AddBlogPost(Blog blog)
        {
            Blogs.TryAdd(blog.Id, blog);
        }

        public void UpdateBlogPost(Blog blog,int newid, string newtitel, string newtext)
        {
            if (Blogs.ContainsKey(newid))
            {
                blog.Titel = newtitel;
                blog.Text = newtext;
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

        public string GetAllBlogs()
        {
            string BlogsString = string.Join(", \n", Blogs);
            return BlogsString;
        }
    }
}