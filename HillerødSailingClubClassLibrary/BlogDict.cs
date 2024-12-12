using System;
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
            Blogs.Add(blog.Id, blog);
        }

        public void UpdateBlogPost(Blog blog)
        {
            if (Blogs.ContainsKey(blog.Id))
            {
                blog.Id = blog.Id;
                blog.Titel = blog.Titel;
                blog.Text = blog.Text;
            }
        }

        public Blog GetBlogPost(int id)
        {
            return Blogs[id];
        }

        public bool DeleteBlogPost(int id)
        {
            return Blogs.Remove(id);
        }
    }
}
