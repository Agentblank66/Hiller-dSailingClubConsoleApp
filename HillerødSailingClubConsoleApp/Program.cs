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
Console.WriteLine("---------------------Boat Part-----------------");
// Add string to the Two lists on object boat 
// get the two lists printed out
Console.WriteLine("Add text to MaintenceLog and Repairlog and print the two list out:");
boat.AddToMaintenanceLog("testtexttoMaintencelog");
boat.AddToMaintenanceLog("testtexttoMaintencelog2");
boat.RequestRepairs("testtextToReapairlog");
boat.RequestRepairs("testtextToReapairlog2");
Console.WriteLine("maintencelog: " + boat.PrintMaintenanceLog());
Console.WriteLine("repairslog: " + boat.PrintRepairsLog() + "\n");
#endregion

#region BoatRepo
// --------------------------- BoatRepo ---------------------------------
// creates object of BoatDict and adds 3 boats to the Dictioonary
Console.WriteLine("---------------BoatRepo Part------------");
BoatRepo boatRepo = new BoatRepo();
boatRepo.Add(boat);
boatRepo.Add(boat); // tilføjer ikkke båden igen til Dictionary
boatRepo.Add(boat2);
boatRepo.Add(boat3);



// Prints All boats from the Dictioonary
Console.WriteLine("Prints All boats from the Dictioonary:");
Console.WriteLine(boatRepo.PrintAllBoat() + "\n");

// Updates Boat with Id: 1 
boatRepo.Update(1, "type", "model", "name", 123, "engineinfo", 12, 1990);

// Get metode on 3 Boats 
Console.WriteLine("\n" + "Get metode on all 3 Boats:");
Console.WriteLine(boatRepo.GetBoat(1));
Console.WriteLine(boatRepo.GetBoat(2));
Console.WriteLine(boatRepo.GetBoat(3));

// Delete() on Boat with Id: 1 && PrintAllBoat
Console.WriteLine("\n" + "Delete() Boat with Id: 1 && PrintAllBoats:");
boatRepo.DeleteBoat(1);
Console.WriteLine(boatRepo.PrintAllBoat());


Console.WriteLine("\n Udskriver alle både, kalder SendBoatToRepair() og ser listen igen");
Console.WriteLine(boatRepo.PrintAllBoat());
boatRepo.SendBoatToRepair(boat2, "Hul i Bunden");
Console.WriteLine("\n see all boats from boats list \n" + boatRepo.PrintAllBoat());
Console.WriteLine();
Console.WriteLine("\n print all boats from repair list \n" + boatRepo.PrintAllRepairBoats());
Console.WriteLine();
boatRepo.GetBoatFromRepair(boat2);
Console.WriteLine("\n move boat 2 from repair to boat Dictionary and see all boats from boats list \n" + boatRepo.PrintAllBoat());

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

    // Start by adding members to the memberRepo Dictionary
    Console.WriteLine("Adding the created Member objects to memberRepo: Expects True\n");
    Console.WriteLine(memberRepo.AddMember(member));
    Console.WriteLine(memberRepo.AddMember(member2));
    Console.WriteLine(memberRepo.AddMember(member3));
    Console.WriteLine(memberRepo.AddMember(member4));
    Console.WriteLine("\nTrying to add an already existing member to the dictionary: Expects False\n");
    Console.WriteLine(memberRepo.AddMember(member4));
    Console.WriteLine("\nPrinting out all Member objects in the Dictionary memberRepo:\n");
    PrintMembers();

    // Deleting a member from the memberRepo Dictionary
    Console.WriteLine("\nPrinting out removed member:\n");
    Console.WriteLine(memberRepo.DeleteMember(member4));

    // Getting member 3 and 4, but 4 was deleted above so it will not get printed out
    Console.WriteLine("\nPrinting out the member with Key 3 and 4:\n");
    Console.WriteLine(memberRepo.GetMember(3));
    Console.WriteLine("Member4 ain't printed out, because it was deleted earlier:");
    Console.WriteLine(memberRepo.GetMember(4));

    // Updating member and member4, but member4 don't exist
    Console.WriteLine("Printing out the updated member:\n");
    Console.WriteLine(memberRepo.UpdateMember(member, "AddressTest0", "Kasper", "test0@mail.com", 43518990));

    // Printing out all members in the memberRepo Dictionary
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
    bookingRepo.AddBooking(booking);
    bookingRepo.AddBooking(booking2);
    bookingRepo.AddBooking(booking3);
    Console.WriteLine("\nPrinting out all booking objects in bookingRepo:\n");
    PrintBookings();

    // Deleting a Booking object from the bookingRepo
    bookingRepo.RemoveBooking(booking2);
    Console.WriteLine("\nPrinting out all bookings, after booking2 has been removed:\n");
    PrintBookings();

    // Getting booking and booking2, but booking2 was deleted above
    Console.WriteLine("\nPrintng out booking and booking2:\n");
    Console.WriteLine(bookingRepo.GetBooking(0));
    Console.WriteLine("booking2 is not printed out, because it was removed earlier\n");
    Console.WriteLine(bookingRepo.GetBooking(1));

    // Updating the booking object
    Console.WriteLine("Updating booking object and printing it out:\n");
    bookingRepo.UpdateBooking(booking, member, boat, 2025, 01, 01);
    Console.WriteLine(bookingRepo.GetBooking(0));

    // Printing all bookings out
    Console.WriteLine("\nPrinting out all booking objects:\n");
    PrintBookings();

    // Starting a rescue of a missing member
    Console.WriteLine("Printing out members that need rescueing!\n");
    Console.WriteLine(bookingRepo.RescueMember());

    // Getting all members that are out sailing
    Console.WriteLine("\nPrinting out all sailing memebers:\n");
    PrintSailingMembers(bookingRepo.MembersSailing());
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

