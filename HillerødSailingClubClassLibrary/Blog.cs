using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSailingClubClassLibrary
{
    public class Blog
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public string Text { get; set; }


        public Blog(int id, string titel, string text)
        {
            Id = id;
            Titel = titel;
            Text = text;
        }

        public override string ToString()
        {
            return $"Id: {Id} + Titel: {Titel} + Text: {Text}";
        }
    }
}
