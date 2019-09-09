namespace PizzaShop.California
{
    public class CaliforniaStyleClamPizza : Pizza
    {
        public CaliforniaStyleClamPizza()
        {
            this.Name = "California Style Clam Pizza";
            this.Dough = "Thin Crust Dough";
            this.Sauce = "Marinara Sauce";

            Toppings.Add("Grated Clam sauce");
        }
    }
}