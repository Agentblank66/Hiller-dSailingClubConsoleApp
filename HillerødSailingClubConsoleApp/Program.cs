// See https://aka.ms/new-console-template for more information
using HillerødSailingClubClassLibrary;
using HillerødSialingClub;
using System.Diagnostics;
using System.Xml.Serialization;

// --------------------------- Boat --------------------------------
// Creating Boat Objects:
Boat boat = new Boat(1, 11.30, "Volvo D2-40 37HP", 2016, "Dehler 38", "Cruiser/Racer", 234, "Berit");
Boat boat2 = new Boat(2, 3, "Årer", 2022, "Walkerbay", "Plast Jolle", 652, "Ralle");
Boat boat3 = new Boat(3, 13, "Yanmar 4JH57 57HP", 2019, "Arcona 435 Carbon", "Cruiser/Racer", 472, "Sandra");
Console.WriteLine();
Console.WriteLine("Boat Part");
// Add string to the Two lists on object boat 
// get the two lists printed out
Console.WriteLine("get the two lists printed out:");
boat.AddToMaintenanceLog("testtexttoMaintencelog");
boat.RequestRepairs("testtextToReapairlog");
boat.AddToMaintenanceLog("testtexttoMaintencelog");
boat.RequestRepairs("testtextToReapairlog");
Console.WriteLine(boat.PrintMaintenanceLog());
Console.WriteLine(boat.PrintRepairsLog() + "\n");


// --------------------------- BoatRepo ---------------------------------
// creates object of BoatDict and adds 3 boats to the Dictioonary
Console.WriteLine("BoatDict Part:");
BoatRepo boatRepo = new BoatRepo();
boatRepo.Add(boat);
boatRepo.Add(boat2);
boatRepo.Add(boat3);

// Prints All boats from the Dictioonary
Console.WriteLine("Prints All boats from the Dictioonary:");
Console.WriteLine(boatRepo.PrintAllBoat() + "\n");

// Creating Blogs Dictionary 
BlogRepo Blogs = new BlogRepo();

// Updates Boat with Id: 1 
boatRepo.Update(1, "type", "model", "name", 123, "engineinfo", 12, 1990);

// Get metode on 3 Boats 
Console.WriteLine("\n" + "Get metode on 3 Boats:");
Console.WriteLine(boatRepo.GetBoat(1));
Console.WriteLine(boatRepo.GetBoat(2));
Console.WriteLine(boatRepo.GetBoat(3));

// Delete() on Boat with Id: 1 && PrintAllBoat
Console.WriteLine("\n" + "Delete() Boat with Id: 1 && PrintAllBoat:");
boatRepo.DeleteBoat(1);
Console.WriteLine(boatRepo.PrintAllBoat());


// --------------------------- MemberRepo --------------------------------
Console.WriteLine("\n---------------------------------------MemberRepo------------------------------------");
// Creating Member Objects:
Member member = new Member(1, "Casper", 42418990, "test1@mail.com", "addresseTest1");
Member member2 = new Member(2, "Oliver", 34568913, "test2@mail.com", "addresseTest2");
Member member3 = new Member(3, "Rasmus", 12457801, "test3@mail.com", "addresseTest3");
Member member4 = new Member(4, "Martin", 15609284, "test4@mail.com", "addresseTest4");

// Testing Member Methods:
MemberRepo memberRepo = new MemberRepo();

    // Start by adding members to the memberDict Dictionary
    memberRepo.AddMember(member);
    memberRepo.AddMember(member2);
    memberRepo.AddMember(member3);
    memberRepo.AddMember(member4);
    Console.WriteLine("\nPrinting out all Members in the Dictionary memberRepo:\n");
    PrintMembers();

    // Deleting a member from the memberDict Dictionary
    memberRepo.DeleteMember(member4);
    Console.WriteLine("\nPrinting out memberReop after removeing member4\n");
    PrintMembers();

    // Getting member 3 and 4, but 4 was deleted above so it will not get printed out
    Console.WriteLine("\nPrinting out the member with Key 3 and 4:\n");
    Console.WriteLine(memberRepo.GetMember(3));
    Console.WriteLine("member4 ain't printed out, because it was deleted earlier\n");
    Console.WriteLine(memberRepo.GetMember(4));

    // Updating member and member4, but member4 don't exist
    Console.WriteLine("Printing out the updated member\n");
    memberRepo.UpdateMember(member, "AddressTest0", "Kasper", "test0@mail.com", 43518990);
    Console.WriteLine(memberRepo.GetMember(1));

    // Printing out all members in the memberDict Dictionary
    Console.WriteLine("\nPrinting out all members\n");
    PrintMembers();


// --------------------------- BookingRepo --------------------------------
Console.WriteLine("\n----------------------------------------BookingRepo-----------------------------------");
// Creating Booking Objects:
Booking booking = new Booking(0, member, boat, 2024, 12, 24, 12, 56, 58);
Booking booking2 = new Booking(1, member2, boat2, 2024, 12, 26, 12, 56, 58);
Booking booking3 = new Booking(2, member3, boat3, 2024, 12, 31, 12, 56, 58);

