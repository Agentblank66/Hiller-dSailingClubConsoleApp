using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSailingClubClassLibrary
{
    public class MemberDict
    {
        #region Properties
        // Creating a dictionary with the name Members, with Member objects
        Dictionary<int, Member> Members = new Dictionary<int, Member>();
        #endregion

        #region Constructor
        #endregion

        #region Methodes
        // This method trys to add a Member to the Members Dictionary
        public void AddMember(Member member)
        {
            Members.TryAdd(member.Id, member);
        }

        // This method removes a Member from the Dictionay if Member given exist in Menmbers
        public void DeleteMember(Member member)
        {
            if (Members.ContainsKey(member.Id))
            {
                Members.Remove(member.Id);
            }
        }

        // This method looks after a Member with a matching Id, then returns that Member
        // If a Member don't exist with that Id it returns null
        public Member? GetMember(int Id)
        {
            if (Members.ContainsKey(Id))
            {
                return Members[Id];
            }
            else
            {
                return null;
            }
        }

        // This method wants a Member and the new infmation pertaining to that Member, then overrides the old information
        public void UpdateMember(Member member, string newAddress, string newName, string newEmail, int newTlf)
        {
            if (Members.ContainsKey(member.Id))
            {
                member.Address = newAddress;
                member.Name = newName;
                member.Email = newEmail;
                member.Tlf = newTlf;
            }
        }

        // This method goes through the Members Dictionary and prints them all out
        public List<Member> PrintAllMembers()
        {
            return Members.Values.ToList();
        }
        #endregion
    }
}
