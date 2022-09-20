using DesignPatterns.Structural.Adapter.Adaptees;
using DesignPatterns.Structural.Adapter.Interfaces;
using DesignPatterns.Structural.Adapter.Models;

namespace DesignPatterns.Structural.Adapter.Adapters
{
    public class StudentAdapter : ITarget
    {
        public void ProcessMonthlyPayment(string[,] studentsArray)
        {
            MonthlyPaymentAdaptee monthlyPaymentAdaptee = new MonthlyPaymentAdaptee();

            string id = string.Empty;
            string name = string.Empty;
            string course = string.Empty;
            string monthlyPayment = string.Empty;

            List<Student> students = new List<Student>();

            for (int i = 0; i < studentsArray.GetLength(0); i++)
            {
                for (int j = 0; j < studentsArray.GetLength(1); j++)
                {
                    if (j == 0)
                        id = studentsArray[i, j];
                    else if (j == 1)
                        name = studentsArray[i, j];
                    else if (j == 2)
                        course = studentsArray[i, j];
                    else
                        monthlyPayment = studentsArray[i, j];
                }

                students.Add(new Student(Convert.ToInt32(id), name, course, Convert.ToDecimal(monthlyPayment)));
            }

            monthlyPaymentAdaptee.ProcessMonthlyPayment(students);
        }
    }
}
