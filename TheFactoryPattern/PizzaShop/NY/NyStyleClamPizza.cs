namespace PizzaShop.NY
{
    public class NYStyleClamPizza : Pizza
    {
        public NYStyleClamPizza()
        {
            this.Name = "NY Style Sauce and Clam Pizza";
            this.Dough = "Thin Crust Dough";
            this.Sauce = "Marinara Clam Sauce";

            Toppings.Add("Raw Sauce");
        }
    }
}