// Starting by adding multiple event to events list, then showing them, and testing if they are added or ar already added
    Console.WriteLine("Testing to see if events have been added or not:");
    Console.WriteLine(events.AddEvents(event1));
    Console.WriteLine(events.AddEvents(event2)); 
    Console.WriteLine(events.AddEvents(event3));
    Console.WriteLine(events.AddEvents(event1));
    Console.WriteLine("Here we are printing the list of all the events, which are added to the events list, by using the GetAllEvents() method:");
    foreach (Event events1 in events.GetAllEvents()) Console.WriteLine(events1);
    Console.WriteLine();

//Update an event and the showing that one event
    Console.WriteLine("Here we update an Event by using the UpdateEvents() method, " +
        "\nand then print that event and see its changes");
    Console.WriteLine(events.UpdateEvents(1, "Juleaften", "Der holdes Juleaften.", 2025, 12, 24, 13, 49, 30));
    Console.WriteLine();

    // Here we will search after a specific event with "holdes" in the description
    Console.WriteLine("Here we use a foreach-loop where we search for the word, holdes, in the events descriptions, " +
        "\nand then return the events which has that word in the description, by using the SearchEvents() method. " +
        "\nFor every event, console WriteLine is called and that event is printed:");
    foreach (Event Events in events.SearchEvents("holdes")) Console.WriteLine(Events);
    Console.WriteLine();

    Console.WriteLine("Testing to see if event have been deleted or not:");
    Console.WriteLine(events.DeleteEvents(1));
    Console.WriteLine(events.DeleteEvents(1));
    Console.WriteLine("Showing the remaining list of events:");
    foreach (Event events1 in events.GetAllEvents()) Console.WriteLine(events1);

// Here we will get all events in the events list
Console.WriteLine("Here we use a foreach-loop, where we print out all the events, " +
        "\nby using the GetAllEvents() method. " +
        "\nFor every event, a console WriteLine is called and then that event is printed:");
    foreach (Event events1 in events.GetAllEvents()) Console.WriteLine(events1);
#endregion

#region JoinRepo
Console.WriteLine("\n------------------------------------------------------JoinRepo----------------------------------------------------------");
// --------------------------- JoinRepo --------------------------------
// Testing joinedRepo Methods:
JoinRepo membersjoined = new JoinRepo();
Join joiner1 = new Join(1, member, event1);
Join joiner2 = new Join(2, member2, event2);
Join joiner3 = new Join(3, member3, event3);

//Add member to list and printing all, and seeing if they added or already added
    Console.WriteLine("Testing to see if joined members have been added or not:");
    Console.WriteLine(membersjoined.JoinEvent(joiner1));
    Console.WriteLine(membersjoined.JoinEvent(joiner2));
    Console.WriteLine(membersjoined.JoinEvent(joiner3));
    Console.WriteLine(membersjoined.JoinEvent(joiner1));
    Console.WriteLine("Her we use a foreach-loop to print out a list of objects, " +
        "\nby printing out the id, the members and the events with the GetAllJoinedMembers() method. " +
        "\nFor every joinedmembers, a console WriteLine is called and then that object is printed:");
    foreach (Join joinedMembers in membersjoined.GetAllJoinedMember()) Console.WriteLine(joinedMembers);

    //Showing the last member to join the event/list
    Console.WriteLine("Here we print out the last object to join the list:");
    Console.WriteLine(membersjoined.ShowLastMember());

    //Delte a member that has joined, then shwo the list
    Console.WriteLine("Here we delete a object from the list, by using the DeleteMemberInEvent() method, " +
        "\nand are then using a foreach-loop, where printing out the remaining objects in the list with the GetAllJoinedMembers() method. " +
        "\nFor every joinedmembers, a console WriteLine is called and then that object is printed:");
    membersjoined.DeleteMemberInEvent(joiner1);
    foreach (Join joinedMembers in membersjoined.GetAllJoinedMember()) Console.WriteLine(joinedMembers);
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
Console.WriteLine("-----------------------------------------");

