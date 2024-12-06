using HillerødSailingClubClassLibrary;
using HillerødSialingClub;
using System.Diagnostics;
using System.Reflection.Metadata;

Boat boat = new Boat(1, 4, "BodNavn", 2000, "benut", "macedes", 234, "julie");
Events evented = new Events(1, "juleaften", "der holdes juleaften event", 2024, 12, 24);
Blog blog = new Blog(1, "blogTitel", "text text text");
// booking create 
Employee employee = new Employee("kunde", 1, "casper", 42418990, "test@mail.com", "addresseTest1");
Member member = new Member(1, "casper", 42418990, "test@mail.com", "addresseTest1");

Booking booking = new Booking(0, member, boat, 2024, 12, 24);
BookingList bookingList = new BookingList();
bookingList.BookBoat(booking);
Console.WriteLine(bookingList.GetBookedBoat(0));

BoatDict boatDict = new BoatDict();

Console.WriteLine(boat);
Console.WriteLine(evented);
Console.WriteLine(blog);
