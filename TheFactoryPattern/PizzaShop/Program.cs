using System;
using PizzaShop.California;

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

    //public interface PizzaIngredientFactory
    //{
    //    abstract Dough CreateDough();
    //    abstract Sauce CreateSauce();
    //    abstract Cheese CreateCheese();
    //    abstract Veggies[] CreateVeggies();
    //    abstract Pepperoni CreatePepperoni();
    //    abstract Clams CreateClam();
    //}

    //public class NYPizzaIngredientFactory : PizzaIngredientFactory
    //{
    //    public Dough CreateDough()
    //    {
    //        return new ThinCrustDough();
    //    }

    //    public Sauce CreateSauce()
    //    {
    //        return new MarinaraSauce();
    //    }

    //    public Cheese CreateCheese()
    //    {
    //        return new ReggianoCheese();
    //    }

    //    public Veggies[] CreateVeggies()
    //    {
    //        Veggies veggies[] = {
    //            new Garlic(), new Onion(), new Mushroom(), new RedPepper()
    //        }
    //        ;
    //        return veggies;
    //    }

    //    public Pepperoni CreatePepperoni()
    //    {
    //        return new SlicedPepperoni();
    //    }

    //    public Clams createClams()
    //    {
    //        return new FreshClams();
    //    }
    //}
}
