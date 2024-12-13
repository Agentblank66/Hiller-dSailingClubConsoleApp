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


// --------------------------- BoatDict ---------------------------------
// creates object of BoatDict and adds 3 boats to the Dictioonary
Console.WriteLine("BoatDict Part:");
BoatDict boatDict = new BoatDict();
boatDict.Add(boat);
boatDict.Add(boat2);
boatDict.Add(boat3);

// Prints All boats from the Dictioonary
Console.WriteLine("Prints All boats from the Dictioonary:");
Console.WriteLine(boatDict.PrintAllBoat() + "\n");

// Creating Blogs Dictionary 
BlogDict Blogs = new BlogDict();

// Updates Boat with Id: 1 
boatDict.Update(1, "type", "model", "name", 123, "engineinfo", 12, 1990);

// Get metode on 3 Boats 
Console.WriteLine("\n" + "Get metode on 3 Boats:");
Console.WriteLine(boatDict.GetBoat(1));
Console.WriteLine(boatDict.GetBoat(2));
Console.WriteLine(boatDict.GetBoat(3));

// Delete() on Boat with Id: 1 && PrintAllBoat
Console.WriteLine("\n" + "Delete() Boat with Id: 1 && PrintAllBoat:");
boatDict.DeleteBoat(1);
Console.WriteLine(boatDict.PrintAllBoat());


// --------------------------- MemberDict --------------------------------
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
    PrintMembers(memberDict.PrintAllMembers());


// --------------------------- BookingList --------------------------------
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

    // Getting booking and booking2, but booking2 was deleted above
    Console.WriteLine(bookingList.GetBookedBoat(0));
    Console.WriteLine(bookingList.GetBookedBoat(1));

    // Updating the booking object
    bookingList.UpdateBookedBoat(booking, member, boat, 2025, 01, 01);

    // Printing all bookings out
    PrintBookings(bookingList.PrintAllBookedBoats());


// --------------------------- EventList --------------------------------
// Creating Event objects:
Events event1 = new Events(1, "Juleaften", "Der holdes juleaften event.", 2024, 12, 24, 13, 49, 30);
Events event2 = new Events(2, "Påske", "Der holdes påskefrokost.", 2024, 4, 5, 13, 49, 30);
Events event3 = new Events(3, "Sommerstart", "Der fejres at sommeren begynder.", 2024, 6, 21, 13, 49, 30);

//Testing EventList methods:
EventList events = new EventList();

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
    foreach (Events Events in events.SearchEvents("holdes")) Console.WriteLine(Events); // Ask Tomorrow
    Console.WriteLine();

    // Here we will get all events in the events list
    foreach (Events events1 in events.GetAllEvents()) Console.WriteLine(events1);
    Console.WriteLine();

// --------------------------- JoinerRepo --------------------------------
// Testing joinedRepo Methods:
JoinedRepo membersjoined = new JoinedRepo();
Joined joiner1 = new Joined(1, member, event1);
Joined joiner2 = new Joined(2, member2, event2);
Joined joiner3 = new Joined(3, member3, event3);

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

// --------------------------- BlogDict --------------------------------
// Creating Blog objects:
Blog blog = new Blog(1, "blogTitel", "text text text");
Blog blog2 = new Blog(2, "blogTitel2", "text text text2");
Blog blog3 = new Blog(3, "blogTitel3", "text text text3");

// Delete() on Boat with Id: 1 && PrintAllBoat
Console.WriteLine("\n" + "Delete() Boat with Id: 1 && PrintAllBoat:");
boatDict.DeleteBoat(1);
Console.WriteLine(boatDict.PrintAllBoat());

// ----------------------- Blog ---------------------------------------


// ----------------------- BlogDict ------------------------------------
// add to Dictionary
Blogs.AddBlogPost(blog);
Blogs.AddBlogPost(blog2);
Blogs.AddBlogPost(blog3);

// Get blog by Id update and get again 

Console.WriteLine( Blogs.GetBlogPost(1));
Blogs.UpdateBlogPost(1, "updatedTitel", "updatedText text");
Console.WriteLine( Blogs.GetBlogPost(1));

// delete blog with Id 1
Blogs.DeleteBlogPost(1);
Console.WriteLine(Blogs.GetBlogPost(1) + " deleted here");

// Search blog
Console.WriteLine( Blogs.SearchBlog("blog"));
Console.WriteLine(Blogs.SearchBlog("Din"));
// --------------------------- EmployeeDict --------------------------------
// Creating Employee Objects:
Employee employee = new Employee("Kunde", 1, "Casper", 42418990, "test@mail.com", "addresseTest1");


// ---------------------------Function----------------------------------------
void PrintMembers(List<Member> members)
{
    foreach (Member member in members) Console.WriteLine(member);
}
void PrintBookings(List<Booking> bookings)
{
    foreach (Booking booking in bookings) Console.WriteLine(booking);
}

