using DesignPatterns.Structural.Adapter.Models;

namespace DesignPatterns.Structural.Adapter.Interfaces
{
    public interface IAdaptee
    {
        public void ProcessMonthlyPayment(List<Student> students);
    }
}
