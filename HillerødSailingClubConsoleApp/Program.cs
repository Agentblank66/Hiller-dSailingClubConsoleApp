// See https://aka.ms/new-console-template for more information
using HillerødSailingClubClassLibrary;
using HillerødSialingClub;
using System.Diagnostics;

Boat boat = new Boat(1, 11.30, "Volvo D2-40 37HP", 2016, "Dehler 38", "Cruiser/Racer", 234, "Berit");
Boat boat2 = new Boat(2, 3, "Årer", 2022, "Walkerbay", "Plast Jolle", 652, "Ralle");
Boat boat3 = new Boat(3, 13, "Yanmar 4JH57 57HP", 2019, "Arcona 435 Carbon", "Cruiser/Racer", 472, "Sandra");
Blog blog = new Blog(1, "blogTitel", "text text text");
// booking create 
Employee employee = new Employee("Kunde", 1, "Casper", 42418990, "test@mail.com", "addresseTest1");
Member member = new Member(1, "Casper", 42418990, "test@mail.com", "addresseTest1");

Booking booking = new Booking(0, member, boat, 2024, 12, 24);
BookingList bookingList = new BookingList();
bookingList.BookBoat(booking);
Console.WriteLine(bookingList.GetBookedBoat(0));
bookingList.UpdateBookedBoat(booking, member, boat, 2025, 01, 01);
bookingList.PrintAllBookedBoats();

BoatDict boatDict = new BoatDict();


//Test of Event methods:
Events event1 = new Events(1, "Juleaften", "Der holdes juleaften event.", 2024, 12, 24);
Events event2 = new Events(2, "Påske", "Der holdes påskefrokost.", 2024, 4, 5);
Events event3 = new Events(3, "Sommerstart", "Der fejres at sommeren begynder.", 2024, 6, 21);
EventList events = new EventList();
Console.WriteLine();

//Add events to Events List and then printing all events
Console.WriteLine("List of Events:");
events.AddEvents(event1);
Console.WriteLine();
events.AddEvents(event2);
Console.WriteLine();
events.AddEvents(event3);
List<Events> allEvents = events.GetAllEvents();
foreach(Events events1 in allEvents) Console.WriteLine(events1);
Console.WriteLine();

//Update an event and the showing that one event
Console.WriteLine("Update of Event:");
events.UpdateEvents(1, "Juleaften", "Der holdes Juleaften.", 2025, 12, 24);
Console.WriteLine(events.GetEvents(1)); 
Console.WriteLine();

//Snak med henrik om search metode, selvom den er blevet lavet, hør hvorfor man skal gøre på denne måde
Console.WriteLine("Search of Events with, holdes, in the description:");
List<Events> eventlist = events.SearchEvents("holdes");
foreach(Events Events in eventlist) Console.WriteLine(Events);
Console.WriteLine();

//Delete event and then showing the remaining events
Console.WriteLine("Delete of event3 and the new EventList shown:");
events.DeleteEvents(3);
List<Events> allevents = events.GetAllEvents();
foreach (Events events1 in allevents) Console.WriteLine(events1);
Console.WriteLine();

//Member joins an event.
Console.WriteLine("Member joins event1:");
List<Events> joinEvent = new List<Events>();
event1.JoinEvent(member);
Console.WriteLine(events.GetEvents(1));
Console.WriteLine(event1.ShowLastMember());
foreach (Events joinevent1 in joinEvent) Console.WriteLine(joinevent1);
Console.WriteLine();

Console.WriteLine(boat);
Console.WriteLine(event1);
Console.WriteLine(blog);


//  Boat
boat.AddToMaintenanceLog("testtexttoMaintencelog");
boat.RequestRepairs("testtextToReapairlog");
boat.PrintMaintenanceLog();
boat.PrintRepairsLog();

// BoatDict
boatDict.Add(boat);
boatDict.Add(boat2);
boatDict.Add(boat3);
boatDict.PrintAllBoat();
boatDict.Update(1, "type", "model", "name", 123, "engineinfo", 12, 1990);
boatDict.PrintAllBoat();
boatDict.GetBoat(1);
boatDict.GetBoat(2);
boatDict.GetBoat(3);
boatDict.DeleteBoat(1);
boatDict.PrintAllBoat();
