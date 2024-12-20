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
        public bool AddBooking(Booking booking)
        {
            if (!Bookings.Contains(booking))
            {
                Bookings.Add(booking); 
                return true;
            }
            return false;
        }

        //This method removes a bookedboat from the Bookedboat list
        public Booking? RemoveBooking(Booking booking)
        {
            if (Bookings.Contains(booking))
            {
                Booking bookingCopy = booking;
                Bookings.Remove(booking);
                return bookingCopy;
            }
            return null;
        }

        //This method searches the BookedBoat list after a booking with a matching id
        public Booking? GetBooking(int id)
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
        public Booking? UpdateBooking(Booking booking, Member newMember, Boat newBoat, int newYear, int newMonth, int newDay, int newHour, int newMin, int newSec)
        {
            if (Bookings.Contains(booking)) 
            {
                booking.Boat = newBoat;
                booking.Member = newMember;
                booking.DateTime = new DateTime (newYear, newMonth, newDay, newHour, newMin, newSec);

                return booking;
            }
            return null;
        }

        // This method goes through the Bookings list and printout all booking objects
        public List<Booking> PrintAllBookings()
        {
            return Bookings;
        }

        /* This method goes through all booking objects in the Bookings dictionary and checking
        whether the current time is later or equal to booking time plus 2 hours and 30 minutes.
        If true then we start the search, if the loope never returns anything another thing is returned */
        public Booking? RescueMember()
        {
            foreach (Booking booking1 in Bookings)
            {
                if (DateTime.Now >= booking1.DateTime.AddHours(2).AddMinutes(30))
                {
                    return booking1;
                }
            }
            return null;
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
