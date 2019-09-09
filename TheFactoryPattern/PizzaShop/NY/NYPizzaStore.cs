using PizzaShop.NY;

namespace PizzaShop
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string pizzaType)
        {
            if (pizzaType.Equals("cheese"))
            {
                return new NYStyleCheesePizza();
            }
            else if (pizzaType.Equals("veggie"))
            {
                return new NYStyleVeggiePizza();
            }
            else if (pizzaType.Equals("clam"))
            {
                return new NYStyleClamPizza();
            }
            else return null;
        }
    }
}