using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Pizza
    {
        public Pizza(PizzaBase pb)
        {
            this.Name = Name;
            this.PizzaBase = pb;
            this.PizzaTopping = new List<PizzaTopping>();
        }

        public string Name { get; set; }

        public PizzaBase PizzaBase { get; set; }

        public List<PizzaTopping> PizzaTopping { get; set; }

        public void AddTopping(PizzaTopping pizzaTopping)
        {
            PizzaTopping.Add(pizzaTopping);
        }

        public double CalculateTotalCost()
        {
            double total_cost = 0;
            total_cost = total_cost + this.PizzaBase.Cost;

            foreach (var topping in this.PizzaTopping)
            {
                total_cost = total_cost + topping.Cost;
            }

            return total_cost;
        }

        public void Print()
        {
            Console.WriteLine("Pizza " + this.Name);
            Console.WriteLine("Base: " + this.PizzaBase.Print());
            Console.WriteLine("Toppings:");
            foreach (var topping in this.PizzaTopping)
            {
                Console.WriteLine(topping.Print());
            }
            Console.WriteLine("Total cost: $" + this.CalculateTotalCost());
        }
    }
}
