namespace PizzaShop.California
{
    public class CaliforniaPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string pizzaType)
        {
            if (pizzaType.Equals("cheese"))
            {
                return new CaliforniaStyleCheesePizza();
            }
            else if (pizzaType.Equals("veggie"))
            {
                return new CaliforniaStyleVeggiePizza();
            }
            else if (pizzaType.Equals("clam"))
            {
                return new CaliforniaStyleClamPizza();
            }
            else return null;
        }
    }
}