using DesignPatterns.Interfaces;
using DesignPatterns.Structural.Decorator.Decorators;
using DesignPatterns.Structural.Decorator.Interfaces;
using DesignPatterns.Structural.Decorator.Models;

namespace DesignPatterns.Structural.Decorator
{
    public class DecoratorExample : IPatternExample
    {
        public static void Execute()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\r\nDecorator Example");
            Console.ForegroundColor = ConsoleColor.DarkGray;

            IPizza pizza = new Pizza();
            IPizza cheeseDecorator = new CheeseDecorator(pizza);
            IPizza baconDecorator = new BaconDecorator(cheeseDecorator);
            IPizza onionDecorator = new OnionDecorator(baconDecorator);

            Console.WriteLine(onionDecorator.GetPizzaType());
        }
    }
}
