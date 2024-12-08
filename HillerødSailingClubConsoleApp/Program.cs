﻿// See https://aka.ms/new-console-template for more information
using HillerødSailingClubClassLibrary;
using HillerødSialingClub;
using System.Diagnostics;

Boat boat = new Boat(1, 4, "Båd Navn", 2000, "Benut", "Macedes", 234, "Julie");
Blog blog = new Blog(1, "blogTitel", "text text text");
// booking create 
Employee employee = new Employee("Kunde", 1, "Casper", 42418990, "test@mail.com", "addresseTest1");
Member member = new Member(1, "Casper", 42418990, "test@mail.com", "addresseTest1");

Booking booking = new Booking(0, member, boat, 2024, 12, 24);
BookingList bookingList = new BookingList();
bookingList.BookBoat(booking);
Console.WriteLine(bookingList.GetBookedBoat(0));

BoatDict boatDict = new BoatDict();

//Test of Event methods:
Events event1 = new Events(1, "Juleaften", "Der holdes juleaften event.", 2024, 12, 24);
Events event2 = new Events(2, "Påske", "Der holdes påskefrokost.", 2024, 4, 5);
Events event3 = new Events(3, "Sommerstart", "Der fejres at sommeren begynder.", 2024, 6, 21);
EventList events = new EventList();
Console.WriteLine();
Console.WriteLine("List of Events:");
events.AddEvents(event1);
events.AddEvents(event2);
events.AddEvents(event3);
events.ListPrint();
Console.WriteLine();
Console.WriteLine("Update of Event:");
events.UpdateEvents(event1, "Juleaften", "Der holdes Juleaften.", 2025, 12, 24);
Console.WriteLine(events.GetEvents(1)); 
Console.WriteLine();
//Snak med henrik om search metode, selvom den er blevet lavet, hør hvorfor man skal gøre på denne måde
Console.WriteLine("Search of Events with, holder, in the description:");
List<Events> eventlist = events.SearchEvents("holdes");
foreach(Events Events in eventlist) Console.WriteLine(Events);
Console.WriteLine();
Console.WriteLine("Delete of event3 and the new EventList shown:");
events.DeleteEvents(event3);
events.ListPrint();
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
boatDict.PrintAllBoat();
boatDict.Update(1, "type", "model", "name", 123, "engineinfo", 12, 1990);
boatDict.PrintAllBoat();
boatDict.GetBoat(1);
boatDict.GetBoat(2);
boatDict.DeleteBoat(1);
boatDict.PrintAllBoat();
