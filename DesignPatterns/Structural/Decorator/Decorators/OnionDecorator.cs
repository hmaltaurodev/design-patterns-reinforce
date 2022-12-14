using DesignPatterns.Structural.Decorator.Interfaces;

namespace DesignPatterns.Structural.Decorator.Decorators
{
    // Concrete Decorator of Onion
    public class OnionDecorator : PizzaDecorator
    {
        public OnionDecorator(IPizza pizza) : base(pizza)
        { }

        public override string GetPizzaType()
        {
            return $"{base.GetPizzaType()}\r\n with extra onion";
        }
    }
}
