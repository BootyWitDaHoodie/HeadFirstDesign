using System;

namespace PizzaShop.Chicago
{
    public class ChicagoStyleClamPizza : Pizza
    {
        public ChicagoStyleClamPizza()
        {
            this.Name = "Chicago Style Sauce and Clam Pizza";
            this.Dough = "Thin Crust Dough";
            this.Sauce = "Marinara Clam Sauce";

            Toppings.Add("Raw Sauce");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}