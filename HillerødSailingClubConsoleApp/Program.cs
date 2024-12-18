// See https://aka.ms/new-console-template for more information
using HillerødSailingClubClassLibrary;
using HillerødSialingClub;
using System.Diagnostics;
using System.Xml.Serialization;

#region Boat
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
#endregion

#region BoatRepo
// --------------------------- BoatRepo ---------------------------------
// creates object of BoatDict and adds 3 boats to the Dictioonary
Console.WriteLine("BoatRepo Part:");
BoatRepo boatRepo = new BoatRepo();
boatRepo.Add(boat);
boatRepo.Add(boat2);
boatRepo.Add(boat3);



// Prints All boats from the Dictioonary
Console.WriteLine("Prints All boats from the Dictioonary:");
Console.WriteLine(boatRepo.PrintAllBoat() + "\n");

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


Console.WriteLine("---------------------------- fjerner og udsktiver");
Console.WriteLine(boatRepo.PrintAllBoat());
boatRepo.SendBoatToRepair(boat2, "Hul i Bunden");
Console.WriteLine("see all boats from boats list" + boatRepo.PrintAllBoat());
Console.WriteLine();
Console.WriteLine("print all boats from repair list" + boatRepo.PrintAllRepairBoats());
Console.WriteLine();
boatRepo.GetBoatFromRepair(boat2);
Console.WriteLine("see all boats from boats list" + boatRepo.PrintAllBoat());
Console.WriteLine("---------------------------- fjerner og udsktiver slut");





Console.WriteLine("End of BoatRepo \n ");
#endregion

#region MemberRepo
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
    Console.WriteLine("\nPrinting out memberReop after removeing member4:\n");
    PrintMembers();

    // Getting member 3 and 4, but 4 was deleted above so it will not get printed out
    Console.WriteLine("\nPrinting out the member with Key 3 and 4:\n");
    Console.WriteLine(memberRepo.GetMember(3));
    Console.WriteLine("Member4 ain't printed out, because it was deleted earlier:");
    Console.WriteLine(memberRepo.GetMember(4));

    // Updating member and member4, but member4 don't exist
    Console.WriteLine("Printing out the updated member:\n");
    memberRepo.UpdateMember(member, "AddressTest0", "Kasper", "test0@mail.com", 43518990);
    Console.WriteLine(memberRepo.GetMember(1));

    // Printing out all members in the memberDict Dictionary
    Console.WriteLine("\nPrinting out all members:\n");
    PrintMembers();
#endregion

#region BookingRepo
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
    Console.WriteLine("\nPrinting out all booking objects in bookingRepo:\n");
    PrintBookings();

    // Deleting a Booking object from the bookingList
    bookingRepo.RemoveBookedBoat(booking2);
    Console.WriteLine("\nPrinting out all bookings, after booking2 has been removed:\n");
    PrintBookings();

    // Getting booking and booking2, but booking2 was deleted above
    Console.WriteLine("\nPrintng out booking and booking2:\n");
    Console.WriteLine(bookingRepo.GetBookedBoat(0));
    Console.WriteLine("booking2 is not printed out, because it was removed earlier\n");
    Console.WriteLine(bookingRepo.GetBookedBoat(1));

    // Updating the booking object
    Console.WriteLine("Updating booking object and printing it out:\n");
    bookingRepo.UpdateBookedBoat(booking, member, boat, 2025, 01, 01);
    Console.WriteLine(bookingRepo.GetBookedBoat(0));

    // Printing all bookings out
    Console.WriteLine("\nPrinting out all booking objects:\n");
    PrintBookings();

    // Starting a rescue of a missing member
    Console.WriteLine("Printing out members that need rescueing!\n");
    Console.WriteLine(bookingRepo.RescueMember());

    // Getting all members that are out sailing
    Console.WriteLine("\nPrinting out all sailing memebers:\n");
    PrintSailingMembers(bookingRepo.MembersSailing());
    Console.WriteLine();
#endregion

