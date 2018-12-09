using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Author a1 = new Author("Misu")
            {
                BirthDate = new DateTime(1980, 10, 10),
                Email = "email"
            };
            var varsta = a1.ComputeAge();
            Console.WriteLine($"Varsta lui {a1.Name} este:{varsta}");


            Author a2 = new Author("Ionescu")
            {
                BirthDate = new DateTime(2000, 10, 10)
            };
            var varstaIonescu = a2.ComputeAge();


            Book b1 = new Book
            {
                Name = "Jungle Book",
                Author = a1,
                Year = 1950,
                Price = (decimal)9.95
            };
            Console.WriteLine(b1.Print());

            Console.ReadKey();
        }
    }
}
