using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Loader;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSailingClubClassLibrary
{


    public class Employee : Person
    {
        private string Role { get; set; }

        public Employee(string role, int id, string name, int tlf, string email, string address) : base(id, name, tlf, email, address)
        {
            Role = role;
        }

        public override string ToString()
        {
            return $"Role: {Role} + ID: {Id} + Name: {Name} + Tlf: {Tlf} + Email: {Email} + Address {Address}";
        }
    }
}
