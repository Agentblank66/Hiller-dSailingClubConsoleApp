﻿using HillerødSialingClub;
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
        public bool JoinEvent(Join join)
        {
            if (!Participants.Contains(join))
            {
                Participants.Add(join);
                return true;
            }
            return false;
        }

        //A method which looks at list Participants and uses .Count, which looks at all the objects in the list, and minuses with 1, to account for that it starts at 0, and then shows the object.
        public Join? ShowLastMemberAndEvent()
        {
            return Participants[Participants.Count - 1];
        }

        //A method which removes a member from a list, by chechking if the member has joined already, then removes that member. 
        public bool DeleteMemberInEvent(Join join)
        {
            if (Participants.Contains(join))
            {
                Participants.Remove(join);
                return true;
            }
            return false;
        }


        public List<Join> GetAllJoinedMember()
        {
            return Participants;
        }
            
    }
}
