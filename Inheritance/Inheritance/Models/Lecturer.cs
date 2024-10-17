namespace Inheritance.Models;

public class Lecturer : Employee
{
    private const decimal rate = 1.1m;

    public string Subject { get; set; }

    public override decimal CalculateSalary(decimal bonus)
    {
        var salary = base.CalculateSalary(bonus);
        return salary * rate;
    }
}