namespace PizzaShop.NY
{
    public class NYStyleVeggiePizza : Pizza
    {
        public NYStyleVeggiePizza()
        {
            this.Name = "NY Style Veggie Pizza";
            this.Dough = "Thin Crust Dough";
            this.Sauce = "Marinara Sauce";

            Toppings.Add("Grated Veggie cheese");
        }
    }
}