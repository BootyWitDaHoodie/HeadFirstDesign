namespace PizzaShop
{
    public abstract class PizzaStore
    {
        protected abstract Pizza CreatePizza(string pizzaType);

        public Pizza OrderPizza(string pizzaType)
        {
            Pizza pizza = CreatePizza(pizzaType);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

    }
}