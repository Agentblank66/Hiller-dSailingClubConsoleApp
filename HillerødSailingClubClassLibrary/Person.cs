using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSailingClubClassLibrary
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Tlf { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Person(int id, string name, int tlf, string email, string address)
        {
            Id = id;
            Name = name;
            Tlf = tlf;
            Email = email;
            Address = address;
        }
    }
}
