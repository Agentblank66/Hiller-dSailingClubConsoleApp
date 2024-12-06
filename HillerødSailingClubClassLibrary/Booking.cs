using HillerødSialingClub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSailingClubClassLibrary
{
    public class Booking
    {
        #region Proterties
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public Member Member { get; }
        public Boat Boat { get; }
        #endregion

        #region Constructor
        public Booking(int id, DateTime dateTime, Member member, Boat boat)
        {
            Id = id;
            DateTime = dateTime;
            Member = member;
            Boat = boat;
        }
        #endregion

    }
}
