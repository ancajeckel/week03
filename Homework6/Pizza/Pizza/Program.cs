using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaBase b1 = new PizzaBase("Italian");

            PizzaTopping t1 = new PizzaTopping("Bufallo Mozarella");
            t1.Cost = 3;
            PizzaTopping t2 = new PizzaTopping("Salami");
            t2.Name = t2.Name.ToUpper();
            t2.Cost = 5.6;
            PizzaTopping t3 = new PizzaTopping("Tomatoes");
            t3.Cost = 0.78;

            Pizza p1 = new Pizza(b1);
            p1.Name = "Capriciosa";
            p1.AddTopping(t1);
            p1.AddTopping(t2);
            p1.AddTopping(t3);
            p1.Print();


            Console.ReadKey();
        }
    }
}
