﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSailingClubClassLibrary
{
    public class EventList
    {
        List<Events> List = new List<Events>();

        //Method which adds an activity to the List.
        public void AddActivity(Events events)
        {
            List.Add(events);
        }

        //Method which deletes an activtity from the list.
        public void DeleteActivity(Events events)
        {
            List.Remove(events);
        }

        //Method which finds a specific activity, by searching for an activitys Id in the list and then returns that activity.  
        public Events? GetEvents(int id)
        {
            foreach (var events in List)
            {
                if (events.Id == id)
                    return events;
            }
            return null;
        }

        //Method which updates an activity, by using the GetActivity method to find a specific activity and then changing that activitys parameters.
        public void UpdateEvents(Events events, string name, string description, int year, int month, int day)
        {
            var theEvents = GetEvents(events.Id);
            if (theEvents != null)
            {
                theEvents.Name = name;
                theEvents.Description = description;
                theEvents.Date = new DateTime(year, month, day);
            }
        }

        //Method which goes through the old list(List) by searching for either a name or a description and is than added to the new empty list(activities) of all the activities, either with big or small lette.
        public List<Events> SearchEvents(string keyWord)
        {
            List<Events> evented = new List<Events>();
            foreach (Events events in List)
            {
                if (events.Name.ToLower().Contains(keyWord.ToLower()) || events.Description.ToLower().Contains(keyWord.ToLower()))
                {
                    evented.Add(events);
                }
            }
            return evented;
        }


        //Method which prints out every activity.
        public void ListPrint()
        {
            foreach (var events in List)
            {
                Console.WriteLine(events);
            }
        }
    }
}