using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSailingClubClassLibrary
{
    public class Joined
    {
        public int Id { get; set; }
        public Member Member { get; set; }
        public Event Events { get; set; }

        public Joined(int id, Member member, Event events)
        {
            Id = id;
            Member = member;
            Events = events;
        }

        public override string ToString()
        {
            return $"Id: {Id} \nMember: {Member} \nEvents: {Events}";
        }

    }
}
