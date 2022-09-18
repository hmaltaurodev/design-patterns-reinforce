using DesignPatterns.DecoratorPattern.Decorators;
using DesignPatterns.DecoratorPattern.Interfaces;
using DesignPatterns.DecoratorPattern.Models;

namespace DesignPatterns.DecoratorPattern
{
    public class DecoratorExample
    {
        public static void Execute()
        {
            Console.WriteLine("# Decorator Example\r\n");

            IPizza pizza = new Pizza();
            IPizza cheeseDecorator = new CheeseDecorator(pizza);
            IPizza baconDecorator = new BaconDecorator(cheeseDecorator);
            IPizza onionDecorator = new OnionDecorator(baconDecorator);

            Console.WriteLine(onionDecorator.GetType());
        }
    }
}
