﻿using HillerødSialingClub;
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
        public Booking(int id, Member member, Boat boat, int year, int month, int day)
        {
            Id = id;
            DateTime = new DateTime(year, month, day);
            Member = member;
            Boat = boat;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Id: {Id}" + $"\nMember: {Member}" + $"\nBoat: {Boat}" + $"\nDate: {DateTime}";
        }
        #endregion
    }
}
