using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Hotel
    {
        public Hotel()
        {
            this.Name = Name;
            this.City = City;
            ListOfRooms = new List<Room>();
        }
        public string Name { get; set; }

        public string City { get; set; }

        public List<Room> ListOfRooms { get; }

        public void AddRoom (Room newRoom)
        {
            ListOfRooms.Add(newRoom);
        }

        public decimal GetPriceForNumberOfRooms(Room rm, int numberOfRooms)
        {
            return rm.GetPriceForDays(1) * numberOfRooms;
        }

        public string Print()
        {
            StringBuilder sb = new StringBuilder ("Hotel " + this.Name + " in " + this.City + " has following rooms: ");
            foreach (var room in ListOfRooms)
            {
                sb.Append(room.Name + ", ");
            }
            return sb.ToString().Substring(0,sb.ToString().Length - 2);
        }

    }
}
