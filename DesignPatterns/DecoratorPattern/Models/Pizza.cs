using DesignPatterns.DecoratorPattern.Interfaces;

namespace DesignPatterns.DecoratorPattern.Models
{
    public class Pizza : IPizza
    {
        string IPizza.GetType()
        {
            return "This is a standard pizza";
        }
    }
}
