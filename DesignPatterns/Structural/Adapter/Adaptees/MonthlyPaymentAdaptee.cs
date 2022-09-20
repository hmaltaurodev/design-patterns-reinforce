using DesignPatterns.Structural.Adapter.Interfaces;
using DesignPatterns.Structural.Adapter.Models;

namespace DesignPatterns.Structural.Adapter.Adaptees
{
    public class MonthlyPaymentAdaptee : IAdaptee
    {
        public void ProcessMonthlyPayment(List<Student> students)
        {
            students.ForEach(student =>
            {
                Console.WriteLine($"Student {student.Name} - Monthly Payment R$ {student.MonthlyPayment}");
            });
        }
    }
}
