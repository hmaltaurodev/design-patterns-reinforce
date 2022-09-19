using DesignPatterns.DecoratorPattern.Interfaces;

namespace DesignPatterns.DecoratorPattern.Models
{
    public class Pizza : IPizza
    {
        public string GetPizzaType()
        {
            return "This is a standard pizza";
        }
    }
}
