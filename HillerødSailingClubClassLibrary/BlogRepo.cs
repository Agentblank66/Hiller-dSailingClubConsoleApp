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
        

        public bool AddBlogPost(Blog blog)
        {
            return Blogs.TryAdd(blog.Id, blog);
        }

        public bool UpdateBlogPost(Blog blog,int newid, string newtitel, string newtext)
        {
            if (Blogs.ContainsKey(newid))
            {
                blog.Titel = newtitel;
                blog.Text = newtext;
                return true;
            }
            return false;
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

        // Metoden bruges til at søge efter dele af en blog for at sortere alle relevante resultater frem og sende det retur som en string bestående af List<Blog>
        public string SearchBlog(string keyWord)
        {
            // opretter en List kaldet result som skal bestå af alle de relevante blogs
            var result = new List<Blog>();

            // foreach løkke gennemløber alle values i Blogs Dictionary 
            foreach (var blog in Blogs.Values)
            {
                // check vis blog titlen indeholder søgeordet (case-insensitive)
                // bruger IndexOf() metoden på Titel og Text, som finder placeringen af søgeordet og retunere en int, -1 vis den ikke findes.
                // vis den finder søgeordet i Titel eller Text så er vores if true og Blog elementet tilføjes til result listen
                // StringComparison.OrdinalIgnoreCase bruges til at lave sammenligningen og den er ligeglad med store og små bogstaver 
                if (blog.Titel.IndexOf(keyWord, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    blog.Text.IndexOf(keyWord, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    result.Add(blog);
                }
            }
            // tjekker om der er noget result listen  
            if (result.Count > 0) { 
                //  opretter ResultString som er ligmed hele listen skrevet som string
                // der bruges string.Join() til at skrive result objekterne i en string adskilt af komma
                return string.Join(", \n", result); // Return the list of matching blogs
            }
            else // vis listen er tom så retunere vi nedenstående string
            {
                return "Der blev ikke fundet noget";
            } 
        }

        public string GetAllBlogs()
        {
            return string.Join(",\n", Blogs);
        }
    }
}