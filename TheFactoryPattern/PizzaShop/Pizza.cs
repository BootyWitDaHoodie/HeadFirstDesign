using System;
using System.Collections.Generic;

namespace PizzaShop
{
    public abstract class Pizza
    {
        protected string Name;
        protected string Dough;
        protected string Sauce;
        protected List<string> Toppings = new List<string>();

        public virtual void Prepare()
        {
            Console.WriteLine($"Preparing {this.Name}" +
                              $"\nTossing dough..." +
                              $"\nAdding sauce..." +
                              $"\nAdding toppings: ");
            foreach (var topping in this.Toppings)
            {
                Console.WriteLine($" {topping}");
            }
        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into lots of slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public virtual string GetName()
        {
            return this.Name;
        }
    }
}