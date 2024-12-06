using HillerødSailingClubClassLibrary;
using HillerødSialingClub;
using System.Diagnostics;
using System.Reflection.Metadata;

Boat boat = new Boat(1, 4, "Båd Navn", 2000, "Benut", "Macedes", 234, "Julie");
Events evented = new Events(1, "Juleaften", "Der holdes juleaften event.", 24, 12, 2024);
Events evented2 = new Events(2, "Påske", "Der holdes påskefrokost.", 5, 4, 2024);
Events evented3 = new Events(3, "Sommerstart", "Der fejres at sommeren begynder.", 21, 6, 2024);
Blog blog = new Blog(1, "blogTitel", "text text text");
// booking create 
Employee employee = new Employee("Kunde", 1, "Casper", 42418990, "test@mail.com", "addresseTest1");
Member member = new Member(1, "Casper", 42418990, "test@mail.com", "addresseTest1");


BoatDict boatDict = new BoatDict();
EventList events = new EventList();

events.AddEvents(evented);


Console.WriteLine(boat);
Console.WriteLine(evented);
Console.WriteLine(blog);

