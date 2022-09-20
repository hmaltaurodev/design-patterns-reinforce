namespace DesignPatterns.Structural.Adapter.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Course { get; set; }

        public decimal MonthlyPayment { get; set; }

        public Student(int id, string name, string course, decimal monthlyPayment)
        {
            Id = id;
            Name = name;
            Course = course;
            MonthlyPayment = monthlyPayment;
        }
    }
}
