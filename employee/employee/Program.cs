Console.WriteLine("Hello, World!");



public class Employee
{
    public int EmployeeId { get; set; }
    public string FullName { get; set; }
    public string Position { get; set; }
    public decimal Salary { get; set; }
    public DateTime HireDate { get; set; }

    public void CalculateSalary() { }
    public void TakeLeave() { }
    public void ClockIn() { }
    public void ClockOut() { }
}