#region EventRepo
Console.WriteLine("\n------------------------------------------------------EvenRepo----------------------------------------------------------");
// --------------------------- EventRepo --------------------------------
// Creating Event objects:
Event event1 = new Event(1, "Juleaften", "Der holdes juleaften event.", 2024, 12, 24, 13, 49, 30);
Event event2 = new Event(2, "Påske", "Der holdes påskefrokost.", 2024, 4, 5, 13, 49, 30);
Event event3 = new Event(3, "Sommerstart", "Der fejres at sommeren begynder.", 2024, 6, 21, 13, 49, 30);

//Testing EventList methods:
EventRepo events = new EventRepo();

// Starting by adding multiple event to events list, then showing them
Console.WriteLine();
    events.AddEvents(event1);
    events.AddEvents(event2);
    events.AddEvents(event3);
    Console.WriteLine("Here we are printing the list of all the events, which are added to the events list, by using the GetAllEvents() method:");
    foreach (Event events1 in events.GetAllEvents()) Console.WriteLine(events1);
    Console.WriteLine();

//Update an event and the showing that one event
    Console.WriteLine("Here we update an Event by using the UpdateEvents() method, and then we find that specific event to see the changes, by using the GetEvent() method:");
    events.UpdateEvents(1, "Juleaften", "Der holdes Juleaften.", 2025, 12, 24, 13, 49, 30);
    Console.WriteLine(events.GetEvent(1)); 
    Console.WriteLine();

    // Here we will search after a specific event with "holdes" in the description
    Console.WriteLine("Here we use a foreach-loop where we search for the word, holdes, in the events descriptions, and then return the events which has that word in the description, by using the SearchEvents() method. For every event, console WriteLine is called and that event is printed:");
    foreach (Event Events in events.SearchEvents("holdes")) Console.WriteLine(Events);
    Console.WriteLine();

    // Here we will get all events in the events list
    Console.WriteLine("Here we use a foreach-loop, where we print out all the events, by using the GetAllEvents() method. For every event, a console WriteLine is called and then that event is printed:");
    foreach (Event events1 in events.GetAllEvents()) Console.WriteLine(events1);
    Console.WriteLine();
#endregion

#region JoinRepo
Console.WriteLine("\n------------------------------------------------------JoinRepo----------------------------------------------------------");
// --------------------------- JoinRepo --------------------------------
// Testing joinedRepo Methods:
JoinRepo membersjoined = new JoinRepo();
Join joiner1 = new Join(1, member, event1);
Join joiner2 = new Join(2, member2, event2);
Join joiner3 = new Join(3, member3, event3);

//Add member to list and printing all
    Console.WriteLine();
    membersjoined.JoinEvent(member);
    membersjoined.JoinEvent(member2);
    membersjoined.JoinEvent(member3);
    Console.WriteLine("Her we use a foreach-loop to print out a list of members joining a event, by printing out all joined members with the GetAllJoinedMembers() method. For every member, a console WriteLine is called and then that member is printed:");
    foreach (Member joinedMembers in membersjoined.GetAllJoinedMember()) Console.WriteLine(joinedMembers);
    Console.WriteLine();

    //Showing the last member to join the event/list
    Console.WriteLine("Here we print out the last member to join an event:");
    Console.WriteLine(membersjoined.ShowLastMember());
    Console.WriteLine();

    //Delte a member that has joined, then shwo the list
    Console.WriteLine("Here we delete a member from the list, by using the DeleteMemberInEvent() method, and are then using a foreach-loop, where printing out the remaining members in the list with the GetAllJoinedMembers() method. For every member, a console WriteLine is called and then that member is printed:");
    membersjoined.DeleteMemberInEvent(member);
    foreach (Member joinedMembers in membersjoined.GetAllJoinedMember()) Console.WriteLine(joinedMembers);
    Console.WriteLine();
    Console.WriteLine();
#endregion

#region BlogRepo
// --------------------------- BlogRepo --------------------------------
Console.WriteLine("\n------------------------------------------------------BlogRepo----------------------------------------------------------");

