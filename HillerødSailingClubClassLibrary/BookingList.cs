﻿using HillerødSialingClub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSailingClubClassLibrary
{
    public class BookingList
    {
        #region Properties
        List<Booking> BookedBoats = new List<Booking>();
        #endregion

        #region Methods
        //This method adds the a booking of a boat with to a list of all bookedboats
        public void BookBoat(Booking booking)
        {
            BookedBoats.Add(booking);
        }

        //This method removes a bookedboat from the Bookedboat list
        public void RemoveBookedBoat(Booking booking)
        {
            if (BookedBoats.Contains(booking))
            {
                BookedBoats.Remove(booking);
            }
        }

        //This method searches the BookedBoat list after a booking with a matching id
        public Booking? GetBookedBoat(int id)
        {
            foreach (Booking booking in BookedBoats)
            {
                if (booking.Id.Equals(id))
                {
                    return BookedBoats[id];
                }
            }
            return null;
        }

        // This method takes a booking object and checks if BookedBoats list contains a object with a matching Id, then overrids the old information with the new one
        public void UpdateBookedBoat(Booking booking, Member newMember, Boat newBoat, int newYear, int newMonth, int newDay)
        {
            if (BookedBoats.Contains(booking)) 
            {
                booking.Boat = newBoat;
                booking.Member = newMember;
                booking.DateTime = new DateTime (newYear, newMonth, newDay);
            }
        }

        // This method goes through the BookedBoats list and printout all booking objects
        public void PrintAllBookedBoats()
        {
            foreach (var booking in BookedBoats)
            {
                Console.WriteLine(booking);
            }
        }

        #endregion
    }
}
