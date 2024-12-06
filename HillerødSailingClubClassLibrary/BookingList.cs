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
                if (booking.Id.Equals(id)) // TODO
                {
                    return BookedBoats[id];
                }
            }
            return null;
        }

        #endregion
    }
}
