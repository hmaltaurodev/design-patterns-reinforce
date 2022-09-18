using DesignPatterns.DecoratorPattern.Interfaces;

namespace DesignPatterns.DecoratorPattern.Decorators
{
    // Concrete Decorator of Bacon
    public class BaconDecorator : PizzaDecorator
    {
        public BaconDecorator(IPizza pizza) : base(pizza)
        { }

        public override string GetType()
        {
            return $"{base.GetType()}\r\n with extra bacon";
        }
    }
}
