using PizzaShop.Chicago;

namespace PizzaShop
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string pizzaType)
        {
            if (pizzaType.Equals("cheese"))
            {
                return new ChicagoStyleCheesePizza();
            }
            else if (pizzaType.Equals("veggie"))
            {
                return new ChicagoStyleVeggiePizza();
            }
            else if (pizzaType.Equals("clam"))
            {
                return new ChicagoStyleClamPizza();
            }
            else return null;
        }
    }
}