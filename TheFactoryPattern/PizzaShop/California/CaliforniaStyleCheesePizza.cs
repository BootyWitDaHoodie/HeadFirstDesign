namespace PizzaShop.California
{
    public class CaliforniaStyleCheesePizza : Pizza
    {
        public CaliforniaStyleCheesePizza()
        {
            this.Name = "California Style Sauce and Cheese Pizza";
            this.Dough = "Thin Crust Dough";
            this.Sauce = "Marinara Sauce";

            Toppings.Add("Grated California Reggiano cheese");
        }
    }
}