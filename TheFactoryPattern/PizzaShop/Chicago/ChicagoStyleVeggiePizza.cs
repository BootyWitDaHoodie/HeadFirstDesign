using System;

namespace PizzaShop.Chicago
{
    public class ChicagoStyleVeggiePizza : Pizza
    {
        public ChicagoStyleVeggiePizza()
        {
            this.Name = "Chicago Style Deep Dish Veggie Pizza";
            this.Dough = "Thick Crust Dough";
            this.Sauce = "Plum tomato Sauce";

            Toppings.Add("Shredded Veggie Mozzarella cheese");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}