using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSailingClubClassLibrary
{
    public class Events
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public Events(int id, string name, string description, int year, int month, int day, int hour, int minute, int second)
        {
            Id = id;
            Name = name;
            Description = description;
            Date = new DateTime(year, month, day, hour, minute, second);
        }

        //Method which overrrides the base ConsoleWriteLine
        public override string ToString()
        {
            return $"Id: {Id} \nName: {Name} \nDescription: {Description} \nDate: {Date}";
        }

    }
}
