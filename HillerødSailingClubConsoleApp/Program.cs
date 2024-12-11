// See https://aka.ms/new-console-template for more information
using HillerødSailingClubClassLibrary;
using HillerødSialingClub;
using System.Diagnostics;

// Creating Boat Objects:
Boat boat = new Boat(1, 11.30, "Volvo D2-40 37HP", 2016, "Dehler 38", "Cruiser/Racer", 234, "Berit");
Boat boat2 = new Boat(2, 3, "Årer", 2022, "Walkerbay", "Plast Jolle", 652, "Ralle");
Boat boat3 = new Boat(3, 13, "Yanmar 4JH57 57HP", 2019, "Arcona 435 Carbon", "Cruiser/Racer", 472, "Sandra");

// Creating Blog objects:
Blog blog = new Blog(1, "blogTitel", "text text text");

// Creating Employee Objects:
Employee employee = new Employee("Kunde", 1, "Casper", 42418990, "test@mail.com", "addresseTest1");

// Creating Member Objects:
Member member = new Member(1, "Casper", 42418990, "test1@mail.com", "addresseTest1");
Member member2 = new Member(2, "Oliver", 34568913, "test2@mail.com", "addresseTest2");
Member member3 = new Member(3, "Rasmus", 12457801, "test3@mail.com", "addresseTest3");
Member member4 = new Member(4, "Martin", 15609284, "test4@mail.com", "addresseTest4");

// Testing Member Methods:
MemberDict memberDict = new MemberDict();

    // Start by adding members to the memberDict Dictionary
    memberDict.AddMember(member);
    memberDict.AddMember(member2);
    memberDict.AddMember(member3);
    memberDict.AddMember(member4);

    // Deleting a member from the memberDict Dictionary
    memberDict.DeleteMember(member4);

    // Getting member 3 and 4, but 4 was deleted above so it will not get printed out
    Console.WriteLine(memberDict.GetMember(3));
    Console.WriteLine(memberDict.GetMember(4));

    // Updating member and member4, but member4 don't exist
    memberDict.UpdateMember(member, "AddressTest0", "Kasper", "test0@mail.com", 43518990);
    memberDict.UpdateMember(member4, "AddressTest4", "martin", "Test4@mail.com", 16758933);

    // Printing out all members in the memberDict Dictionary
    memberDict.PrintAllMembers();

// Creating Booking Objects:
Booking booking = new Booking(0, member, boat, 2024, 12, 24);
Booking booking2 = new Booking(1, member2, boat2, 2024, 12, 26);
Booking booking3 = new Booking(2, member3, boat3, 2024, 12, 31);

// Testing Booking methods:
BookingList bookingList = new BookingList();
    
    // Start by adding Booking object to the bookingList
    bookingList.BookBoat(booking);
    bookingList.BookBoat(booking2);
    bookingList.BookBoat(booking3);

    // Deleting a Booking object from the bookingList
    bookingList.RemoveBookedBoat(booking2);

    // Getting booking 0 and 2, but 2 was deleted above
    Console.WriteLine(bookingList.GetBookedBoat(0));
    Console.WriteLine(bookingList.GetBookedBoat(1));

    // Updating the booking object
    bookingList.UpdateBookedBoat(booking, member, boat, 2025, 01, 01);
    
    // Printing all bookings out
    bookingList.PrintAllBookedBoats();


//Test of Event methods:
Events event1 = new Events(1, "Juleaften", "Der holdes juleaften event.", 2024, 12, 24, 18, 00, 00);
Events event2 = new Events(2, "Påske", "Der holdes påskefrokost.", 2024, 4, 5, 13, 00, 00);
Events event3 = new Events(3, "Sommerstart", "Der fejres at sommeren begynder.", 2024, 6, 21, 17, 30, 00);
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
events.UpdateEvents(1, "Juleaften", "Der holdes Juleaften.", 2025, 12, 24, 18, 00, 00);
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

// Boat
Console.WriteLine();
Console.WriteLine("Boat Part");
boat.AddToMaintenanceLog("testtexttoMaintencelog");
boat.RequestRepairs("testtextToReapairlog");
Console.WriteLine(boat.PrintMaintenanceLog());
Console.WriteLine();
Console.WriteLine(boat.PrintRepairsLog());

// BoatDict
BoatDict boatDict = new BoatDict();
boatDict.Add(boat);
boatDict.Add(boat2);
boatDict.Add(boat3);
Console.WriteLine(boatDict.PrintAllBoat());
boatDict.Update(1, "type", "model", "name", 123, "engineinfo", 12, 1990);
Console.WriteLine(boatDict.PrintAllBoat());
Console.WriteLine(boatDict.GetBoat(1));
Console.WriteLine(boatDict.GetBoat(2));
Console.WriteLine(boatDict.GetBoat(3));
boatDict.DeleteBoat(1);
Console.WriteLine(boatDict.PrintAllBoat());
