using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSailingClubClassLibrary
{
    public class Events
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        List<Member> Participants = new List<Member>();

        public Events(int id, string name, string description, int year, int month, int day)
        {
            Id = id;
            Name = name;
            Description = description;
            Date = new DateTime(year, month, day);
        }

        //Method which overrrides the base ConsoleWriteLine
        public override string ToString()
        {
            return $"Id: {Id} \nName: {Name} \nDescription: {Description} \nDate: {Date}";
        }

        //Method which adds a member to an activity, by chechking if the activity is valid and makes sure the same member can't join mulitple times. 
        public void JoinEvent(Member member)
        {
            if (!Participants.Contains(member))
            {
                Participants.Add(member);
            }
        }

        //Method which looks at list Participants and uses .Count, which looks at all the objects in the list, and minuses with 1, to account for that it starts at 0, and then shows the object.
        public Member? ShowLastMember() 
        { 
            return Participants[Participants.Count-1];
        }
    }
}
