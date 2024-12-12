using HillerødSialingClub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSailingClubClassLibrary
{
    internal class JoinedRepo
    {
        List<Member> Participants = new List<Member>();

        public int Id { get; set; }
        public Member Member { get; set; }
        public Events Events { get; set; }

        public JoinedRepo(int id, Member member, Events events)
        {
            Id = id;
            Member = member;
            Events = events;
        }

        public override string ToString()
        {
            return $"Id: {Id} \nMember: {Member} \nEvents: {Events}";
        }

        //A method which adds a member from a list, by chechking if the member hasnt joined already, then adds that member. 
        public void JoinEvent(Member member)
        {
            if (!Participants.Contains(member))
            {
                Participants.Add(member);
            }
        }

        //A method which looks at list Participants and uses .Count, which looks at all the objects in the list, and minuses with 1, to account for that it starts at 0, and then shows the object.
        public Member? ShowLastMember()
        {
            return Participants[Participants.Count - 1];
        }

        //A method which removes a member from a list, by chechking if the member has joined already, then removes that member. 
        public void DeleteMemberInEvent(Member member)
        {
            if (Participants.Contains(member))
            {
                Participants.Remove(member);
            }
        }
    }
}
