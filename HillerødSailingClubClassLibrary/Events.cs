﻿using System;
using System.Collections.Generic;
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

        public Events(int id, string name, string description, int day, int month, int year)
        {
            Id = id;
            Name = name;
            Description = description;
            Date = new DateTime(day, month, year);
        }

        //Method which overrrides the base ConsoleWriteLine
        public override string ToString()
        {
            return $"Id: {Id} Name: {Name} Description: {Description} Date: {Date}";
        }

        //Method which adds a member to an activity, by chechking if the activity is valid and makes sure the same member can't join mulitple times. 
        public void JoinEvent(Member member, Events events)
        {
            if (events != null && !Participants.Contains(member))
            {
                Participants.Add(member);
            }

        }
    }
}
