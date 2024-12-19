using HillerødSialingClub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSailingClubClassLibrary
{
    public class BookingRepo
    {
        #region Properties
        List<Booking> Bookings = new List<Booking>();
        #endregion

        #region Methods
        //This method adds the a booking of a boat with to a list of all bookedboats
        public void BookBoat(Booking booking)
        {
            Bookings.Add(booking);
        }

        //This method removes a bookedboat from the Bookedboat list
        public void RemoveBookedBoat(Booking booking)
        {
            if (Bookings.Contains(booking))
            {
                Bookings.Remove(booking);
            }
        }

        //This method searches the BookedBoat list after a booking with a matching id
        public Booking? GetBookedBoat(int id)
        {
            foreach (Booking booking in Bookings)
            {
                if (booking.Id.Equals(id))
                {
                    return booking;
                }
            }
            return null;
        }

        // This method takes a booking object and checks if Bookings list contains a object with a matching Id, then overrids the old information with the new one
        public void UpdateBookedBoat(Booking booking, Member newMember, Boat newBoat, int newYear, int newMonth, int newDay)
        {
            if (Bookings.Contains(booking)) 
            {
                booking.Boat = newBoat;
                booking.Member = newMember;
                booking.DateTime = new DateTime (newYear, newMonth, newDay);
            }
        }

        // This method goes through the Bookings list and printout all booking objects
        public List<Booking> PrintAllBookedBoats()
        {
            return Bookings;
        }

        /* This method goes through all booking objects in the Bookings dictionary and checking
        whether the current time is later or equal to booking time plus 2 hours and 30 minutes.
        If true then we start the search, if the loope never returns anything another thing is returned */
        public string RescueMember()
        {
            foreach (Booking booking1 in Bookings)
            {
                if (DateTime.Now >= booking1.DateTime.AddHours(2).AddMinutes(30))
                {
                    return "Igangsæt eftersøgning";
                }
            }
            return "Medlem er kommet retur";
        }

        /* This method starts by creating a new list, then goes through all objects in Bookings
         dictionary, takes the Member objects and adds them to the new list and returns that list */
        public List<Member> MembersSailing()
        {
            List<Member> membersSailing = new List<Member>();
            foreach(Booking booking in Bookings)
            {
                membersSailing.Add(booking.Member);
            }
            return membersSailing;
        }
        #endregion
    }
}
