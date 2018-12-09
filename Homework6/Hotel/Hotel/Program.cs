using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Rate r1 = new Rate();
            r1.Amount = 150;
            r1.Currency = "$";
            Console.WriteLine(r1.Print());

            Room rm1 = new Room("FamilySuite");
            rm1.Rate = r1;
            rm1.Adults = 2;
            rm1.Children = 1;
            Console.WriteLine(rm1.Print());
            //Console.WriteLine("Enter number of days");
            //int nrOfDays = Convert.ToInt32(Console.ReadLine());
            int nrOfDays = 4;
            Console.WriteLine("Price for " + nrOfDays + " days: " + rm1.GetPriceForDays(nrOfDays) + rm1.Rate.Currency);

            Room rm2 = new Room("DoubleRoom");
            Room rm3 = new Room("SingleRoom");

            Hotel h1 = new Hotel();
            h1.Name = "MagicTime";
            h1.City = "Hogwarts";
            h1.AddRoom(rm1);
            Console.WriteLine("Total price for 5 " + rm1.Name + ": " + h1.GetPriceForNumberOfRooms(rm1,5));
            h1.AddRoom(rm2);
            h1.AddRoom(rm3);
            Console.WriteLine(h1.Print());

            Console.ReadKey();
        }
    }
}
