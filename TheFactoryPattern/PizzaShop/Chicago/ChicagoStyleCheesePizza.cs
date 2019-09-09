using System;

namespace PizzaShop.Chicago
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            this.Name = "Chicago Style Sauce and Cheese Pizza";
            this.Dough = "Thin Crust Dough";
            this.Sauce = "Marinara Sauce";

            Toppings.Add("Grated Reggiano cheese");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}