// Creating Blogs Dictionary 
BlogRepo Blogs = new BlogRepo();

// Creating Blog objects:
Console.WriteLine("Here we print all the blogs:");
Console.WriteLine();
Blog blog = new Blog(1, "Garmin ur mistet", "Jeg har under sejladsen i dag, mistet mit ur. Jeg har snakket med ejeren af Hillerød Sejlklub, og han vil få fat på et dykkerhold som vil dykke ned i opgaven.");
Blog blog2 = new Blog(2, "Sommerfest?", "Jeg undersøger om der er stemning for vi holder en sommerfest. Der vil selvfølgelig blive sørget for fadølsanker, samt hoppeborg.");
Blog blog3 = new Blog(3, "Dagens rapport", "Henning røg over bord, og Torben kunne ikke holde det inde, og stod i lårefede stråler.");

// add to Dictionary
Blogs.AddBlogPost(blog);
Blogs.AddBlogPost(blog2);
Blogs.AddBlogPost(blog3);
Console.WriteLine("Blog 1");
Console.WriteLine(blog);
Console.WriteLine();
Console.WriteLine("Blog 2");
Console.WriteLine(blog2);
Console.WriteLine();
Console.WriteLine("Blog 3");
Console.WriteLine(blog3);
Console.WriteLine();

// Get blog by Id update and get again 

Console.WriteLine("Here we get Blog 1:");
Console.WriteLine( Blogs.GetBlogPost(1));
Console.WriteLine();
Console.WriteLine("Here we get blog 1, and update it:");
Blogs.UpdateBlogPost( blog, 1, "Jeg fandt uret!", "Allan og Mathias fandt uret tidligere i dag!");

// delete blog with Id 1
Console.WriteLine(blog);
Console.WriteLine();
Console.WriteLine(blog2);
Console.WriteLine();
Console.WriteLine(blog3);
Console.WriteLine("\n" +"Here we get blog 3, and delete it:");
Blogs.DeleteBlogPost(3);
Console.WriteLine(Blogs.GetAllBlogs()+"\n");


// Search blog
Console.WriteLine("\n" +"Here we use our search method, and searching by word. The first one will NOT show anything due to invalid input. The last one will show searched object:");
Console.WriteLine(Blogs.SearchBlog("Dagens rapport"));
Console.WriteLine();
Console.WriteLine(Blogs.SearchBlog("Sommerfest"));
// --------------------------- EmployeeRepo --------------------------------
// Creating Employee Objects:
Console.WriteLine("\n--------------------------------------------------EmployeeRepo----------------------------------------------------------");
Employee employee = new Employee("\n"+"Medarbejder", 1, "Torsten Jensen", 42418990, "Torstj@mail.com", "Midtvejskrigsvej 54");
Employee employee1 = new Employee("Medarbejder", 2, "Preben Larsen", 45324567, "Preben@mail.com", "Ondstorkevej 2");
Employee employee2 = new Employee("Medarbejder", 3, "Michael Antonsen", 43675473, "Micant@gmail.com", "Vildmarksvej 69");


//Update employee with new employee
EmployeeRepo employeeDict = new EmployeeRepo();
employeeDict.Add(employee);
employeeDict.Add(employee1);
employeeDict.Add(employee2);
Console.WriteLine("Here we print all the employees:");
Console.WriteLine();
Console.WriteLine("Employee 1:");
Console.WriteLine(employee);
Console.WriteLine();
Console.WriteLine("Employee 2:");
Console.WriteLine(employee1);
Console.WriteLine();
Console.WriteLine("Employee 3:");
Console.WriteLine(employee2);
Console.WriteLine();
Console.WriteLine("Here we've updated Employee 1, to a new member:");
employeeDict.Update(employee, "Anders Andersen", 4655532, "andand@gmail.com", "OndPræstevej");
Console.WriteLine(employee);

employeeDict.DeleteEmployee(2);
Console.WriteLine();
Console.WriteLine("Removing Employee 2:");
employeeDict.PrintAllEmployees();
#endregion

#region Functions
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
#endregion