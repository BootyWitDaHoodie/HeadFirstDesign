namespace PizzaShop.NY
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            this.Name = "NY Style Sauce and Cheese Pizza";
            this.Dough = "Thin Crust Dough";
            this.Sauce = "Marinara Sauce";

            Toppings.Add("Grated Reggiano cheese");
        }
    }
}