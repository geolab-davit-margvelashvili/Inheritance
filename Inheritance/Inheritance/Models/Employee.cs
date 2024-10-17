namespace Inheritance.Models;

public class Employee
{
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }

    public decimal Salary { get; set; }

    public virtual decimal CalculateSalary(decimal bonus)
    {
        return Salary + bonus;
    }
}