using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HillerødSailingClubClassLibrary
{
    public class Member : Person
    {
        #region Property
        #endregion

        #region Constructor
        public Member(int id, string name, int tlf, string email, string address) : base(id, name, tlf, email, address)
        {
        }
        #endregion

        #region Methods
        // This method overrides the base ConsoleWriteLine
        public override string ToString()
        {
            return $"Id: {Id}" + $"\nName: {Name}" + $"\nTlf: {Tlf}" + $"\nEmail: {Email}" + $"\nAddress: {Address}\n";
        }
        #endregion
    }
}
