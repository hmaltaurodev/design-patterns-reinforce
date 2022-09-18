using DesignPatterns.DecoratorPattern.Interfaces;

namespace DesignPatterns.DecoratorPattern.Decorators
{
    // Concrete Decorator of Onion
    public class OnionDecorator : PizzaDecorator
    {
        public OnionDecorator(IPizza pizza) : base(pizza)
        { }

        public override string GetType()
        {
            return $"{base.GetType()}\r\n with extra onion";
        }
    }
}
