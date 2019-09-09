namespace PizzaShop.California
{
    public class CaliforniaStyleVeggiePizza : Pizza
    {
        public CaliforniaStyleVeggiePizza()
        {
            this.Name = "California Style Sauce and Veggie Pizza";
            this.Dough = "Thin Crust Dough";
            this.Sauce = "Marinara Sauce";

            Toppings.Add("Grated Veggie California Mozzarella cheese");
        }
    }
}