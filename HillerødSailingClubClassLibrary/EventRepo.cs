using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSailingClubClassLibrary
{
    public class EventRepo
    {
        List<Event> EventsList = new List<Event>();

        //Method which adds an activity to the list.
        public bool AddEvents(Event events)
        {
            if (!EventsList.Contains(events))
            {
                EventsList.Add(events);
                return true;
            }
           return false;
        }

        //Method which deletes an activtity from the list.
        public bool DeleteEvents(int id)
        {
            Event events = GetEvent(id);
            if (EventsList.Contains(events))
            {
                EventsList.Remove(events);
                return true;
            }
            return false;
        }

        //Method which updates an event, by using the GetActivity method to find a specific event and then changing that events parameters.
        public Event UpdateEvents(int id, string name, string description, int year, int month, int day, int hour, int minute, int second)
        {
            var theEvents = GetEvent(id);
            if (theEvents != null)
            {
                theEvents.Name = name;
                theEvents.Description = description;
                theEvents.Date = new DateTime(year, month, day, hour, minute, second);
            }
            return theEvents;
        }

        //Method which goes through the old list(List) by searching for either a name or a description and is than added to the new empty list(activities) of all the activities, either with big or small lette.
        public List<Event> SearchEvents(string keyWord)
        {
            List<Event> evented = new List<Event>();
            foreach (Event events in EventsList)
            {
                if (events.Name.ToLower().Contains(keyWord.ToLower()) || events.Description.ToLower().Contains(keyWord.ToLower()))
                {
                    evented.Add(events);
                }
            }
            return evented;
        }

        //Method which finds a specific event, by searching for an events Id in the list and then returns that event.  
        public Event? GetEvent(int id)
        {
            foreach (var events in EventsList)
            {
                if (events.Id == id)
                    return events;
            }
            return null;
        }


        //Method which prints out every object.
        public List<Event> GetAllEvents()
        {
            return EventsList;
        }
    }
}