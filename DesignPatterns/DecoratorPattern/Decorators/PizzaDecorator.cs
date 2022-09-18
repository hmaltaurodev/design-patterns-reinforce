using DesignPatterns.DecoratorPattern.Interfaces;

namespace DesignPatterns.DecoratorPattern.Decorators
{
    // Base Decorator
    public class PizzaDecorator : IPizza
    {
        private readonly IPizza _pizza;

        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public new virtual string GetType()
        {
            return _pizza.GetType();
        }
    }
}
