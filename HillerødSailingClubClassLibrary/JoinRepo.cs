using HillerødSialingClub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSailingClubClassLibrary
{
    public class JoinRepo
    {
        List<Join> Participants = new List<Join>();

        //A method which adds a member from a list, by chechking if the member hasnt joined already, then adds that member. 
        public void JoinEvent(Join join)
        {
            if (!Participants.Contains(join))
            {
                Participants.Add(join);
            }
        }

        //A method which looks at list Participants and uses .Count, which looks at all the objects in the list, and minuses with 1, to account for that it starts at 0, and then shows the object.
        public Join? ShowLastMember()
        {
            return Participants[Participants.Count - 1];
        }

        //A method which removes a member from a list, by chechking if the member has joined already, then removes that member. 
        public void DeleteMemberInEvent(Join join)
        {
            if (Participants.Contains(join))
            {
                Participants.Remove(join);
            }
        }


        public List<Join> GetAllJoinedMember()
        {
            return Participants;
        }
            
    }
}
