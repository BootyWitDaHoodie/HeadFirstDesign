using PizzaShop.California;

namespace PizzaShop
{
    public class PizzaHandler
    {
        public Pizza MakePizza(string kind, string type)
        {
            if (kind.Equals("ny"))
            {
                return new NYPizzaStore().OrderPizza(type);
            }
            else if (kind.Equals("chicago"))
            {
                return new ChicagoPizzaStore().OrderPizza(type);
            }
            else if (kind.Equals("california"))
            {
                return new CaliforniaPizzaStore().OrderPizza(type);
            }
            else
            {
                return null;
            }
        }
    }
}