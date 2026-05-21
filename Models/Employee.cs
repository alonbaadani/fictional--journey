namespace fictional__journey.Models;

public class Employee
{
    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public DateOnly HiringDate { get; set; }

    public string Department { get; set; } = string.Empty;

    public string JobTitle { get; set; } = string.Empty;
}