// Testing Booking methods:
BookingRepo bookingRepo = new BookingRepo();
    
    // Start by adding Booking object to the bookingList
    bookingRepo.BookBoat(booking);
    bookingRepo.BookBoat(booking2);
    bookingRepo.BookBoat(booking3);
    Console.WriteLine("\nPrinting out alle booking objects in bookingRepo:\n");
    PrintBookings();

    // Deleting a Booking object from the bookingList
    bookingRepo.RemoveBookedBoat(booking2);
    Console.WriteLine("\nPrinting out all bookings, after booking2 has been removed:\n");
    PrintBookings();

    // Getting booking and booking2, but booking2 was deleted above
    Console.WriteLine("\nPrintng out booking and booking2");
    Console.WriteLine(bookingRepo.GetBookedBoat(0));
    Console.WriteLine(bookingRepo.GetBookedBoat(1));
    Console.WriteLine("booking2 is not printed out, because it was removed earlier\n");

    // Updating the booking object
    Console.WriteLine("Updating booking object and printing it out:");
    bookingRepo.UpdateBookedBoat(booking, member, boat, 2025, 01, 01);
    Console.WriteLine(bookingRepo.GetBookedBoat(0));

    // Printing all bookings out
    PrintBookings();

    // Starting a rescue of a missing member
    Console.WriteLine(bookingRepo.RescueMember());

    // Getting all members that are out sailing
    PrintSailingMembers(bookingRepo.MembersSailing());


// --------------------------- EventRepo --------------------------------
// Creating Event objects:
Event event1 = new Event(1, "Juleaften", "Der holdes juleaften event.", 2024, 12, 24, 13, 49, 30);
Event event2 = new Event(2, "Påske", "Der holdes påskefrokost.", 2024, 4, 5, 13, 49, 30);
Event event3 = new Event(3, "Sommerstart", "Der fejres at sommeren begynder.", 2024, 6, 21, 13, 49, 30);

//Testing EventList methods:
EventRepo events = new EventRepo();

    // Starting by adding multiple event to events list, then showing them
    events.AddEvents(event1);
    events.AddEvents(event2);
    events.AddEvents(event3);
    Console.WriteLine(events);

//Update an event and the showing that one event
Console.WriteLine("Update of Event:");
events.UpdateEvents(1, "Juleaften", "Der holdes Juleaften.", 2025, 12, 24, 13, 49, 30);
Console.WriteLine(events.GetEvents(1)); 
Console.WriteLine();

    // Here we will search after a specific event with "holdes" in the description
    foreach (Event Events in events.SearchEvents("holdes")) Console.WriteLine(Events); // Ask Tomorrow
    Console.WriteLine();

    // Here we will get all events in the events list
    foreach (Event events1 in events.GetAllEvents()) Console.WriteLine(events1);
    Console.WriteLine();

// --------------------------- JoinRepo --------------------------------
// Testing joinedRepo Methods:
JoinRepo membersjoined = new JoinRepo();
Join joiner1 = new Join(1, member, event1);
Join joiner2 = new Join(2, member2, event2);
Join joiner3 = new Join(3, member3, event3);

//Add member to list and printing all
membersjoined.JoinEvent(member);
membersjoined.JoinEvent(member2);
membersjoined.JoinEvent(member3);
Console.WriteLine("List of members joining event:");
foreach (Member joinedMembers in membersjoined.GetAllJoinedMember()) Console.WriteLine(joinedMembers);
Console.WriteLine();

//Showing the last member to join the event/list
Console.WriteLine("The last member to join event:");
Console.WriteLine(membersjoined.ShowLastMember());
Console.WriteLine();

//Delte a member that has joined, then shwo the list
Console.WriteLine("Delete a member from the list, then show the remaining:");
membersjoined.DeleteMemberInEvent(member);
foreach (Member joinedMembers in membersjoined.GetAllJoinedMember()) Console.WriteLine(joinedMembers);
Console.WriteLine();

// --------------------------- BlogRepo --------------------------------
// Creating Blog objects:
Blog blog = new Blog(1, "blogTitel", "text text text");
Blog blog2 = new Blog(2, "blogTitel2", "text text text2");
Blog blog3 = new Blog(3, "blogTitel3", "text text text3");

// Delete() on Boat with Id: 1 && PrintAllBoat
Console.WriteLine("\n" + "Delete() Boat with Id: 1 && PrintAllBoat:");
boatRepo.DeleteBoat(1);
Console.WriteLine(boatRepo.PrintAllBoat());

// add to Dictionary
Blogs.AddBlogPost(blog);
Blogs.AddBlogPost(blog2);
Blogs.AddBlogPost(blog3);

// Get blog by Id update and get again 

Console.WriteLine( Blogs.GetBlogPost(1));
Blogs.UpdateBlogPost( blog2, 1, "updatedText text", "newtext test");
Console.WriteLine( Blogs.GetBlogPost(1));

// delete blog with Id 1
Blogs.DeleteBlogPost(1);
Console.WriteLine(Blogs.GetBlogPost(1) + " deleted here");

// Search blog
Console.WriteLine( Blogs.SearchBlog("blog"));
Console.WriteLine(Blogs.SearchBlog("Din"));
// --------------------------- EmployeeRepo --------------------------------
// Creating Employee Objects:
Employee employee = new Employee("Kunde", 1, "Casper", 42418990, "test@mail.com", "addresseTest1");

Employee employee1 = new Employee("Kunde", 1, "Preben", 45324567, "Preben@mail.com", "Ondstorkevej 2");
//employee.RescueMember(bookingList);

//Update employee with new employee
EmployeeRepo employeeDict = new EmployeeRepo();
employeeDict.Add(employee);
employeeDict.Add(employee1);
employeeDict.Update(employee, "Anders Andersen", 4655532, "BaskMig@gmail.com", "OndPræstevej");
Console.WriteLine(employee);
// ---------------------------Function----------------------------------------
void PrintMembers()
{
    foreach (Member member in memberRepo.PrintAllMembers()) Console.WriteLine(member);
}
void PrintBookings()
{
    foreach (Booking booking in bookingRepo.PrintAllBookedBoats()) Console.WriteLine(booking);
}
void PrintSailingMembers(List<Member> membersSailing)
{
    foreach (Member member in membersSailing) Console.WriteLine(member);
}