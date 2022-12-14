using CodingEvents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
    
    namespace CodingEvents.Data
{
    public class EventData
    {
        //store events
         static private Dictionary<int, Event> Events = new Dictionary<int, Event>();

        public static void Add(Event newEvent)
        {
            Events.Add(newEvent.Id, newEvent);
        }
        public static IEnumerable<Event> GetAll()
        {
            return Events.Values;
        }
        public static Event GetById( int id)
        {
            return Events[id];
        }
        public static void Remove(int id)
        {
            Events.Remove(id);
        }

       //add events
       //retrieve the events
       //retrieve a single event
       //remove an event
    }
}
