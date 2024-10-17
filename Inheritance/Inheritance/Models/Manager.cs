namespace Inheritance.Models;

public class Manager : Employee
{
    private const decimal rate = 1.2m;

    public string DepartmentName { get; set; }

    public override decimal CalculateSalary(decimal bonus)
    {
        return Salary * rate;
    }
}