// Get blog by Id update and get again 

Console.WriteLine("Here we get Blog 1:");
Console.WriteLine( Blogs.GetBlogPost(1));
Console.WriteLine();
Console.WriteLine("------------------------------------------");
Console.WriteLine("Here we get blog 1, and update it:");
Blogs.UpdateBlogPost( blog, 1, "Jeg fandt uret!", "Allan og Mathias fandt uret tidligere i dag!");

// delete blog with Id 1
Console.WriteLine(blog);
Console.WriteLine("...........................................");
Console.WriteLine();
Console.WriteLine(blog2);
Console.WriteLine();
Console.WriteLine(blog3);
Console.WriteLine("-----------------------------------------");
Console.WriteLine("\n" +"Here we get blog 3, and delete it:");
Blogs.DeleteBlogPost(3);
Console.WriteLine(Blogs.GetAllBlogs()+"\n");
Console.WriteLine();
Console.WriteLine("-----------------------------------------");


// Search blog
Console.WriteLine("\n" +"Here we use our search method, and searching by word. The first one will NOT show anything due to invalid input. The second will find the word in titel, and last one will find the word i text show searched object:");
Console.WriteLine("\n" +"Here we search for 'Jordbærtærte':");
Console.WriteLine(Blogs.SearchBlog("Jordbærtærte")+ "\n");
Console.WriteLine("Here we search for 'Sommerfest':");
Console.WriteLine(Blogs.SearchBlog("Sommerfest")+ "\n");
Console.WriteLine("Here we search for 'Allan':");
Console.WriteLine(Blogs.SearchBlog("Allan") + "\n");
Console.WriteLine("Here we search for 'er':");
Console.WriteLine(Blogs.SearchBlog("er"));
#endregion

#region EmployeeRepo
// --------------------------- EmployeeRepo --------------------------------
// Creating Employee Objects:
Console.WriteLine("\n--------------------------------------------------EmployeeRepo----------------------------------------------------------");
Employee employee = new Employee("\n"+"Medarbejder", 1, "Torsten Jensen", 42418990, "Torstj@mail.com", "Midtvejskrigsvej 54");
Employee employee1 = new Employee("Medarbejder", 2, "Preben Larsen", 45324567, "Preben@mail.com", "Ondstorkevej 2");
Employee employee2 = new Employee("Medarbejder", 3, "Michael Antonsen", 43675473, "Micant@gmail.com", "Vildmarksvej 69");

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
Console.WriteLine("-------------------------------------");

//Update employee with new employee
Console.WriteLine("Here we've updated Employee 1, to a new member:");
employeeDict.Update(employee, "Anders Andersen", 4655532, "andand@gmail.com", "OndPræstevej");
Console.WriteLine(employee);
Console.WriteLine("-------------------------------------");


//Get employee
Console.WriteLine("Here we get employee 2:");
employeeDict.GetEmployee(2);
Console.WriteLine(employee2);
Console.WriteLine("-------------------------------------");

//Delete employee
employeeDict.DeleteEmployee(2);
Console.WriteLine();
Console.WriteLine("Removing Employee 2:");
employeeDict.PrintAllEmployees();
Console.WriteLine("-------------------------------------");

//Printing all employees
Console.WriteLine("Here we print all employees:");
PrintAllEmployees(employeeDict.PrintAllEmployees());
Console.WriteLine("-------------------------------------");
#endregion

#region Functions
// ---------------------------Function----------------------------------------
void PrintMembers()
{
    foreach (Member member in memberRepo.PrintAllMembers()) Console.WriteLine(member);
}
void PrintBookings()
{
    foreach (Booking booking in bookingRepo.PrintAllBookings()) Console.WriteLine(booking);
}
void PrintSailingMembers(List<Member> membersSailing)
{
    foreach (Member member in membersSailing) Console.WriteLine(member);
}
void PrintAllEmployees(List<Employee> employees)
{
    foreach (Employee employee in employees) Console.WriteLine(employee);
}
#endregion