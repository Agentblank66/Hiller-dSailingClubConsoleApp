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
        public void BookBoat(Booking booking)
        {
            BookedBoats.Add(booking);
        }

        public void RemoveBookedBoat(Booking booking)
        {
            if (BookedBoats.Contains(booking))
            {
                BookedBoats.Remove(booking);
            }
        }


        public Booking? GetBookedBoat(int id)
        {
            foreach (Booking booking in BookedBoats)
            {
                if (BookedBoats.Contains(booking)) // TODO
                {
                    return BookedBoats[id];
                }
            }
            return null;
        }

        #endregion
    }
}
