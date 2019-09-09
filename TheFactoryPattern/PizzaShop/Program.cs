using System;

namespace PizzaShop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Let's test sum pizza's
            
            //PizzaStore nyStore = new NYPizzaStore();
            //PizzaStore chicagoStore = new ChicagoPizzaStore();
            PizzaHandler pp = new PizzaHandler();

            Pizza pizza = pp.MakePizza("ny", "cheese"); //nyStore.OrderPizza("cheese");
            Console.WriteLine($"Ethan ordered a {pizza.GetName()}\n");
            pizza = pp.MakePizza("ny", "clam"); //chicagoStore.OrderPizza("cheese");
            Console.WriteLine($"Joel ordered a {pizza.GetName()}\n");
            pizza = pp.MakePizza("california", "veggie"); //chicagoStore.OrderPizza("veggie");
            Console.WriteLine($"Joel ordered a {pizza.GetName()}\n");
            pizza = pp.MakePizza("chicago", "cheese"); //nyStore.OrderPizza("clam");
            Console.WriteLine($"Ethan ordered a {pizza.GetName()}\n");
            Console.WriteLine("\n\nNew Pizza incoming");
            pizza = pp.MakePizza("california", "clam");
            Console.WriteLine($"We ordered a {pizza.GetName()}");
        }
    }

    //public class SimplePizzaFactory
    //{
    //    // 1 job: creating pizza for its clients
    //    public Pizza CreatePizza(string pizzaType)
    //    {
    //        Pizza pizza = null;

    //        if (pizzaType.Equals("cheese"))
    //        {
    //            pizza = new CheesePizza();
    //        }
    //        else if (pizzaType.Equals("pepperoni"))
    //        {
    //            pizza = new PepperoniPizza();
    //        }
    //        else if (pizzaType.Equals("veggie"))
    //        {
    //            pizza = new VeggiePizza();
    //        }

    //        return Pizza;
    //    }
    //}
    // OLD PIZZASTORE
    //public class PizzaStore // the client of the factory
    //{
    //    SimplePizzaFactory factory;

    //    public PizzaStore(SimplePizzaFactory factory)
    //    {
    //        this.factory = factory;
    //    }

    //    public Pizza orderPizza(string pizzaType)
    //    {
    //        Pizza pizza;
    //        pizza = factory.CreatePizza(pizzaType);
    //        pizza.Prepare();
    //        pizza.Bake();
    //        pizza.Cut();
    //        pizza.Box();
    //        return pizza;
    //    }
    //}

    // NEW PIZZASTORE
}
