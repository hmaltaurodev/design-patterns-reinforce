using DesignPatterns.DecoratorPattern.Interfaces;

namespace DesignPatterns.DecoratorPattern.Decorators
{
    // Concrete Decorator of Cheese
    public class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(IPizza pizza) : base(pizza)
        { }

        public override string GetType()
        {
            return $"{base.GetType()}\r\n with extra cheese";
        }
    }
}
